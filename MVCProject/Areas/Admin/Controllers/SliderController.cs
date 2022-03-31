using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Constants;
using MVCProject.DAL;
using MVCProject.Extensions;
using MVCProject.Models;
using MVCProject.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.Controllers
{   [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult > Index()
        {
            var sliders =await _context.Sliders.ToListAsync();
            return View(sliders);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (!slider.ImageFile.isImageCondition())
            {
                ModelState.AddModelError("ImageFile", "Image type is wrong");
             return View();
            
            }
            //if (!slider.ImageFile.isImageCondition())
            //{
            //    ModelState.AddModelError("ImageFile", "Size is over");

            //    return View();
            //}
            //var wwwRootPath = /*_env.WebRootPath*/;
            //var ImageName = Guid.NewGuid()+ slider.ImageFile.FileName;

            var folderPath = FileConstants.ImagePath;

            //FileStream stream = new FileStream(fullPath, FileMode.Create);
            //await slider.ImageFile.CopyToAsync(stream);
            //stream.Close();

            slider.Image = FileUtils.CreateFile(folderPath,slider.ImageFile) ;
           await _context.Sliders.AddAsync(slider);
           await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
           
        }
        public async Task<IActionResult> Delete(int id)
        {
            var slider =await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task <IActionResult> DeleteSlider(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.ImagePath, slider.Image);


            //delete file

            //if (System.IO.File.Exists(fullPath))
            //{
            //    System.IO.File.Delete(fullPath);
            //}

            FileUtils.DeleteFile(fullPath);


            _context.Sliders.Remove(slider);
           
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);

            if (slider == null) return NotFound();

           return View(slider);

            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update (int id, Slider slider)
        {
            var dbslider = await _context.Sliders.FindAsync(id);

            if(dbslider==null) return NotFound();
            if (id != slider.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.ImagePath, dbslider.Image));

            dbslider.Image = FileUtils.CreateFile(FileConstants.ImagePath, slider.ImageFile);

            dbslider.TitleUp = slider.TitleUp;
            dbslider.TitleUp = slider.TitleUp;
            dbslider.Desciption = slider.Desciption;
            dbslider.Button = slider.Button;
            dbslider.Order = slider.Order;
           

         
           await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

           

        }

    }
       
    }

