using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.Baskets;

namespace FreeCourse.Web.Client.Services.Interfaces
{
    public interface IBasketService
    {
        Task<bool> SaveOrUpdate(BasketViewModel basketViewModel);

        Task<BasketViewModel> GetBasketAsync();

        Task<bool> DeleteBasketAsync();

        Task AddBasketItem(BasketViewModel basketViewModel);

        Task<bool> RemoveBasketItem(string courseId);

        Task<bool> ApplyDiscount(string discountCode);
        Task<bool> CancelApplyDiscount();
    }
}
