using MongoDB.Bson;
using POC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POC_API.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IEnumerable<Person> Get()
        {
            var dataBase = new Repository<Person>("persons");
            return dataBase.List();
        }

        // GET: api/Test/5
        public Person Get(string id)
        {
            var dataBase = new Repository<Person>("persons");
            return dataBase.FindById(new ObjectId(id));
        }
        // POST: api/Test
        public void Post([FromBody]Person value)
        {
            var dataBase = new Repository<Person>("persons");
            dataBase.Add(value);

        }

        // POST: api/Test/id
        public void Post(string id, [FromBody]Person value)
        {
            value._id = new ObjectId(id);
            var dataBase = new Repository<Person>("persons");
            dataBase.Update(value);
        }

        // PUT: api/Test/5
        public void Put(string id, [FromBody]Person value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(string id)
        {
            var dataBase = new Repository<Person>("persons");
            dataBase.Delete(new ObjectId(id));
        }
    }
}
