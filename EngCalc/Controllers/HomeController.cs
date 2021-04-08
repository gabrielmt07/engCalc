using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EngCalc.Service;
using EngCalc.Models;

namespace EngCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Somar(double width, double height)
        {
            Geometric myGeometric = new Geometric();
            CaractGeom Resultado = new CaractGeom();
            Resultado.width = width;
            Resultado.height = height;
            Resultado.yI = Resultado.height / 2;
            Resultado.yS = Resultado.height / 2;
            Resultado.area = myGeometric.Area(width, height);
            Resultado.inercia = myGeometric.Inercia(width, height);
            Resultado.wI = myGeometric.RigFlex(Resultado.inercia, Resultado.yI);
            Resultado.wS = myGeometric.RigFlex(Resultado.inercia, Resultado.yS);

            return View("index", Resultado);
        }
    }
}
