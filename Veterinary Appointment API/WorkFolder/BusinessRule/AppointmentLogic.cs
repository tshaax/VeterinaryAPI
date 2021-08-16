using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder.BusinessRule
{
    public class AppointmentLogic : BaseLogic
    {
        private readonly DbService db;

        public AppointmentLogic()
        {
            this.db = new DbService();
        }
        public override void Process(string rawAppointmentData)
        {
            var obj = new Models.AppointmentDto
            {
                msg_type = Convert.ToInt32(rawAppointmentData.Substring(0, 1)),
                appt_id = Convert.ToInt32(rawAppointmentData.Substring(1, 4)),
                cust_id = Convert.ToInt32(rawAppointmentData.Substring(5, 4)),
                pet_id = Convert.ToInt32(rawAppointmentData.Substring(9, 4)),
                appt_time = Convert.ToInt32(rawAppointmentData.Substring(13, 4)),

            };

            StringBuilder createDb = new StringBuilder
                ($"CREATE TABLE IF NOT EXISTS Appointment (msg_type int, appt_id int,cust_id int, pet_id int, appt_time int)");

            StringBuilder insertdt = new StringBuilder();
            insertdt.Append("  INSERT INTO Appointment (msg_type,appt_id,cust_id,pet_id,appt_time)");
            insertdt.Append($" VALUES ({obj.msg_type},{obj.appt_id},{obj.cust_id},{obj.pet_id},{obj.appt_time})");

            db.Save(createDb.ToString(), insertdt.ToString());
        }
    }
}