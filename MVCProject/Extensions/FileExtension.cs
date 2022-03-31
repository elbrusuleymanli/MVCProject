using Microsoft.AspNetCore.Http;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Extensions
{
    public static class FileExtension
    {
        public static bool isImageCondition(this IFormFile file)
        {
            return file.ContentType.Contains("image") && file.Length < 1024 * 1024;
        }
    }
}
