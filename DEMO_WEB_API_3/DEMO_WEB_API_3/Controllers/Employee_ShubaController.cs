using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DEMO_WEB_API_3;

namespace DEMO_WEB_API_3.Controllers
{
    public class Employee_ShubaController : ApiController
    {
        private masterEntities db = new masterEntities();

        // GET: api/Employee_Shuba
        public IQueryable<Employee_Shuba> GetEmployee_Shuba()
        {
            return db.Employee_Shuba;
        }

        // GET: api/Employee_Shuba/5
        [ResponseType(typeof(Employee_Shuba))]
        public IHttpActionResult GetEmployee_Shuba(int id)
        {
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            if (employee_Shuba == null)
            {
                return NotFound();
            }

            return Ok(employee_Shuba);
        }

        // PUT: api/Employee_Shuba/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee_Shuba(int id, Employee_Shuba employee_Shuba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee_Shuba.Id)
            {
                return BadRequest();
            }

            db.Entry(employee_Shuba).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_ShubaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employee_Shuba
        [ResponseType(typeof(Employee_Shuba))]
        public IHttpActionResult PostEmployee_Shuba(Employee_Shuba employee_Shuba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employee_Shuba.Add(employee_Shuba);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee_Shuba.Id }, employee_Shuba);
        }

        // DELETE: api/Employee_Shuba/5
        [ResponseType(typeof(Employee_Shuba))]
        public IHttpActionResult DeleteEmployee_Shuba(int id)
        {
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            if (employee_Shuba == null)
            {
                return NotFound();
            }

            db.Employee_Shuba.Remove(employee_Shuba);
            db.SaveChanges();

            return Ok(employee_Shuba);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Employee_ShubaExists(int id)
        {
            return db.Employee_Shuba.Count(e => e.Id == id) > 0;
        }
    }
}