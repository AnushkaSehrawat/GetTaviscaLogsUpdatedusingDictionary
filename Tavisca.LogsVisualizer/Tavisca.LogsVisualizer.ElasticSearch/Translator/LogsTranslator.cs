using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.ElasticSearch.Translator
{
    internal static class LogsTranslator
    {
        internal static List<Log> TranslateObjectToListOfLogObjects(this List<Dictionary<string,object>> DictionaryOfLogs)
            {
            //List<Log> Alllogs = ResponseObject.Documents
            //                                     .ToList()
            //                                     .ConvertAll<Dictionary<string, object>>(x => JsonConvert.DeserializeObject<Dictionary<string, object>>(x.ToString()))
            //                                     .Select(x => new Log { Id = x["id"].ToString(), type = x["type"].ToString(), AppName = x["app_name"].ToString(), KeyValue = x })
            //                                     .ToList<Log>();
            List<Log> Alllogs = new List<Log>();
           for(int index = 0; index < DictionaryOfLogs.Count; index++)
            {
                Alllogs.Add(new Log { Id= DictionaryOfLogs[index]["id"].ToString(),type=DictionaryOfLogs[index]["type"].ToString(),AppName=DictionaryOfLogs[index]["app_name"].ToString(),KeyValue=DictionaryOfLogs[index]});
            }

            //List<Log> docJSonStrings = ResponseObject.Documents
            //                                        //.Select(x => x.ToString())
            //                                        .ToList()
            //                                        .ConvertAll<Dictionary<string, Object>>(x => JsonConvert.DeserializeObject<Dictionary<string, Object>>(x.ToString()))
            //                                        .Select(x => new Log() { Id = x["id"].ToString(), type = x["type"].ToString(), AppName = x["app_name"].ToString(), KeyValue = x })
            //                                        .ToList<Log>();
            return Alllogs;



         }
    }
}
