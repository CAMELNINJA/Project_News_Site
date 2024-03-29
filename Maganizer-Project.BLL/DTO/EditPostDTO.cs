﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maganizer_Project.BLL.DTO
{
    public class EditPostDTO
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public IFormFile FeaturedImage { get; set; }
        public string AuthorUsername { get; set; }
    }
}
