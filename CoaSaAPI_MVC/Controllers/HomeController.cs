﻿using CoaSaAPI_MVC.Models;
using DatabaseAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CoaSaAPI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

            //https://localhost:44353/api/usuarios
        public IActionResult Index()
        {



            return View();
        }
        
        public async Task<IActionResult> Details(int id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"https://localhost:44353/api/usuarios/{id}");
            var usuario = JsonConvert.DeserializeObject<Usuarios>(json);

            return View(usuario);
        }

        public async Task<IActionResult> Crear(IFormCollection form)
        {
            var httpClient = new HttpClient();

            

            if (form.Count != 0)
            {
                var usuario = new Usuarios()
                {
                    UserName = form["UserName"],
                    Nombre = form["Nombre"],
                    Email = form["Email"],
                    Telefono = form["Telefono"]
                };

                await httpClient.PostAsJsonAsync("https://localhost:44353/api/usuarios", usuario);
                return Redirect("https://localhost:44382/Home/StatusOk");
            }
            var json = await httpClient.GetStringAsync("https://localhost:44353/api/usuarios");
            var usuariosList = JsonConvert.DeserializeObject<List<Usuarios>>(json);

            return View(usuariosList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult StatusOk()
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
