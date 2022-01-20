using FreeCourse.Services.Catalog.API.Dtos;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.API.Services
{
   public interface ICourseService
    {
        Task<ResponseDto<List<CourseDto>>> GetAllAsync();
        Task<ResponseDto<CourseDto>> GetByIdAsync(string id);

        Task<ResponseDto<List<CourseDto>>> GetAllByUserId(string userId);
        Task<ResponseDto<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);


        Task<ResponseDto<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);

        Task<ResponseDto<NoContent>> DeleteAsync(string id);
    }
}
