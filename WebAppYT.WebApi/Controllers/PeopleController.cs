using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppYT.WebApi.Models;

namespace WebAppYT.WebApi.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Matko", LastName = "Potalec", Id = 1 });
            people.Add(new Person { FirstName = "Magdalena", LastName = "Cavic", Id = 2 });
            people.Add(new Person { FirstName = "Ciri", LastName = "Luna", Id = 3 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        [Route("api/people/GetFirstNames")]
        [HttpGet]
        public List<string> getFirstNames()
        {
            List<string> output = new List<string>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }


        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {

        }
    }
}
