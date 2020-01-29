using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeraTarea.Models;


namespace PrimeraTarea.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Vista( int dia , int mes)
        {
            validacion vali = new validacion();
            vali.dia = dia;
            vali.mes = mes;

            if (dia < 0  || mes < 0)
            {
                ViewBag.msj = "No puede insertar un valor negativo";


            }
            else if (dia >= 20 && mes == 1 || dia <= 18 && mes == 2)
            {
                ViewData["Signo"] = "Acuario";
                ViewData["Astro"] = "Urano / Saturno";
                return View();
            }
            else if (dia >= 19 && mes == 2 || dia <= 20 && mes == 3)
            {
                ViewData["Signo"] = "Piscis";
                ViewData["Astro"] = "Neptuno / Júpiter";
                return View();
            }
            else if (dia >= 21 && mes == 3 || dia <= 20 && mes == 4)
            {
                ViewData["Signo"] = "Aries";
                ViewData["Astro"] = "Marte / Plutón";
                return View();
            }
            else if (dia >= 21 && mes == 4 || dia <= 20 && mes == 5)
            {
                ViewData["Signo"] = "Tauro";
                ViewData["Astro"] = "Venus / Tierra";
                return View();
            }
            else if (dia >= 21 && mes == 5 || dia <= 24 && mes == 6)
            {
                ViewData["Signo"] = "Géminis";
                ViewData["Astro"] = "Mercurio";
                return View();
            }
            else if (dia >= 25 && mes == 6 || dia <= 22 && mes == 7)
            {
                ViewData["Signo"] = "Cáncer";
                ViewData["Astro"] = "Luna";
                return View();
            }
            else if (dia >= 23 && mes == 7 || dia <= 23 && mes == 8)
            {
                ViewData["Signo"] = "Leo";
                ViewData["Astro"] = "Sol";
                return View();
            }
            else if (dia >= 24 && mes == 8 || dia <= 23 && mes == 9)
            {
                ViewData["Signo"] = "Virgo";
                ViewData["Astro"] = "Mercurio";
                return View();
            }
            else if (dia >= 24 && mes == 9 || dia <= 22 && mes == 10)
            {
                ViewData["Signo"] = "Libra";
                ViewData["Astro"] = "Venus";
                return View();
            }
            else if (dia >= 23 && mes == 10 || dia <= 22 && mes == 11)
            {
                ViewData["Signo"] = "Escorpio";
                ViewData["Astro"] = "Plutón / Marte";
                return View();
            }
            else if (dia >= 22 && mes == 11 || dia <= 21 && mes == 12)
            {
                ViewData["Signo"] = "Sagitario";
                ViewData["Astro"] = "Júpiter";
                return View();
            }
            else if (dia >= 22 && mes == 12 || dia <= 19 && mes == 1)
            {
                ViewData["Signo"] = "Capricornio";
                ViewData["Astro"] = "Saturno";
                return View();
            }
                ViewBag.HaveData = vali.dia;
                ViewBag.HaveData = vali.mes;
                return View();
           
        }

      
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
