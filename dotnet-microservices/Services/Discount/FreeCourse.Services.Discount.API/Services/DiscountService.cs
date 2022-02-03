using Dapper;
using FreeCourse.Shared.Dtos;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.API.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;

            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql"));
        }
        public async Task<ResponseDto<NoContent>> Delete(int id)
        {
            var status = await _dbConnection.ExecuteAsync("delete from discount id=@Id", new { Id = id });

            return status > 0 ? ResponseDto<NoContent>.Success(204) : ResponseDto<NoContent>.Fail("not found",404);
        }

        public async Task<ResponseDto<List<Models.Discount>>> GetAll()
        {
            var discount = await _dbConnection.QueryAsync<Models.Discount>("Select * from discount");
            return ResponseDto<List<Models.Discount>>.Success(discount.ToList(), 200);
        }

        public async Task<ResponseDto<Models.Discount>> GetByCodeAndUserId(string code, string userid)
        {
            var discount = await _dbConnection.QueryAsync<Models.Discount>("Select * from discount where userid=@UserId and code=@Code", new { UserId = userid, Code=code});
            var hashDiscount = discount.FirstOrDefault();
            
            if (hashDiscount == null)
            {
                return ResponseDto<Models.Discount>.Fail("not found", 404);
            }
            return ResponseDto<Models.Discount>.Success(hashDiscount, 200);
        }

        public async Task<ResponseDto<Models.Discount>> GetById(int id)
        {
            var discount = (await _dbConnection.QueryAsync<Models.Discount>("Select * from discount where id=@Id",new {Id = id }))
                .SingleOrDefault();
            if (discount==null)
            {
                return ResponseDto<Models.Discount>.Fail("not found", 404);
            }
            return ResponseDto<Models.Discount>.Success(discount, 200);



        }

        public async Task<ResponseDto<NoContent>> Save(Models.Discount discount)
        {
            var status = await _dbConnection.ExecuteAsync("INSERT INTO discount(userid,rate,code) VALUES(@UserId,@Rate,@Code)",discount);

            if (status>0)
            {
                return ResponseDto<NoContent>.Success(204);
            }

            return ResponseDto<NoContent>.Fail("error occured",400);

        }

        public async Task<ResponseDto<NoContent>> Update(Models.Discount discount)
        {
            var status = await _dbConnection.ExecuteAsync("update discount set userid=@UserId,code=@Code,rate=@Rate where id=@Id",new { 
            
            Id=discount.Id, UserId=discount.UserId,Code=discount.Code,Rate=discount.Rate
            });
            if (status > 0)
            {
                return ResponseDto<NoContent>.Success(204);
            }
            return ResponseDto<NoContent>.Fail("error occured", 400);
        }
    }
}
