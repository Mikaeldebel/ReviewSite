using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewSite.Models;

namespace ReviewSite.Controllers
{
    public class ReviewSiteController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> SaveFormData(Models.ReviewModel review)
        {
            if (ModelState.IsValid)
            {
                ReviewModel data = review;
                string[] dataString = new string[] { "Reviewer Name " + review.ReviewerName, "\n Product Name" + review.ProductName, "\n Score : " + review.ReviewScore.ToString() };
                System.IO.File.WriteAllLines(@"C:\Diplom i Webudvikling\Webudvikling Backend\Uge 3\ReviewSite\ReviewSite\wwwroot\Reviews", dataString);
                await SaveFormData(data);

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

    }
}