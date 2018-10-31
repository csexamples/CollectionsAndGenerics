using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendors = RetrieveVendors();

            var vendorQuery = from v in vendors
                              where v.Name.Contains("Toy")
                              select v;

            vendorQuery = vendors.Where(vendor => vendor.Name.Contains("Toy")).OrderBy(vendor => vendor.Name);

            foreach (var vendor in vendorQuery.ToList())
            {
                Console.WriteLine(vendor);
            }
        }

        public static IEnumerable<Vendor> RetrieveVendors()
        {
            return new List<Vendor>
            {
                new Vendor { Id = 1, Name = "ABC Corp", Email = "abc@abc.com" },
                new Vendor { Id = 1, Name = "XYZ Inc", Email = "xyz@xyz.com" },
                new Vendor { Id = 1, Name = "EFG Ltd", Email = "efg@efg.com" },
                new Vendor { Id = 1, Name = "HIJ AG", Email = "hij@hij.com" },
                new Vendor { Id = 1, Name = "Amalgamated Toys", Email = "a@abc.com" },
                new Vendor { Id = 1, Name = "Toy Blocks Inc", Email = "blocks@abc.com" },
                new Vendor { Id = 1, Name = "Home Products Inc", Email = "home@abc.com" },
                new Vendor { Id = 1, Name = "Car Toys", Email = "car@abc.com" },
                new Vendor { Id = 1, Name = "Toys for Fun", Email = "fun@abc.com" }
            };
        }
    }
}
