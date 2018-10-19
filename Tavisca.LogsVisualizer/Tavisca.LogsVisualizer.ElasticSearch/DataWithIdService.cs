using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Tavisca.LogsVisualizer.Model.Models;
using System.Linq;
using Tavisca.LogsVisualizer.ElasticSearch.Translator;

namespace Tavisca.LogsVisualizer.ElasticSearch
{
    public class DataWithIdService
    {
        ElasticClient client;   
        public DataWithIdService()
        {
          this.client = ElasticSearchClient.GetClient("http://logs.qa.oski.io/");
        }

        public List<Log> GetLog(string CorrelationId)
        {
            
            var response = client.Search<Object>(s => s.TypedKeys(null)
                                                    .AllIndices()
                                                    .AllTypes()
                                                    .Query(q => q.Match(m=>m.Field("cid")
                                                                             
                                                                                .Query(CorrelationId))));
            

            //return docJSonStrings;
            var myDict=  response.Documents.ToList()
                                .ConvertAll<Dictionary<String,Object>>(x=>JsonConvert.DeserializeObject < Dictionary < string, object>>(x.ToString()));
           List<Log> allLogs= myDict.TranslateObjectToListOfLogObjects();
            return allLogs;

        }
     }
}
