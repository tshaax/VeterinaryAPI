using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class AppointmentModel
    {
        public int AppointmentID { get; set; }
        public int AppointmentTime { get; set; }
        public AppointmentDetailModel AppointmentDetails { get; set; }

    }
    public class AppointmentDetailModel
    {
        public string CustomerName { get; set; }
        public string IdentityNumber { get; set; }
        public string PetName { get; set; }

    }
}