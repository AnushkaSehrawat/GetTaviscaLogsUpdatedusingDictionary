using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Nest;

namespace Tavisca.LogsVisualizer.Model.Models
{

    public class LogESInput
    {
        [Text(Name="@timestamp")]
        public string TimeStamp { get; set; }

        [Text(Name="type")]
        public string Type { get; set; }

        [Text(Name="id")]
        public string Id { get; set; }

        [Text(Name="log_time")]
        public string LogTime { get; set; }

        [Text(Name="pid")]
        public string ProcessId { get; set; }

        [Text(Name="machine")]
        public string Machine { get; set; }

        [Text(Name="app_name")]
        public string AppName { get; set; }

        [Text(Name ="cid")]
        public string CorrelationId { get; set; }

        [Text(Name="sid")]
        public string SId { get; set; }

        [Text(Name="app_txid")]
        public string AppTransactionId { get; set; }

        [Text(Name = "clientId")]
        public string ClientId { get; set; }

        [Text(Name = "clientProgramGroupId")]
        public string ClientProgramGroupId { get; set; }

        [Text(Name = "programId")]
        public string ProgramId { get; set; }

        [Text(Name = "classname")]
        public string ClassName { get; set; }

        [Text(Name = "url")]
        public string URL { get; set; }

        [Text(Name = "api")]
        public string API { get; set; }

        [Text(Name = "verb")]
        public string Verb { get; set; }

        [Text(Name = "status")]
        public string Status { get; set; }

        [Text(Name = "time_taken_ms")]
        public string TimeTaken { get; set; }

        [Text(Name = "tid")]
        public string TenantId { get; set; }

        [Text(Name = "client_ip")]
        public string ClientIP { get; set; }

        [Object(Name = "json_rq_headers")]
        public JObject RequestHeaders { get; set; }

        [Object(Name = "json_rs_headers")]
        public JObject ResponseHeaders { get; set; }

        [Text(Name = "method_name")]
        public string MethodName { get; set; }

        [Text(Name = "http_status_code")]
        public string HTTPStatusCode { get; set; }

        [Text(Name = "process_name")]
        public string ProcessName { get; set; }

        [Text(Name = "http_method")]
        public string HTTPMethod { get; set; }

        [Text(Name = "request")]
        public string Request { get; set; }

        [Text(Name = "response")]
        public string Response { get; set; }

        [Text(Name = "ex_type")]
        public string ExceptionType { get; set; }

        [Text(Name = "stack_trace")]
        public string StackTrace { get; set; }

        [Text(Name = "target_site")]
        public string TargetSite { get; set; }

        [Text(Name = "source")]
        public string Source { get; set; }

        [Text(Name = "inner_exception")]
        public string InnerException { get; set; }

        [Text(Name = "category")]
        public string Category { get; set; }

        [Text(Name = "data_length")]
        public string DataLength { get; set; }
    }
}
