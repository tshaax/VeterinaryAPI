using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.WorkFolder.Models
{
    public class Invoices
    {
        public List<Invoice> invoiceList { get; set; }
        public decimal Total { get; set; }
        public decimal TotalInvoices { get; set; }
    }
}