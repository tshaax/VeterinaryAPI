namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class AppointmentDto
    {
        public int msg_type { get; set; }
        public int appt_id { get; set; }
        public int cust_id { get; set; }
        public int pet_id { get; set; }
        public int appt_time { get; set; }
    }
}