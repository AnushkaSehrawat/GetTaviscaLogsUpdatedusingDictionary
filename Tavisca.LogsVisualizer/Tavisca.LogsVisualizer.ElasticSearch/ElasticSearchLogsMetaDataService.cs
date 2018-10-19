using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.LogsVisualizer.ElasticSearch.Models;
using Tavisca.LogsVisualizer.ElasticSearch.Translator;
using Tavisca.LogsVisualizer.Model.Interfaces;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.ElasticSearch
{
    public class ElasticSearchLogsMetaDataService : IElasticSearchLogsMetaDataService
     {
        ElasticClient client;
        public ElasticSearchLogsMetaDataService()
        {
          this.client = ElasticSearchClient.GetClient("http://logs.qa.oski.io/");
        }
        public MetaData GetMetaData(string CorrelationId)
        {
            ElasticSearchMetaData esMetaData = new ElasticSearchMetaData();
            MetaData metaData = new MetaData();
            List<long> applicationNames = new List<long>();
            var searchResponse = client.Search<ElasticSearchMetaData>(s => s.AllIndices()
                                                               .Type("logging")
                                                               .TypedKeys(null)
                                                               .Source(sf => sf.Includes(i => i.Fields(("json_rq_headers.oski-clientId"),
                                                                                                       ("json_rq_headers.oski-clientProgramGroupId"),
                                                                                                       ("json_rq_headers.oski-programId"),
                                                                                                       ("json_rq_headers.oski-tenantId"))))
                                                              .Aggregations(a => a.Terms("GettingApplicationNames", t => t.Field("pid")))
                                                              .Query(q => q.MatchPhrase(ma => ma.Field("cid")
                                                                                                .Query(CorrelationId)))
                                                              .Size(1));
            var applicationNameAggregations = searchResponse.Aggregations.Terms("GettingApplicationNames");
            foreach (var key in applicationNameAggregations.Buckets)
            {
              applicationNames.Add(long.Parse(key.Key));
            }
            esMetaData.AppNames = applicationNames;
            esMetaData.RequestHeaders= searchResponse.Documents.ToList()[0].RequestHeaders;
           
                //MetaDataTranslator metaDataTranslator = new MetaDataTranslator();
                metaData = esMetaData.GetMetaData();
            
           
            return metaData;
            
        }
     }
}
