using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Client.Models;
using FreeCourse.Web.Client.Models.Catalogs;
using FreeCourse.Web.Client.Services.Interfaces;

namespace FreeCourse.Web.Client.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;

        public CatalogService(HttpClient client)
        {
            _client = client;   
        }
        public Task<bool> AddCourseAsync(CourseCreateInput courseCreateInput)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCourseAsync(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewModel>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseViewModel>> GetAllCourseAsync()
        {
            var response = await _client.GetAsync("courses");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<ResponseDto<List<CourseViewModel>>>();
            return responseSuccess.Data;
        }

        public Task<List<CourseViewModel>> GetAllCourseByIdAsync(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            throw new NotImplementedException();
        }
    }
}
