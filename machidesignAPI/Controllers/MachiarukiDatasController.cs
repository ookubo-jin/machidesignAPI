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
using matidesign.Models;

namespace machidesignAPI.Controllers
{
    public class MachiarukiDatasController : ApiController
    {
        private machidesignDBContext db = new machidesignDBContext();

        // GET: api/MachiarukiDatas
        public IQueryable<MachiarukiData> GetmachiarukiData()
        {
            return db.machiarukiData;
        }

        // GET: api/MachiarukiDatas/5
        [ResponseType(typeof(MachiarukiData))]
        public IHttpActionResult GetMachiarukiData(long id)
        {
            MachiarukiData machiarukiData = db.machiarukiData.Find(id);
            if (machiarukiData == null)
            {
                return NotFound();
            }

            return Ok(machiarukiData);
        }

        // PUT: api/MachiarukiDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMachiarukiData(long id, MachiarukiData machiarukiData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != machiarukiData.MachiarukiDataId)
            {
                return BadRequest();
            }

            db.Entry(machiarukiData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MachiarukiDataExists(id))
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

        // POST: api/MachiarukiDatas
        [ResponseType(typeof(MachiarukiData))]
        public IHttpActionResult PostMachiarukiData(MachiarukiData machiarukiData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.machiarukiData.Add(machiarukiData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = machiarukiData.MachiarukiDataId }, machiarukiData);
        }

        // DELETE: api/MachiarukiDatas/5
        [ResponseType(typeof(MachiarukiData))]
        public IHttpActionResult DeleteMachiarukiData(long id)
        {
            MachiarukiData machiarukiData = db.machiarukiData.Find(id);
            if (machiarukiData == null)
            {
                return NotFound();
            }

            db.machiarukiData.Remove(machiarukiData);
            db.SaveChanges();

            return Ok(machiarukiData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MachiarukiDataExists(long id)
        {
            return db.machiarukiData.Count(e => e.MachiarukiDataId == id) > 0;
        }
    }
}