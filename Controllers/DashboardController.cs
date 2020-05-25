using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashboardService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DashboardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        //JObject dataCache = null;
        public DashboardController()
        {
            //Prepare data
            //string allText = System.IO.File.ReadAllText(@"data\data.json");

            //dataCache = (JObject)JsonConvert.DeserializeObject(allText);
            
        }

        [HttpGet("{chartType}")]
        public IActionResult charts(string chartType)
        {
            IChartData data = null;
            #region Reading directly from json and sending
            //JArray data = new JArray();
            //if (dataCache != null)
            //{
            //    var obj = dataCache.SelectToken(chartType);
            //    if (obj != null)
            //        data = (JArray)obj;
            //    else
            //        return NotFound();
            //}
            //return Ok(data.ToString());
            #endregion

            #region using object model
            if (chartType == "big")
                data = new BigChartData();
            else if (chartType == "pie")
                data = new PieChartData();
            else if (chartType == "table")
                data = new TableData();
            else if (chartType == "card")
                data = new CardData();

            return data switch
            {
                null => NotFound(),
                _ => Ok(data.Data)
            };


            #endregion

        }
    }
}