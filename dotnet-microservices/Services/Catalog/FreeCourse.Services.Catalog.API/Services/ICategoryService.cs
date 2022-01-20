using FreeCourse.Services.Catalog.API.Dtos;
using FreeCourse.Services.Catalog.API.Models;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.API.Services
{
  public  interface ICategoryService
    {
        Task<ResponseDto<List<CategoryDto>>> GetAllAsync();
        Task<ResponseDto<CategoryDto>> CreateAsync(Category category);

        Task<ResponseDto<CategoryDto>> GetByIdAsync(string id);
    }
}
