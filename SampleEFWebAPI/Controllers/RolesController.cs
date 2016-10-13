using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleEFWebAPI.Models;
using Microsoft.AspNet.Identity.EntityFramework;

using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace SampleEFWebAPI.Controllers
{
    public class RolesController : ApiController
    {

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? 
                    Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public async Task<IHttpActionResult> AddUserToRole(string roleName, string userId)
        {
            try
            {
                await UserManager.AddToRoleAsync(userId, roleName);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

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
        public IHttpActionResult Post(RoleViewModel model)
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
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
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
