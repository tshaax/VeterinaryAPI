using System.Threading.Tasks;

namespace Veterinary_Appointment_API.WorkFolder
{
    public interface IAppointmentProcessor
    {
        void  Process_IncomingAppointment(string rawAppointmentData);
    }
}