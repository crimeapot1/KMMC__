using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using test.Models;

using Microsoft.Extensions.Configuration;
using System.Text.Json.Serialization;
using AutoMapper;
using Microsoft.Data.SqlClient;
using System.Data;

using HtmlAgilityPack;

namespace test.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IConfiguration configuration;


        public DoctorsController(IConfiguration config)
        {
            this.configuration = config;
        }
        
        public IActionResult Doctors()
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
