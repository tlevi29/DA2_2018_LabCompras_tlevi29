using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2018_LabCompras_tlevi29.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DA2_2018_LabCompras_tlevi29.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Tempo()
        {
            //criar e configurar o cliente HTTP
            HttpClient client = MyHTTPClient.Client;
            string path = "v1/current.json?key=2aef87f6723e417fad095040172704&q=Almada"; //Key = 2aef87f6723e417fad095040172704

            //fazer o pedido HTTP, receber a resposta, guardar JSON
            HttpResponseMessage response = client.GetAsync(path).Result;
            string json = await response.Content.ReadAsStringAsync();
            
            //converter JSON para um objeto do tipo WeatherApiResponse
            WeatherApiResponse wc = JsonConvert.DeserializeObject<WeatherApiResponse>(json);

            return View(wc);
        }

        [HttpPost]
        public async Task<IActionResult> Tempo(string cidade)
        {
            //criar e configurar o cliente HTTP
            HttpClient client = MyHTTPClient.Client;
            string path = "v1/current.json?key=2aef87f6723e417fad095040172704&q="+cidade;

            //fazer o pedido HTTP, receber a resposta, guardar JSON
            HttpResponseMessage response = client.GetAsync(path).Result;
            string json = await response.Content.ReadAsStringAsync();

            //converter JSON para um objeto do tipo WeatherApiResponse
            WeatherApiResponse wc = JsonConvert.DeserializeObject<WeatherApiResponse>(json);

            return View(wc);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
