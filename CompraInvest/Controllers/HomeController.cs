using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompraInvest.Models;
using System.Net.Http;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System.Text;
using System.Threading;

namespace CompraInvest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPlanilha()
        {
            try
            {
                string urlPOST = "https://vks5u1bbk6.execute-api.us-east-1.amazonaws.com/dev/service";

                HttpClient client = new HttpClient();
                PostPlanilhaDTO dto = new PostPlanilhaDTO();
                dto.url = "http://sistemas.sefaz.am.gov.br/nfceweb/consultarNFCe.jsp?p=13200522991939000602650180001988211006220250%7C2%7C1%7C1%7CD8E78BD7CAE99D2E0F908608C2A683FE349509C0";

                await client.PostAsync(urlPOST, new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json"));
                Thread.Sleep(2);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
