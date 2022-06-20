using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.PhotoStocks;
using FreeCourse.Web.Client.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Client.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        public Task<bool> DeletePhoto(string photoUrl)
        {
            throw new NotImplementedException();
        }

        public Task<PhotoStockViewModel> UploadPhoto(IFormFile photo)
        {
            throw new NotImplementedException();
        }
    }
}
