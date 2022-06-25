using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Client.Models.Catalogs
{
    public class CourseUpdateInput
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string UserId { get; set; }
        public string Picture { get; set; }

        public FeaturedViewModel Feature { get; set; }

        public string CategoryId { get; set; }
        [Display(Name = "Course Name")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
