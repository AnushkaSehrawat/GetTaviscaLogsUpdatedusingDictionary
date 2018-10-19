using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.Model.Interfaces
{
    public interface IElasticSearchLogsMetaDataService
    {
        MetaData GetMetaData(string CorrelationId);
    }
}
