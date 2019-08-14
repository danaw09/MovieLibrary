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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

        }
          //  return db.Movies;

        // GET: api/Movie/5
        public string Get(int id)
        {
            //var movie = db.Movies
            //     .Include(m => m.    );
            //   .Single(m => m.    )
            //return Movie;

            return $"value (id)";
        }

        // POST: api/Movie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Movie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movie/5
        public void Delete(int id)
        {

        }
    }
}
