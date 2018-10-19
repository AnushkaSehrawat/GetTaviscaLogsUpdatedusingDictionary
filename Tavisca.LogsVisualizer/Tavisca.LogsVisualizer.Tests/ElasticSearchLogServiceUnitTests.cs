using System;
using Tavisca.LogsVisualizer.ElasticSearch;
using Tavisca.LogsVisualizer.Model.Interfaces;
using Xunit;

namespace Tavisca.LogsVisualizer.Tests
{
    public class ElasticSearchLogServiceUnitTest
    {
        IElasticSearchLogService elasticSearchLogService;
        [Fact]
        public void UnitTest1()
        {
            elasticSearchLogService = new ElasticSearchLogService();
            elasticSearchLogService.GetLogs("c412b344-7da7-4d7f-8393-0323c91dc40e", "2018-10-16T05:22:53", "2018-10-16T05:24:21");
        }
    }
}