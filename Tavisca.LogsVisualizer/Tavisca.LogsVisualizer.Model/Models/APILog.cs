using Newtonsoft.Json.Linq;

namespace Tavisca.LogsVisualizer.Model.Models
{
    class APILog
    {
        public string TimeStamp { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string LogTime { get; set; }
        public string ProcessId { get; set; }
        public string Machine { get; set; }
        public string AppName { get; set; }
        public string CorrelationId { get; set; }
        public string SId { get; set; }
        public string AppTransactionId { get; set; }
        public string ClientId { get; set; }
        public string ClientProgramGroupId { get; set; }
        public string ProgramId { get; set; }
        public string ClassName { get; set; }
        public string URL { get; set; }
        public string API { get; set; }
        public string Verb { get; set; }
        public string Status { get; set; }
        public string TimeTaken { get; set; }
        public string TenantId { get; set; }
        public string ClientIP { get; set; }
        public JObject RequestHeaders { get; set; }
        public JObject ResponseHeaders { get; set; }
        public string MethodName { get; set; }
        public string HTTPStatusCode { get; set; }
        public string ProcessName { get; set; }
        public string HTTPMethod { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
