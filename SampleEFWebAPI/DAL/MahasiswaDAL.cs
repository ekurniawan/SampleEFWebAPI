using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEFWebAPI.Models;

namespace SampleEFWebAPI.DAL
{
    public class MahasiswaDAL
    {
        private SampleKSIDbEntities db;

        public MahasiswaDAL()
        {
            db = new SampleKSIDbEntities();
        }

        public IQueryable<Mahasiswa> GetAll()
        {
            var results = from m in db.Mahasiswa
                          orderby m.Nama ascending
                          select m;

            //var results = db.Mahasiswa.OrderBy(m => m.Nama);

            return results;
        }
    }
}