using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.Model.Models
{
    class TraceLog
    {
        public string TimeStamp { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string LogTime { get; set; }
        public string ProcessId { get; set; }
        public string Machine { get; set; }
        public string AppName { get; set; }
        public string TenantId { get; set; }
        public string CorrelationId { get; set; }
        public string SId { get; set; }
        public string AppTransactionId { get; set; }
        public string ClientId { get; set; }
        public string ProgramId { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string Category { get; set; }
        public string TimeTaken { get; set; }
        public string DataLength { get; set; }
    }
}
