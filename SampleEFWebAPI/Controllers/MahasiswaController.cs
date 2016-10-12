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
    public class MahasiswaController : ApiController
    {
        // GET: api/Mahasiswa
        public IEnumerable<Mahasiswa> Get()
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            return mhsDAL.GetAll();
        }

        // GET: api/Mahasiswa/5
        public Mahasiswa Get(string id)
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            return mhsDAL.GetById(id);
        }

        // POST: api/Mahasiswa
        public IHttpActionResult Post(Mahasiswa mhs)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                mhsDAL.Add(mhs);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Mahasiswa/5
        public IHttpActionResult Put(string id,Mahasiswa mhs)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                mhsDAL.Update(id, mhs);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Mahasiswa/5
        public IHttpActionResult Delete(string id)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                mhsDAL.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
