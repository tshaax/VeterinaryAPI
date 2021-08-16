using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder.BusinessRule
{
    public class CancelLogic : BaseLogic
    {
        private readonly DbService db;

        public CancelLogic()
        {
            this.db = new DbService();
        }
        public override void Process(string rawAppointmentData)
        {
            var obj = new Models.AppointmentDto
            {
                msg_type = Convert.ToInt32(rawAppointmentData.Substring(0, 1)),
                appt_id = Convert.ToInt32(rawAppointmentData.Substring(1, 4)),
            };

            StringBuilder createDb = new StringBuilder
             ($"CREATE TABLE IF NOT EXISTS Appointment (msg_type int, appt_id int,cust_id int, pet_id int, appt_time int)");


            StringBuilder deleteRec = new StringBuilder
                ($" DELETE FROM Appointment WHERE appt_id = {obj.appt_id} ");

            db.Save(createDb.ToString(), deleteRec.ToString());
        }
    }
}