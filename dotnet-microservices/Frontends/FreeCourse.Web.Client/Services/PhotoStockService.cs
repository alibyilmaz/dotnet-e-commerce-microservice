using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.PhotoStocks;
using FreeCourse.Web.Client.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Client.Services
{
    public class PhotoStockService : IPhotoStockService
    {

        private readonly HttpClient _httpClient;
        public async Task<bool> DeletePhoto(string photoUrl)
        {
            var response = await _httpClient.DeleteAsync($"photos?photoUrl={photoUrl}");
            return response.IsSuccessStatusCode;
        }

        public async Task<PhotoStockViewModel> UploadPhoto(IFormFile photo)
        {
            if (photo == null || photo.Length <= 0)
            {
                return null;
            }

            var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photo.FileName)}";
            using var ms = new MemoryStream();
            await photo.CopyToAsync(ms);
            var multipartContent = new MultipartFormDataContent();
            multipartContent.Add(new ByteArrayContent(ms.ToArray()),"photo",randomFileName);

            var response = await _httpClient.PostAsync("photos", multipartContent);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadFromJsonAsync<PhotoStockViewModel>();
        }
    }
}
