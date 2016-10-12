﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleEFWebAPI.Models;
using SampleEFWebAPI.DAL;

namespace SampleEFWebAPI.Controllers
{
    public class MahasiswaController : ApiController
    {
        // GET: api/Mahasiswa
        public IEnumerable<Mahasiswa> Get()
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            return mhsDAL.GetAll();
        }

        // GET: api/Mahasiswa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mahasiswa
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mahasiswa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mahasiswa/5
        public void Delete(int id)
        {
        }
    }
}
