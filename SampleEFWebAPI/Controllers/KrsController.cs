using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleEFWebAPI.Models;
using SampleEFWebAPI.DAL;

namespace SampleEFWebAPI.Controllers
{
    public class KrsController : ApiController
    {
        // GET: api/Krs
        public IEnumerable<KRS> Get()
        {
            KrsDAL krsDal = new KrsDAL();
            return krsDal.GetAll().ToList();
        }

        // GET: api/Krs/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Krs
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Krs/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Krs/5
        public void Delete(int id)
        {
        }
    }
}
