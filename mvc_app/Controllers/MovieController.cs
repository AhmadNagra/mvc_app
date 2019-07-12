using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models.Movie;
using Newtonsoft.Json.Linq;

namespace mvc_app.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> movies;

        public MovieController()
        {
            movies = new List<Movie>() {
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dark Knight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="Tnight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="TheKnight",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Daght",Director=" Christopher Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Dt",Director=" Chrilan",Genre=" Action",ReleaseDate="18 Jy 2008",
                    Description ="When the menace sterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
                new Movie {Title="The Daright",Director=" Christopr Nolan",Genre=" Action",ReleaseDate="18 July 2008",
                    Description ="When thes from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Poster ="poster"},
            };
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<Movie> movies = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/");
                //HTTP GET
                var responseTask = client.GetAsync("movies");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Movie>>();
                    readTask.Wait();

                    movies = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    movies = Enumerable.Empty<Movie>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(movies);
        }

        //public ActionResult create()
        //{
        //    return View();
        //}
        [HttpPost]
        public async Task<ActionResult> insert(Movie movie)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/movies");

                //HTTP POST
                var postTask =await client.PostAsJsonAsync<Movie>("https://localhost:44347/api/movies", movie);
                //postTask.Wait();

                //var result = postTask.Result;
                if (postTask.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(movie);
        }

        public ActionResult moveToCreate()
        {
            return View("insert");
        }
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44347/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("movies/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}