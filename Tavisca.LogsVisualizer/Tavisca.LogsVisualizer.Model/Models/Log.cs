using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.Model.Models
{
    public class Log
    {
        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "type")]
        public string type { get; set; }

        [Text(Name = "app_name")]
        public string AppName { get; set; }

        public Dictionary<string,object> KeyValue  { get; set; }


    }
}
