using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tavisca.LogsVisualizer.ElasticSearch;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaDataController : ControllerBase
    {

        [HttpGet]
        public IActionResult getMetaData([FromQuery]string correlationId)
        {
            if (correlationId != null)
            {
                ElasticSearchLogsMetaDataService request = new ElasticSearchLogsMetaDataService();
                MetaData response = new MetaData();
                response = request.GetMetaData(correlationId);
                if (response == null)
                    return BadRequest();
                return Ok(response);
            }
            return BadRequest();
        }
    }
}