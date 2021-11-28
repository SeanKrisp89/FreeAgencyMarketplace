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

        [HttpPost]
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

            ViewBag.Message = "Image stored in database!";

            return View("Index");
        }

        [HttpGet]
        public IActionResult RetrieveLatestImage()
        {
            Image img = _context.Images.ToList().Last();//First, the code grabs a latest Image added to the database using SingleOrDefault() method. We want the LATEST because the one we just added is by default the latest.

            string imageBase64Data = Convert.ToBase64String(img.ImageData); //This image is is the form of a byte array and can't be displayed on the view directly. So, the code converts the byte array into Base64 encoded string.
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            ViewBag.ImageTitle = img.ImageTitle;
            ViewBag.ImageDataUrl = imageDataURL; //The image data URL is stored in ViewBag's ImageDataUrl property

            return View("Index");
        }

		//public IActionResult GetSpecificImage(int id)
		//{
  //          var imageList = new List<Image>();

  //          var image = _context.Images.Where(i => i.Id == id).SingleOrDefault();

  //          imageList.Add(image);

  //          return View("Index", imageList);
		//}
	}
}
