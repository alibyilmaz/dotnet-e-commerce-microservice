using System.Net.Http;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.Baskets;
using FreeCourse.Web.Client.Services.Interfaces;

namespace FreeCourse.Web.Client.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }
        public async Task<bool> SaveOrUpdate(BasketViewModel basketViewModel)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BasketViewModel> GetBasketAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteBasketAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddBasketItem(BasketViewModel basketViewModel)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveBasketItem(string courseId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ApplyDiscount(string discountCode)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> CancelApplyDiscount()
        {
            throw new System.NotImplementedException();
        }
    }
}
