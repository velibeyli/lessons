using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ProjectAPI.Web.API.Controllers
{
    public class RegistrationController : ApiController
    {
        private readonly IRegistrationLogic _registrationLogic;

        //public RegistrationController(IRegistrationLogic registrationLogic)
        //{
        //    _registrationLogic = registrationLogic;
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //public HttpResponseMessage CheckDuplicates()
        //{

        //}
    }
}