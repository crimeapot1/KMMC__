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
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;


        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }

        

        public IActionResult Index()
        {

            /*
            string connectionstring = configuration.GetConnectionString("Myconnection");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand com = new SqlCommand("Select * from Заявки_на_консультацию", connection);


            String data = "<thead>";
            data += "<tr>";
                    

            using (SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection))
            {
                //цикл по всем столбцам полученной в результате запроса таблицы
                for (int i = 0; i < dr.FieldCount; i++)
                {
                */

                    /*метод GetName() класса SqlDataReader позволяет получить имя столбца
                     по номеру, который передается в качестве параметра, данному методу
                     и озночает номер столбца в таблице(начинается с 0)
                     */

            /*
                    data += "<th>";
                    data += dr.GetName(i).ToString().Trim();
                    data += "</th>";
                }

                data += "</tr>";
                data += "</thead>";

                data += "<tbody>";

            */

                /*читаем данные из таблицы
                 чтение происходит только в прямом направлении
                 все прочитаные строки отбрасываюся */

            /*

                while (dr.Read())
                {

            */

                    /*метод GetValue() класса SqlDataReader позволяет получить значение столбца
                                            по номеру, который передается в качестве параметра, данному методу
                                            и озночает номер столбца в таблице(начинается с 0)
                                            */
                                            /*

                    data += "<tr>";
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        data += "<td>" + dr.GetValue(i).ToString().Trim() + "</td>";
                    }
                    data += "</tr>";
                }
                data += "</tbody>";

            }
            
            data.Trim();

            @ViewData["myTable"] = data;

            // From String


            var doc = new HtmlDocument();
            //doc.LoadHtml(data);

           

            connection.Close(); */

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
