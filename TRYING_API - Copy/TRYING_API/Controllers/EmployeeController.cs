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
using TRYING_API;

namespace TRYING_API.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeShubaEntities db = new EmployeeShubaEntities();

        // GET: api/Employee
        public IQueryable<EmployeeShuba> GetEmployeeShubas()
        {
            return db.EmployeeShubas;
        }

        // GET: api/Employee/5
        [ResponseType(typeof(EmployeeShuba))]
        public IHttpActionResult GetEmployeeShuba(int id)
        {
            EmployeeShuba employeeShuba = db.EmployeeShubas.Find(id);
            if (employeeShuba == null)
            {
                return NotFound();
            }

            return Ok(employeeShuba);
        }

        // PUT: api/Employee/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployeeShuba(int id, EmployeeShuba employeeShuba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeShuba.Empid)
            {
                return BadRequest();
            }

            db.Entry(employeeShuba).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeShubaExists(id))
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

        // POST: api/Employee
        [ResponseType(typeof(EmployeeShuba))]
        public IHttpActionResult PostEmployeeShuba(EmployeeShuba employeeShuba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EmployeeShubas.Add(employeeShuba);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeShuba.Empid }, employeeShuba);
        }

        // DELETE: api/Employee/5
        [ResponseType(typeof(EmployeeShuba))]
        public IHttpActionResult DeleteEmployeeShuba(int id)
        {
            EmployeeShuba employeeShuba = db.EmployeeShubas.Find(id);
            if (employeeShuba == null)
            {
                return NotFound();
            }

            db.EmployeeShubas.Remove(employeeShuba);
            db.SaveChanges();

            return Ok(employeeShuba);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeShubaExists(int id)
        {
            return db.EmployeeShubas.Count(e => e.Empid == id) > 0;
        }
    }
}