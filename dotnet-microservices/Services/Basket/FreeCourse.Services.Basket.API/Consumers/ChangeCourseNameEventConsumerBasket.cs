using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Services.Basket.API.Dtos;
using FreeCourse.Services.Basket.Services.API;
using FreeCourse.Shared.Messages;
using MassTransit;
using Newtonsoft.Json;

namespace FreeCourse.Services.Basket.API.Consumers
{
    public class ChangeCourseNameEventConsumerBasket : IConsumer<CourseNameChangedEvent>
    {
        private readonly RedisService _redisService;
    
        public ChangeCourseNameEventConsumerBasket(RedisService redisService)
        {
            _redisService = redisService;
        }
        public async Task Consume(ConsumeContext<CourseNameChangedEvent> context)
        {
            
           
            var course = context.Message;
      
            var courseDto = new BasketDto()
            {
            
                    basketItems = new List<BasketItemDto>()
                    {
                        new BasketItemDto()
                        {
                            CourseId = course.CourseId,
                            CourseName = course.UpdatedName
                        }
                    }
                
            };

            await _redisService.GetDb().HashSetAsync("userId", course.CourseId, JsonConvert.SerializeObject(courseDto));

        }
    }
}
