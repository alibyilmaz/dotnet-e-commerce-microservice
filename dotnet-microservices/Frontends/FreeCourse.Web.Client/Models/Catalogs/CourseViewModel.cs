﻿using FreeCourse.Services.Catalog.API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models.Catalogs;

namespace FreeCourse.Web.Client.Models
{
    public class CourseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string UserId { get; set; }
        public string Picture { get; set; }


        public DateTime CreatedTime { get; set; }

        public FeaturedViewModel Feature { get; set; }


        public string CategoryId { get; set; }


        public CategoryViewModel Category { get; set; }
    }
}
