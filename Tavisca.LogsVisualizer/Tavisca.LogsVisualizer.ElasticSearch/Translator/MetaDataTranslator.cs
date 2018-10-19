using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.LogsVisualizer.ElasticSearch.Models;
using Tavisca.LogsVisualizer.Model.Models;

namespace Tavisca.LogsVisualizer.ElasticSearch.Translator
{
    public static class MetaDataTranslator
    {
        public static MetaData GetMetaData(this ElasticSearchMetaData esMetaData)
        {
            MetaData metaData = new MetaData();
            metaData.AppNames = esMetaData.AppNames;
            if (esMetaData.RequestHeaders != null)
            {
                metaData.ClientId = esMetaData.RequestHeaders.ClientId;
                metaData.ClientProgramId = esMetaData.RequestHeaders.ClientProgramId;
                metaData.ProgramId = esMetaData.RequestHeaders.ProgramId;
                metaData.TenantId = esMetaData.RequestHeaders.TenantId;
            }
            return metaData;
        } 
    }
}
