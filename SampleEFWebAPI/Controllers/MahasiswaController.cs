using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleEFWebAPI.Models;
using SampleEFWebAPI.DAL;
using System.Threading.Tasks;

namespace SampleEFWebAPI.Controllers
{
    public class MahasiswaController : ApiController
    {
        // GET: api/Mahasiswa
        [Authorize(Users ="erick@gmail.com")]
        public async Task<IEnumerable<Mahasiswa>> Get()
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            var results = await mhsDAL.GetAll();
            return results;
        }

        // GET: api/Mahasiswa/5
        [Authorize]
        public async Task<Mahasiswa> Get(string id)
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            return await mhsDAL.GetById(id);
        }


        [Route("api/Mahasiswa/GetByNama/{nama}")]
        public async Task<IEnumerable<Mahasiswa>> GetByNama(string nama)
        {
            MahasiswaDAL mhsDAL = new MahasiswaDAL();
            return await mhsDAL.GetMahasiswaByNama(nama);
        }

        // POST: api/Mahasiswa
        public async Task<IHttpActionResult> Post(Mahasiswa mhs)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                await mhsDAL.Add(mhs);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Mahasiswa/5
        public async Task<IHttpActionResult> Put(string id,Mahasiswa mhs)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                await mhsDAL.Update(id, mhs);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Mahasiswa/5
        public async Task<IHttpActionResult> Delete(string id)
        {
            try
            {
                MahasiswaDAL mhsDAL = new MahasiswaDAL();
                await mhsDAL.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
