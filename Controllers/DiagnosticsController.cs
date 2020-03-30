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
    public class DiagnosticsController : Controller
    {
        private readonly IConfiguration configuration;


        public DiagnosticsController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Diagnostics()
        {
            return View();
        }

        public IActionResult Biochemical_studies()
        {
            return View();
        }
        public IActionResult Digital_x_ray()
        {
            return View();
        }
        public IActionResult Endoscopy()
        {
            return View();
        }
        public IActionResult Fluorograph()
        {
            return View();
        }
        public IActionResult General_clinical_research()
        {
            return View();
        }
        public IActionResult Immunological_studies()
        {
            return View();
        }
        public IActionResult PCR_studies()
        {
            return View();
        }
        public IActionResult Ultrasound_scan()
        {
            return View();
        }
        public IActionResult CT_scan()
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
