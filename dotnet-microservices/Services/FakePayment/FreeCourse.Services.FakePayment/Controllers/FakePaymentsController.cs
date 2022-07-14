using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Services.FakePayment.API.Models;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.Messages;
using FreeCourse.Shared.Services;
using MassTransit;

namespace FreeCourse.Services.FakePayment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public FakePaymentsController(ISendEndpointProvider sendEndpointProvider)
        {
            this._sendEndpointProvider = sendEndpointProvider;
        }
        [HttpPost]
        public async Task<IActionResult> ReceivePayment(PaymentDto paymentDto)
        {
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:order"));

            var createOrderMessageCommand = new CreateOrderMesssageCommand();
            createOrderMessageCommand.BuyerId = paymentDto?.Order.BuyerId;
            createOrderMessageCommand.Province = paymentDto.Order.Address.Province;
            createOrderMessageCommand.District = paymentDto.Order.Address.District;
            createOrderMessageCommand.Street = paymentDto.Order.Address.Street;
            createOrderMessageCommand.Line = paymentDto.Order.Address.Line;

            paymentDto.Order.OrderItems.ForEach(x =>
            {
                createOrderMessageCommand.OrderItems.Add(new OrderItem
                {
                    PictureUrl = x.PictureUrl,
                    Price = x.Price,
                    ProductId = x.ProductId,
                    ProductName = x.ProductName

                });
            });

            await sendEndpoint.Send<CreateOrderMesssageCommand>(createOrderMessageCommand);

            return CreateActionResultInstance(ResponseDto<NoContent>.Success(200));
        }
    }
}
