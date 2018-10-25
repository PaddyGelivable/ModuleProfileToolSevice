using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ModuleProfileToolSevice.Models;

namespace ModuleProfileToolSevice.Controllers
{
    public class ModuleInfoesController : ApiController
    {
        private ModuleProfileToolSeviceContext db = new ModuleProfileToolSeviceContext();

        // GET: api/ModuleInfoes
        public IQueryable<ModuleInfo> GetModuleInfoes()
        {
            return db.ModuleInfoes;
        }

        // GET: api/ModuleInfoes/5
        [ResponseType(typeof(ModuleInfo))]
        public async Task<IHttpActionResult> GetModuleInfo(int id)
        {
            ModuleInfo moduleInfo = await db.ModuleInfoes.FindAsync(id);
            if (moduleInfo == null)
            {
                return NotFound();
            }

            return Ok(moduleInfo);
        }

        // PUT: api/ModuleInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModuleInfo(int id, ModuleInfo moduleInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != moduleInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(moduleInfo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleInfoExists(id))
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

        // POST: api/ModuleInfoes
        [ResponseType(typeof(ModuleInfo))]
        public async Task<IHttpActionResult> PostModuleInfo(ModuleInfo moduleInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ModuleInfoes.Add(moduleInfo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = moduleInfo.Id }, moduleInfo);
        }

        // DELETE: api/ModuleInfoes/5
        [ResponseType(typeof(ModuleInfo))]
        public async Task<IHttpActionResult> DeleteModuleInfo(int id)
        {
            ModuleInfo moduleInfo = await db.ModuleInfoes.FindAsync(id);
            if (moduleInfo == null)
            {
                return NotFound();
            }

            db.ModuleInfoes.Remove(moduleInfo);
            await db.SaveChangesAsync();

            return Ok(moduleInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModuleInfoExists(int id)
        {
            return db.ModuleInfoes.Count(e => e.Id == id) > 0;
        }
    }
}