using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCouse.Services.Order.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery : IRequest<ResponseDto<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
