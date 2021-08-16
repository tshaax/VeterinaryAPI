using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.Thirdparty.Extensions
{
    public static class CustomerNameGenerator
    {
        private static string[] Names = new [] {
            "Jerry Jones",
            "Jake Platt",
            "John Forman",
            "Belinda Rosemary",
            "Berry White",
            "David Jones",
            "Dave McKenzy",
            "Lee TheLegend",
            "Taryn TheAmazing",
            "Jared Britz",
            "Adam Sandler",
            "Eve Jonas",
            "Gary Thomson",
            "Drake Thomson",
            "Kyle TheMan",
            "Dewald TheMysterious",
            "Daryn Product Simpson",
            "Candy Cane",
            "Clive Johnson",
            "Cindy Johnson",
            "Brent Bradley",
            "Bradley Rivers",
            "Andy James",
            "Charlie Parra del Riego",
            "Charles Manson",
            "Dick Dickonson",
            "Don Don",
            "Jimmy page",
            "Jimmy Hendrix",
            "Stevie Terreberry",
            "Slash Slasher",
            "Mary Hereshecomes",
            "Mary Dairy",
            "June Simpson",
            "Daryn Simpson",
            "Sonny Bill Williams",
            "Stacey Platt",
            "Freddy Platt",
            "Stanley Manley",
            "Frankie Furter",
            "Bill Cyrus",
            "Joe Moroson",
            "Ashley TheCrazy",
            "John Doe",
            "Jane Doe",
            "Jason Wolf",
            "Ged Thomason",
            "Bob TheBuilder"
        };

        public static string GetCustomerName(this Random r)
        {
            return Names[r.Next(48)];
        }
}
}