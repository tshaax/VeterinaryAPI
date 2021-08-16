using System;
using System.Collections.Generic;
using System.Web.Http;
using Veterinary_Appointment_API.WorkFolder.Common;
using Veterinary_Appointment_API.WorkFolder.Models;

namespace Veterinary_Appointment_API.WorkFolder.Controllers
{
    public class InvoiceController : ApiController
    {
        [System.Web.Http.HttpGet]
        public Invoices GenerateInvoice()
        {
            return InvoiceData.GenerateInvoices();
        }

    }

}
