using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeAgencyMarketplace.Models;
using FreeAgencyMarketplace.Data;
using System.IO;

namespace FreeAgencyMarketplace.Controllers
{
	public class Images : Controller
	{
        private ApplicationDbContext _context;

        public Images()
		{
            _context = new ApplicationDbContext();
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult UploadImage()
		{
            foreach (var file in Request.Form.Files)
            {
                Image img = new Image(); //Instantiate new image instance
                img.ImageTitle = file.FileName; //Set image title property equal to the file name

                MemoryStream ms = new MemoryStream(); //create new memory stream
                file.CopyTo(ms); //Copy file contents to filestream
                img.ImageData = ms.ToArray();

                ms.Close();
                ms.Dispose(); //close up shop

                _context.Images.Add(img);
                _context.SaveChanges();
            }

            ViewBag.Message = "Image(s) stored in database!";

            return View("Index");
        }
	}
}
