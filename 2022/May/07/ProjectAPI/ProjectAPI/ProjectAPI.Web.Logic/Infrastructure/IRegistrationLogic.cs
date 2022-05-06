using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Web.Logic.Infrastructure
{
    public interface IRegistrationLogic
    {
        void CheckDuplicates();
    }
}
