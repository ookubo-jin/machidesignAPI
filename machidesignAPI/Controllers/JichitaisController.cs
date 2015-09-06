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
    public class JichitaisController : ApiController
    {
        private machidesignDBContext db = new machidesignDBContext();

        // GET: api/Jichitais
        public IQueryable<Jichitai> Getjichitai()
        {
            return db.jichitai;
        }

        // GET: api/Jichitais/5
        [ResponseType(typeof(Jichitai))]
        public IHttpActionResult GetJichitai(string id)
        {
            Jichitai jichitai = db.jichitai.Find(id);
            if (jichitai == null)
            {
                return NotFound();
            }

            return Ok(jichitai);
        }

        // PUT: api/Jichitais/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJichitai(string id, Jichitai jichitai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jichitai.JichitaiId)
            {
                return BadRequest();
            }

            db.Entry(jichitai).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JichitaiExists(id))
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

        // POST: api/Jichitais
        [ResponseType(typeof(Jichitai))]
        public IHttpActionResult PostJichitai(Jichitai jichitai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.jichitai.Add(jichitai);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (JichitaiExists(jichitai.JichitaiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = jichitai.JichitaiId }, jichitai);
        }

        // DELETE: api/Jichitais/5
        [ResponseType(typeof(Jichitai))]
        public IHttpActionResult DeleteJichitai(string id)
        {
            Jichitai jichitai = db.jichitai.Find(id);
            if (jichitai == null)
            {
                return NotFound();
            }

            db.jichitai.Remove(jichitai);
            db.SaveChanges();

            return Ok(jichitai);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JichitaiExists(string id)
        {
            return db.jichitai.Count(e => e.JichitaiId == id) > 0;
        }
    }
}