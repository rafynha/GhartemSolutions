using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace GhartemSolutions.Templates.ApiBasic.Api
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetID(this HttpRequestMessage request)
        {            
            string guid = request.GetCorrelationId().ToString();

            //if (guid != null)
            //{
            //    string[] values = owinEnviroment["Request_ID"] as string[];

            //    if (values != null && values.Length > 0)
            //    {
            //        return values[0];
            //    }
            //}

            return guid ?? string.Empty;
        }

        
        //public static string GetID(this IOwinRequest request)
        //{
        //    var id = request.GetHashCode();

        //    if (request.Environment.ContainsKey("Request_ID"))
        //    {
        //        string[] values = request.Environment["Request_ID"] as string[];

        //        if (values != null && values.Length > 0)
        //        {
        //            return values[0];
        //        }
        //    }

        //    return id.Equals(0) ? string.Empty : id.ToString();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ToAppSettingValue(this string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}