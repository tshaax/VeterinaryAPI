using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Veterinary_Appointment_API.WorkFolder.Models;

namespace Veterinary_Appointment_API.WorkFolder.Common
{
    public static class InvoiceData
    {

        private static decimal _grandTotal;
        private static decimal _grandGrandTotal;
        private static decimal NoOfInvoiceItems;

        public static Invoices GenerateInvoices()
        {
            var inv = GetInvoices();
            foreach (var invoice in inv)
            {
                _grandGrandTotal += invoice.Total;
            }

            return new Invoices() { invoiceList = inv, Total = _grandGrandTotal, TotalInvoices = inv.Count };
        }
        private static List<Invoice> GetInvoices()
        {
            var list = new List<Invoice>();
            list.Add(GenerateInvoice1());
            list.Add(GenerateInvoice2());
            list.Add(GenerateInvoice3());

            return list;


        }
        private static Invoice GenerateInvoice3()
        {
            Invoice i = new Invoice
            {
                InvoiceNumber = "0003",
                Date = DateTime.Now,
                Customer_ID = "0003",
                Customer_Name = "James",

                InvoiceItem = new invoice_Item[3]
            };
            i.InvoiceItem[0] = new invoice_Item
            {
                description = "Pet Frog appointment",
                amount = 55003.00m,
                VAT = Calculator.CalculateVAT(55003.00m),
                Total = Calculator.CalculateTotal(i.InvoiceItem[0].amount, i.InvoiceItem[0].VAT)
            };


            i.InvoiceItem[1] = new invoice_Item
            {
                description = "Pet Anaconda appointment",

                amount = 1086.19m
            };
            i.InvoiceItem[1].VAT = Calculator.CalculateVAT(i.InvoiceItem[1].amount);
            i.InvoiceItem[1].Total = Calculator.CalculateTotal(i.InvoiceItem[1].amount, i.InvoiceItem[1].VAT);


            i.InvoiceItem[2].description = "Pet Rabbit appointment";

            i.InvoiceItem[2].amount = 50;
            i.InvoiceItem[2].VAT = Calculator.CalculateVAT(i.InvoiceItem[2].amount);
            i.InvoiceItem[2].Total = Calculator.CalculateTotal(i.InvoiceItem[2].amount, i.InvoiceItem[2].VAT);
            

            foreach (var item in i.InvoiceItem)
            {
                _grandTotal += item.Total;
                NoOfInvoiceItems++;
            }

            i.Total = _grandTotal;
            i.TotalCount = NoOfInvoiceItems;

            return i;
        }

        private static Invoice GenerateInvoice2()
        {
            Invoice i = new Invoice();
            i.InvoiceNumber = "0002";
            i.Date = DateTime.Now;
            i.Customer_ID = "0002";
            i.Customer_Name = "Harry";

            i.InvoiceItem = new invoice_Item[2];
            i.InvoiceItem[0] = new invoice_Item();
            i.InvoiceItem[0].description = "Pet Platypus appointment";
 
            i.InvoiceItem[0].amount = 5500.59m;
            i.InvoiceItem[0].VAT = Calculator.CalculateVAT(i.InvoiceItem[0].amount); 
            i.InvoiceItem[0].Total = Calculator.CalculateTotal(i.InvoiceItem[0].amount, i.InvoiceItem[0].VAT);

            i.InvoiceItem[1] = new invoice_Item();
            i.InvoiceItem[1].description = "Pet Megalodon appointment";

            i.InvoiceItem[1].amount = 105.99m;
            i.InvoiceItem[1].VAT = Calculator.CalculateVAT(i.InvoiceItem[1].amount);
            i.InvoiceItem[1].Total = Calculator.CalculateTotal(i.InvoiceItem[1].amount, i.InvoiceItem[1].VAT); ;

            foreach (var item in i.InvoiceItem)
            {
                _grandTotal += item.Total;
                NoOfInvoiceItems++;
            }

            i.Total = _grandTotal;
            i.TotalCount = NoOfInvoiceItems;

            return i;
        }

        private static Invoice GenerateInvoice1()
        {
            Invoice i = new Invoice();
            i.InvoiceNumber = "0001";
            i.Date = DateTime.Now;
            i.Customer_ID = "0001";
            i.Customer_Name = "Jake";

            i.InvoiceItem = new invoice_Item[2];
            i.InvoiceItem[0] = new invoice_Item();
            i.InvoiceItem[0].description = "Pet Rottweiler appointment";

            i.InvoiceItem[0].amount = 560.59m;
            i.InvoiceItem[0].VAT = Calculator.CalculateVAT(i.InvoiceItem[0].amount);
            i.InvoiceItem[0].Total = Calculator.CalculateTotal(i.InvoiceItem[0].amount, i.InvoiceItem[0].VAT); ;

            i.InvoiceItem[1] = new invoice_Item();
            i.InvoiceItem[1].description = "Pet Hamster appointment";
    
            i.InvoiceItem[1].amount = 582.99m;
            i.InvoiceItem[1].VAT = Calculator.CalculateVAT(i.InvoiceItem[1].amount);
            i.InvoiceItem[1].Total = Calculator.CalculateTotal(i.InvoiceItem[1].amount, i.InvoiceItem[1].VAT); ;

            foreach (var item in i.InvoiceItem)
            {
                _grandTotal += item.Total;
            }

            i.Total = _grandTotal;

            return i;
        }

    }
}