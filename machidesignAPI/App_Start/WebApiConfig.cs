using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace machidesignAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API の設定およびサービス

            //参考サイト
            //http://miso-soup3.hateblo.jp/entry/2013/07/05/065648

            //QueryString で指定
            //config.Formatters.XmlFormatter.AddQueryStringMapping("format", "xml", "application/xml");
            //config.Formatters.JsonFormatter.AddQueryStringMapping("format", "json", "application/json");

            //URL の一部で指定
            config.Formatters.XmlFormatter.AddUriPathExtensionMapping("xml", "application/xml");
            config.Formatters.JsonFormatter.AddUriPathExtensionMapping("json", "application/json");

            //DBに外部キーがあるとエラーになる対策のはずが解決せず
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            // Web API ルート
            config.MapHttpAttributeRoutes();

            ////QueryString で指定
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //URL の一部で指定 最後に/を入れないと404になるので注意
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}.{ext}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
