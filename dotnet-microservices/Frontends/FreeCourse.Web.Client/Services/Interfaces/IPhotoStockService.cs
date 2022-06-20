using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.PhotoStocks;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Client.Services.Interfaces
{
   public interface IPhotoStockService
   {
       Task<PhotoStockViewModel> UploadPhoto(IFormFile photo);
       Task<bool> DeletePhoto(string photoUrl);
   }
}
