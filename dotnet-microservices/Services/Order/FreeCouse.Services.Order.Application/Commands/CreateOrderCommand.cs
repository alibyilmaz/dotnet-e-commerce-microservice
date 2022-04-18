using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCouse.Services.Order.Application.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FreeCourse.Services.Order.Application.Commands
{
   public class CreateOrderCommand:IRequest<ResponseDto<CreatedOrderDto>>, IRequest<CreatedOrderDto>
   {
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AddressDto AddressDto { get; set; }
    }
}
