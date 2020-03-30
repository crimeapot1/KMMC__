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
    public class TreatmentController : Controller
    {
        private readonly IConfiguration configuration;


        public TreatmentController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Treatment()
        {
            return View();
        }

        public IActionResult Allergic_and_immunological_diseases()
        {
            return View();
        }

        public IActionResult Bariatrics()
        {
            return View();
        }

        public IActionResult Dental_and_maxillofacial_diseases()
        {
            return View();
        }

        public IActionResult Diseases_of_the_cardiovascular_system()
        {
            return View();
        }

        public IActionResult Diseases_of_the_gastrointestinal_tract()
        {
            return View();
        }

        public IActionResult Diseases_of_the_musculoskeletal_system()
        {
            return View();
        }

        public IActionResult ENT_diseases()
        {
            return View();
        }

        public IActionResult Pelvic_diseases()
        {
            return View();
        }

        public IActionResult Skin_and_sexually_transmitted_diseases()
        {
            return View();
        }

        public IActionResult Thyroid_disease()
        {
            return View();
        }

        public IActionResult Urinary_system_diseases()
        {
            return View();
        }

        public IActionResult Visual_diseases()
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
