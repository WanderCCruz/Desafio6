using DesafioAlura.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("[Contrroller]")]
    public class Tutor : ControllerBase
    {
        [HttpPost]
        public void AdcionaTutor([FromBody] Tutor tutor)
        {
        }
    }
}
