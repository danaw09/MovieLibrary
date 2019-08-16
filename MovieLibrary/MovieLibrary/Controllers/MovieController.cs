using MovieLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace MovieLibrary.Controllers
{
    public class MovieController : ApiController
    {
        EnableCorsAttribute cors = new EnableCorsAttribute( "*",  "*", "*");
        ApplicationDbContext db;

       
        public MovieController()
        {
            db = new ApplicationDbContext();
        }
       
      
        // GET: api/Movie
        public IEnumerable<Movie> Get()
        {
            var movie = db.Movies.ToList();
            return movie;

        }
       

        // GET: api/Movie/5
        public Movie Get(int id)
        {
           var movie = db.Movies.Where(m => m.MovieId == id).SingleOrDefault();

           return movie;
        }
        
        // POST: api/Movie
        public HttpResponseMessage Post([FromBody]Movie movie)
        {
            try
            {
                //using (ApplicationDbContext db = new ApplicationDbContext())
                //{
                    db.Movies.Add(movie);
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, movie);
                    message.Headers.Location = new Uri(Request.RequestUri + movie.MovieId.ToString());


                    return message;
                //}



            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        // PUT: api/Movie/5
        [HttpPut]
        public void Put(int id, [FromBody]Movie movie)
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            Movie movie1 = db.Movies.FirstOrDefault(m => m.MovieId == id);
            movie1.DirectorName = movie.DirectorName;
            movie1.Genre = movie.Genre;
            movie1.Title = movie.Title;

            db.SaveChanges();
        }

        // DELETE: api/Movie/5
        [HttpDelete]
        public void Delete(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Movies.Remove(db.Movies.FirstOrDefault(m => m.MovieId == id));
            db.SaveChanges();
        }
    }
}
