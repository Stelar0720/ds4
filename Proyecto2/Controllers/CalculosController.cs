using Proyecto2.Data;
using Proyecto2.Models;
using System.Linq;
using System.Web.Http;

namespace Proyecto2.Controllers
{
    [RoutePrefix("api/calculos")]
    public class CalculosController : ApiController
    {
        private readonly DefaultContext _context;

        public CalculosController()
        {
            _context = new DefaultContext();
        }

        // GET: api/calculos
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCalculos()
        {
            var calculos = _context.Calculos.ToList();
            return Ok(calculos);
        }

        // POST: api/calculos
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateCalculo(Calculo calculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Calculos.Add(calculo);
            _context.SaveChanges();

            return Created($"api/calculos/{calculo.Id}", calculo);
        }
    }
}
