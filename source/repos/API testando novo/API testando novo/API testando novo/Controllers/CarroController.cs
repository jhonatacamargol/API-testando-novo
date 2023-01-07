using Carro.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace API_testando_novo.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(Veiculo veiculo)
        {
            return View();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
