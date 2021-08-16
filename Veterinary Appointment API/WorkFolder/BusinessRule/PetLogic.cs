using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Veterinary_Appointment_API.WorkFolder.Data_Services;

namespace Veterinary_Appointment_API.WorkFolder.BusinessRule
{
    public class PetLogic : BaseLogic
    {
        private readonly DbService db;

        public PetLogic()
        {
            this.db = new DbService();
        }
        public override void Process(string rawAppointmentData)
        {
            var obj = new Models.PetDto
            {
                msg_type = Convert.ToInt32(rawAppointmentData.Substring(0, 1)),
                cust_id = Convert.ToInt32(rawAppointmentData.Substring(1, 4)),
                pet_id = Convert.ToInt32(rawAppointmentData.Substring(5, 4)),
                pet_name = rawAppointmentData.Substring(9, 11)

            };

            StringBuilder createDb = new StringBuilder
                ($"CREATE TABLE IF NOT EXISTS Pet (msg_type int,cust_id int, pet_id int, pet_name varchr(50))");

            StringBuilder insertdt = new StringBuilder();
            insertdt.Append("  INSERT INTO Pet (msg_type,cust_id,pet_id,pet_name)");
            insertdt.Append($" VALUES ({obj.msg_type},{obj.cust_id},{obj.pet_id},'{obj.pet_name}')");

            db.Save(createDb.ToString(), insertdt.ToString());
        }
    }
}