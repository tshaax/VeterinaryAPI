using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinary_Appointment_API.Thirdparty.Extensions
{
    public static class PetNameGenerator
    {
        private static string[] Names = new[]
        {
            "Tigger",
            "Tiger",
            "Max",
            "Smokey",
            "Sam",
            "Kitty",
            "Sassy",
            "Shadow",
            "Simba",
            "Patch",
            "Lucky",
            "Misty",
            "Sammy",
            "Princess",
            "Oreo",
            "Samantha",
            "Charlie",
            "Boots",
            "Brandy",
            "Oliver",
            "Duke",
            "Lucy",
            "Precious",
            "Missy",
            "Oscar",
            "Fluffy",
            "Whiskers",
            "Gizmo",
            "Taz",
            "Molly",
            "Midnight",
            "Buddy",
            "Baby",
            "Toby",
            "Spike",
            "Dakota",
            "Sophie",
            "Rusty",
            "Pumpkin",
            "Jake"
        };
        public static string GetPetName(this Random r)
        {
            int index = r.Next(40);
            return Names[index];
        }
    }
}