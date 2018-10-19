using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.ElasticSearch.Models
{
    public class ElasticSearchMetaData
    {
        [Object(Name = "json_rs_headers")]
        public InnerMetaData RequestHeaders { get; set; }
        public List<long> AppNames { get; set; }
    }
}
