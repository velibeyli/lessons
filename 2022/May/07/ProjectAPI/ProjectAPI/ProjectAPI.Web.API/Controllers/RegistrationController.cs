using ProjectAPI.Web.API.Infrastructure;
using ProjectAPI.Web.Logic.Infrastructure;
using System.Net.Http;
using System.Web.Http;

namespace ProjectAPI.Web.API.Controllers
{
    public class RegistrationController : BaseController
    {
        private readonly IRegistrationLogic _registrationLogic;

        public RegistrationController()
        {

        }
        public RegistrationController(IRegistrationLogic registrationLogic)
        {
            _registrationLogic = registrationLogic;
        }

        [HttpGet]
        [AllowAnonymous]
        public HttpResponseMessage CheckDuplicates()
        {
            _registrationLogic.CheckDuplicates();
            return Request.CreateResponse();
        }
    }
}