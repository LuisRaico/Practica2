using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica2.Models;

namespace Practica2.Controllers
{
    public class RegistroController: Controller
    {
        private readonly ILogger<RegistroController> _logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            _logger = logger;
        }
            



             public IActionResult Formulario()
        {
            return View();
        }
        
          [HttpPost]
            public IActionResult Formulario(Formulario formulario)
        {
          return RedirectToAction("Confirmacion");
        }

        public IActionResult Confirmacion()
        {
            return View();
        }

        
    }
}