using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjectAPI.Web.API.Infrastructure
{
    public class BaseController : ApiController
    {
        public const string HttpGet = "GET";
        public const string HttpPost = "POST";
        private static string[] _supportedLanguages;
    }
}