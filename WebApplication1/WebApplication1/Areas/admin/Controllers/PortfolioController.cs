using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.admin.Controllers
{
    [Area("admin")]
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfolioController(AppDbContext context , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.PortFolios.Include(u=>u.User).ToList());

        }

        public IActionResult Create()
        {
            ViewBag.Portfolios = _context.PortFolios.ToList();
            return View();

        }
        [HttpPost]
        public IActionResult Create(PortFolio model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length <= 3145728)
                    {
                        string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.PortImage = fileName;
                        
                        model.UserId = 1;
                        _context.PortFolios.Add(model);
                        _context.SaveChanges();

                        return RedirectToAction("index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can only upload max 3 mb file!");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can only upload image file!");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Update(int? id)
        {
            ViewBag.Portfolios = _context.PortFolios.ToList();
            return View(_context.PortFolios.Find(id));
        }

        [HttpPost]
        public IActionResult Update(PortFolio model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length <= 3145728)
                        {
                            string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.PortImage);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }

                            string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.PortImage = fileName;

                            _context.PortFolios.Update(model);
                            _context.SaveChanges();

                            return RedirectToAction("index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can only upload max 3 mb file!");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can only upload image file!");
                        return View(model);
                    }
                }
                else
                {
                    _context.PortFolios.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PortFolio blog = _context.PortFolios.Find(id);
            if (blog == null)
            {
                return NotFound();
            }

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", blog.PortImage);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            _context.PortFolios.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
