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
    public class AboutController : Controller
    {
        private readonly IConfiguration configuration;


        public AboutController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Rector()
        {
            return View();
        }

        public IActionResult Director()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult License()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Structure()
        {
            return View();
        }



    /* Structure */
    /* ---------------------------------------- */
    public IActionResult Anesthesiology_And_Intensive_Care()
    {
        return View();
    }
    public IActionResult Clinic()
    {
        return View();
    }
    public IActionResult Department_of_Laboratory_Research()
    {
        return View();
    }
    public IActionResult Operation_Unit()
    {
        return View();
    }
    public IActionResult Radiation_Diagnostics()
    {
        return View();
    }
    public IActionResult Surgery()
    {
        return View();
    }
    public IActionResult Traumatology_and_Orthopedics()
    {
        return View();
    }
    public IActionResult Urology()
    {
        return View();
    }
        /* ---------------------------------------- */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    }
    }
