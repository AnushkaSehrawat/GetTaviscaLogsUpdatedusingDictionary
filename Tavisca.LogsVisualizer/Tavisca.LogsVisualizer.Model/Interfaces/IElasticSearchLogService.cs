using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.Model.Interfaces
{
    public interface IElasticSearchLogService
    {
        IEnumerable<LogESInput> GetLogs(string correlationId, string FromLogTime, string ToLogTime, string AppName);
        IEnumerable<LogESInput> GetLogs(string correlationId, string FromLogTime, string ToLogTime);
    }
}
