using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEFWebAPI.Models;

namespace SampleEFWebAPI.DAL
{
    public class KrsDAL
    {
        private SampleKSIDbEntities db;

        public KrsDAL()
        {
            db = new SampleKSIDbEntities();
        }

        public IQueryable<KRS> GetAll()
        {
            
            var results = from k in db.KRS.Include("Matakuliah").Include("Mahasiswa")
                          select k;

            return results;
        }

    }
}