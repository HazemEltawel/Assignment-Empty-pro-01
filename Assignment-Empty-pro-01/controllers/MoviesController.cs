using Assignment_Empty_pro_01.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Assignment_Empty_pro_01.controllers
{
    public class MoviesController:Controller
    {
        public string Index()
        {
            return "hallo from index";
        }
        #region examble 01
        //[HttpGet]
        //public ContentResult GetMovie(int? id,string name)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content= $"Movie Id = {id}, Name = {name}";
        //    return result;
        //}
        #endregion
        [HttpGet]
        public IActionResult GetMovie(int? id , string name)
        {
            if(id == 0)
            {
                return BadRequest();
            }else if (id < 10)
            {
                return NotFound();
            }
            else
            {
                return Content($"Movie Id = {id}, Name = {name}");
            }
        }

        public IActionResult Test()
        {
            return RedirectToAction(nameof(GetMovie), "Movies", new { Id = 10, name = "Hamada" });
            //return Redirect("https://www.netflix.com/eg-en/");
        }

        [HttpPost]
        public IActionResult TestMobelBibing([FromRoute]int id , string name)
        {
            return RedirectToRoute($"Hallo {name} Your Id is {id}");
        }
        [HttpGet]
        public IActionResult AddMovie(int Id ,Movie movie, string Title)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            else
            {
                return Content($"Movie Id: {movie.Id}, Title:{movie.Title}");
            }

        }

        public IActionResult TestCollectoin(int[] arr)
        {
            return Content("Test");
        }


    }
}
