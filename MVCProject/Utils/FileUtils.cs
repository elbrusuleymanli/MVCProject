using Microsoft.AspNetCore.Http;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Utils
{
    public class FileUtils
    {
     public static string CreateFile( string folderPath,IFormFile file)
    {
        var ImageName = Guid.NewGuid() + file.FileName;
        
        var fullPath = Path.Combine(folderPath, ImageName);

        FileStream stream = new FileStream(fullPath, FileMode.Create);
        file.CopyTo(stream);
        stream.Close();

        return ImageName;
    }

        public static void DeleteFile(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
    
}
