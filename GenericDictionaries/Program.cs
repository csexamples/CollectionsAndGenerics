using System;
using System.Collections.Generic;

namespace GenericDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new Dictionary<string, string>()
            {
                { "CA", "California" },
                { "WA", "Washington" }
            };

            states.Add("NY", "New York");

            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor() { Id = 1, Name = "ABC Corp", Email = "abc@abc.com" } },
                { "XYZ Inc", new Vendor() { Id = 2, Name = "XYZ Inc", Email = "xyz@xyz.com" } }
            };

            foreach (var element in vendors)
            {
                Console.WriteLine($"Key: {element.Key}, value: {element.Value}");
            }

            foreach (var value in vendors.Values)
            {
                Console.WriteLine(value);
            }

            foreach (var key in vendors.Keys)
            {
                Console.WriteLine(vendors[key]);
            }


            if (vendors.TryGetValue("XYZ Inc", out var vendor))
            {
                Console.WriteLine(vendor);
            }
        }
    }
}
