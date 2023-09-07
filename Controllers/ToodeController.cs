using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web2.Models;

namespace web2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToodeController : ControllerBase
    {
        private static Toode _toode = new Toode(1, "Koola", 1.5, true);

        // GET: toode
        [HttpGet]
        public Toode GetToode()
        {
            return _toode;
        }


        // GET: toode/suurenda-hinda
        [HttpGet("suurenda-hinda")]
        public Toode SuurendaHinda()
        {
            _toode.Price = _toode.Price + 1;
            return _toode;
        }

        // GET: toode/activtoode
        [HttpGet("activtoode")]
        public Toode ActivToode()
        {
           if (_toode.IsActive ==false)
            {
                _toode.IsActive = true;
            }
            else
            {
                _toode.IsActive = false;
            }
           return _toode;
        }

        // GET: toode/muuda-nimi
        [HttpGet("muuda-nimi")]
        public Toode MuudaNimi(string name)
        {
           _toode.Name = name;
            return _toode;
        }

        // GET: toode/muuda-hind
        [HttpGet("muuda-hind")]
        public Toode MuudaHind(double korrutada)
        {
            _toode.Price *= korrutada;
            return _toode;
        }
    }
}
