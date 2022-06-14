using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models;
using FreeCourse.Web.Client.Models.Catalogs;

namespace FreeCourse.Web.Client.Services.Interfaces
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourseAsync();
        Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId);
        Task<List<CourseViewModel>> GetAllCourseByIdAsync(string courseId);

        Task<bool> DeleteCourseAsync(string courseId);
        Task<bool> AddCourseAsync(CourseCreateInput courseCreateInput);
        Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput);


    }
}
