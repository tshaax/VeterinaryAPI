using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Veterinary_Appointment_API.WorkFolder.Data_Services;
using Veterinary_Appointment_API.WorkFolder.Models;

namespace Veterinary_Appointment_API.WorkFolder.Controllers
{
    public class AppointmentController : ApiController
    {
        private readonly DbService db;

        public AppointmentController()
        {
            this.db = new DbService();
        }

        [HttpGet]
        public List<AppointmentModel> GetAppointmentsAsync()
        {
            var res = db.GetAppointmentDbData();
            var list = new List<AppointmentModel>();
            res.ForEach(f => list.Add(new AppointmentModel
            {
                AppointmentID = f.AppointmentID,
                AppointmentTime = f.AppointmentTime,
                AppointmentDetails = new AppointmentDetailModel
                {
                    IdentityNumber = f.IdentityNumber.ToString(),
                    CustomerName = f.CustomerName,
                    PetName = f.PetName
                }
            }));

            return list;
        }
    }
}
