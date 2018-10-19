using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Tavisca.LogsVisualizer.ElasticSearch;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataWithIdServiceController : ControllerBase
    {
        [HttpGet]
        public List<Log> getMetaData([FromQuery]string Id)
        {
            
                 DataWithIdService request = new DataWithIdService();
                 //Object response;
                  return request.GetLog(Id);
                 //return response;
        }
     }
}