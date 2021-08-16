using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder.Controllers
{
    /// <summary>
    /// This is an example controller.
    /// </summary>
    public class HomeController : ApiController
    {
        public HomeController()
        {
           
        }
        [System.Web.Http.HttpGet]
        public string Index()
        {
            return "Welcome to the Veterinary API";
        }
    }
}
