using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.ElasticSearch.Models
{
    public class InnerMetaData
    {

        [Text(Name = "oski-clientId")]
        public string ClientId { get; set; }
        [Text(Name = "oski-clientProgramGroupId")]
        public string ClientProgramId { get; set; }
        [Text(Name = "oski-programId")]
        public string ProgramId { get; set; }
        [Text(Name = "oski-tenantId")]
        public string TenantId { get; set; }
    }
}
