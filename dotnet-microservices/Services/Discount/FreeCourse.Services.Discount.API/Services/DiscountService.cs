using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.API.Services
{
    public class DiscountService : IDiscountService
    {
        public Task<ResponseDto<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<Models.Discount>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<Models.Discount>> GetByCodeAndUserId(string code, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<Models.Discount>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> Save(Models.Discount discount)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> Update(Models.Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
