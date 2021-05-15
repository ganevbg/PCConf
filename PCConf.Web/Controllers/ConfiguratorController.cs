namespace PCConf.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ConfiguratorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetMotherBoards(Guid id)
        {
            var result = new List<MotherBoard>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(new Uri($"http://localhost:56090/api/Parts/GetMotherBoards/{id}")))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<MotherBoard>>(apiResponse);
                }
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetRams(Guid id)
        {
            var result = new List<Ram>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(new Uri($"http://localhost:56090/api/Parts/GetRams/{id}")))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Ram>>(apiResponse);
                }
            }

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetCases(Guid mbId, Guid gpuId)
        {
            var result = new List<PcCase>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(new Uri($"http://localhost:56090/api/Parts/GetCases/?mbId={mbId}&gpuId={gpuId}")))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<PcCase>>(apiResponse);
                }
            }

            return Ok(result);
        }
    }
}
