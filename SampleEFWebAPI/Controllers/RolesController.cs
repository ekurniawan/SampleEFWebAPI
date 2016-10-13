using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleEFWebAPI.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SampleEFWebAPI.Controllers
{
    public class RolesController : ApiController
    {
        // GET: api/Roles
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Roles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Roles
        //menambahkan role baru
        public void Post(RoleViewModel model)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var newRole = new IdentityRole
                {
                    Name = model.Name
                };

                try
                {
                    db.Roles.Add(newRole);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        // PUT: api/Roles/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Roles/5
        public void Delete(int id)
        {
        }
    }
}
