using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.LogsVisualizer.ElasticSearch
{
    class ElasticSearchClient
    {
        public static ElasticClient GetClient(string URL)
        {
            var node = new Uri(URL);
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);
            return client;
        }
    }
}
