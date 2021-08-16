using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public partial class Invoice : Customer
    {
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public invoice_Item[] InvoiceItem { get; set; }
        public decimal Total { get; set; }
        public decimal TotalCount { get; set; }
    }
}