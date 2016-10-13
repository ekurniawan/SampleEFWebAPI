using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEFWebAPI.Models;
using System.Data.Entity.Infrastructure;

using System.Threading.Tasks;
using System.Data.Entity;

namespace SampleEFWebAPI.DAL
{
    public class MahasiswaDAL
    {
        private SampleKSIDbEntities db;

        public MahasiswaDAL()
        {
            db = new SampleKSIDbEntities();
        }

        public async Task<IEnumerable<Mahasiswa>> GetAll()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var results = await (from m in db.Mahasiswa.AsNoTracking()
                          orderby m.Nama ascending
                          select m).ToListAsync();

            //var results = db.Mahasiswa.OrderBy(m => m.Nama);

            return results;
        }

        public async Task<Mahasiswa> GetById(string id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var result = await (from m in db.Mahasiswa.AsNoTracking()
                         where m.Nim == id
                         select m).FirstOrDefaultAsync();

            if (result != null)
                return result;
            else
                throw new Exception("Data not found !");
        }

        public async Task<IEnumerable<Mahasiswa>> GetMahasiswaByNama(string nama)
        {
            db.Configuration.LazyLoadingEnabled = false;

            var results = await (from m in db.Mahasiswa
                                 where m.Nama.ToLower().Contains(nama.ToLower())
                                 select m).ToListAsync();
            return results;
        }

        public async Task Add(Mahasiswa mhs)
        {
            try
            {
                db.Mahasiswa.Add(mhs);
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public async Task Update(string id, Mahasiswa mhs)
        {
            var result = (from m in db.Mahasiswa
                          where m.Nim == id
                          select m).FirstOrDefault();

            if (result != null)
            {
                result.Nama = mhs.Nama;
                result.Email = mhs.Email;
                result.IPK = mhs.IPK;

                await db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Data not found !");
            }
        }

        public async Task Delete(string id)
        {
            var result = (from m in db.Mahasiswa
                          where m.Nim == id
                          select m).FirstOrDefault();

            if (result != null)
            {
                db.Mahasiswa.Remove(result);
                await db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Data not found !");
            }
        }


    }
}