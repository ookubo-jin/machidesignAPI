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
using machidesignAPI.Models;

namespace machidesignAPI.Controllers
{
    public class JichitaisController : ApiController
    {
        private machidesignEntities db = new machidesignEntities();

        // GET: api/Jichitais
        public IQueryable<Jichitais> GetJichitais()
        {
            return db.Jichitais;
        }

        // GET: api/Jichitais/5
        [ResponseType(typeof(Jichitais))]
        public IHttpActionResult GetJichitais(string id)
        {
            Jichitais jichitais = db.Jichitais.Find(id);
            if (jichitais == null)
            {
                return NotFound();
            }

            return Ok(jichitais);
        }

        // PUT: api/Jichitais/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJichitais(string id, Jichitais jichitais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jichitais.JichitaiId)
            {
                return BadRequest();
            }

            db.Entry(jichitais).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JichitaisExists(id))
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
        [ResponseType(typeof(Jichitais))]
        public IHttpActionResult PostJichitais(Jichitais jichitais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Jichitais.Add(jichitais);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (JichitaisExists(jichitais.JichitaiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = jichitais.JichitaiId }, jichitais);
        }

        // DELETE: api/Jichitais/5
        [ResponseType(typeof(Jichitais))]
        public IHttpActionResult DeleteJichitais(string id)
        {
            Jichitais jichitais = db.Jichitais.Find(id);
            if (jichitais == null)
            {
                return NotFound();
            }

            db.Jichitais.Remove(jichitais);
            db.SaveChanges();

            return Ok(jichitais);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JichitaisExists(string id)
        {
            return db.Jichitais.Count(e => e.JichitaiId == id) > 0;
        }
    }
}