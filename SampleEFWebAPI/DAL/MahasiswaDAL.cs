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
    }
}