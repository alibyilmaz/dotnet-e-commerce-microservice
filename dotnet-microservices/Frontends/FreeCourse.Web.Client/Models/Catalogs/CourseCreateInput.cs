using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Client.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Course Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Course Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Course Price")]
        [Required]
        public decimal Price { get; set; }

        public string UserId { get; set; }
        public string Picture { get; set; }

        public FeaturedViewModel Feature { get; set; }
        [Display(Name = "Course Category")]
        [Required]
        public string CategoryId { get; set; }


      
    }
}
