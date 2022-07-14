using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeCourse.Services.Order.Domain.OrderAggregate;
using FreeCourse.Services.Order.Infrastructure;
using FreeCourse.Shared.Messages;
using MassTransit;

namespace FreeCourse.Services.Order.Application.Consumer
{
    public class CreateOrderMesssageCommandConsumer : IConsumer<CreateOrderMesssageCommand>
    {
        private readonly OrderDbContext _orderDbContext;

        public CreateOrderMesssageCommandConsumer(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;   
        }
        public async Task Consume(ConsumeContext<CreateOrderMesssageCommand> context)
        {
            var newAddress = new Address(context.Message?.Province, context.Message?.District,
                context.Message?.Street, context.Message?.ZipCode, context.Message?.Line);

            Domain.OrderAggregate.Order order = new Domain.OrderAggregate.Order(context.Message?.BuyerId, newAddress);

            context.Message.OrderItems.ForEach(x =>
            {
                order.AddOrderItem(x.ProductId, x.ProductName, x.Price, x.PictureUrl);
            });

            await _orderDbContext.Orders.AddAsync(order);
            await _orderDbContext.SaveChangesAsync();
        }
    }
}
