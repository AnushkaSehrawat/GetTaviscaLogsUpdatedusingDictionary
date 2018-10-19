using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.ElasticSearch
{
    public interface IElasticSearchLogService
    {
        IEnumerable<Log> GetLogs(string correlationId, string fromLogTime, string toLogTime, string appName);
        List<Log> GetLogs(string correlationId, string FromLogTime, string ToLogTime);
    }
}
