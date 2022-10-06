﻿using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie> { 
                new Movie { Name = "Bons de bico 2" },
                new Movie { Name = "Lord Of The Rings" }
            };

            return View(movies);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Bons de bico 2" };

            var customers = new List<Customer> {
                new Customer { Name = "Jean" },
                new Customer { Name = "Zaito" }
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        #region Unused Code
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        #endregion Unused Code
    }
}