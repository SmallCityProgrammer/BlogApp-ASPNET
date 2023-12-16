using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blog_App.Data;
using Blog_App.Models.Domain;
using Blog_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Blog_App.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggieDbContext bloggieDbContext;

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest AddTagRequest)
        {
            var tag = new Tag
            {
                Name = AddTagRequest.Name,
                DisplayName = AddTagRequest.DisplayName
            };

            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();

            return View("Add");
        }
    }
}