using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.LogsVisualizer.Model.Interfaces;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.ElasticSearch
{
    public class ElasticSearchLogService : IElasticSearchLogService
    {
        ElasticClient elasticClient;
        public ElasticSearchLogService()
        {
            this.elasticClient = ElasticSearchClient.GetClient("http://logs.qa.oski.io/");
        }
        public IEnumerable<LogESInput> GetLogs(string correlationId, string fromLogTime, string toLogTime, string appName)
        {
            var response = elasticClient.Search<LogESInput>(s => s.TypedKeys(null)
                                                    .AllIndices()
                                                    .AllTypes()
                                                    .Query(q => q.Bool(b => b.Must(m => m.MatchPhrase(ma => ma.Field("cid")
                                                                                                            .Query(correlationId)),
                                                                                 m => m.MatchPhrase(ma => ma.Field("app_name")
                                                                                                          .Query(appName)),
                                                                                 m => m.DateRange(r => r.Field("log_time")
                                                                                                      .GreaterThanOrEquals(fromLogTime)
                                                                                                      .LessThanOrEquals(toLogTime))))));

            return response.Documents;
        }

        public IEnumerable<LogESInput> GetLogs(string correlationId, string fromLogTime, string toLogTime)
        {
            var response = elasticClient.Search<LogESInput>(s => s.TypedKeys(null)
                                                   .AllIndices()
                                                   .AllTypes()
                                                   .Query(q => q.Bool(b => b.Must(m => m.MatchPhrase(ma => ma.Field("cid")
                                                                                                           .Query(correlationId)),
                                                                                  m => m.DateRange(r => r.Field("log_time")
                                                                                                     .GreaterThanOrEquals(fromLogTime)
                                                                                                     .LessThanOrEquals(toLogTime))))));

            return response.Documents;
        }
    }
}
