using System;
using System.Collections.Generic;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var colorOptions = new List<string>() { "Red", "Espresso", "White" };

            colorOptions.Add("Navy");
            colorOptions.Insert(2, "Purple");
            colorOptions.Remove("White");

            var vendors = new List<Vendor>();

            vendors.Add(new Vendor() { Id = 1, Name = "ABC Corp", Email = "abc@abc.com" });
            vendors.Add(new Vendor() { Id = 1, Name = "XYZ Inc", Email = "xyz@xyz.com" });

            for (int i = 0; i < vendors.Count; i++)
            {
                vendors[i].Name = vendors[i].Name.ToLower();
            }

            foreach (var vendor in vendors)
            {
                Console.WriteLine(vendor);
            }
        }
    }
}
