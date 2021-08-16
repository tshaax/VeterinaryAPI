
namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class invoice_Item
    {
        public string description { get; set; }
        public decimal amount { get; set; }
        public decimal VAT { get; set; } 
        public decimal Total { get; set; }
    }
}