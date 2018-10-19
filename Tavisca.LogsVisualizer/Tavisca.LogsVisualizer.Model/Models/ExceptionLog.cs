using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.Model.Models
{
    class ExceptionLog
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
        public string ExceptionType { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public string Source { get; set; }
        public string InnerException { get; set; }
    }
}
