using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendorsCollection = RetrieveVendors();

            var vendorsArray = vendorsCollection.ToArray();
            var vendorsList = vendorsCollection.ToList();
            var vendorsDictionary = vendorsCollection.ToDictionary(vendor => vendor.Name);

            SendEmail(vendorsArray, "important message");
            SendEmail(vendorsList, "important message");
            SendEmail(vendorsDictionary.Values, "important message");

            var vendorIterator = RetrieveIterator();

            foreach (var vendor in vendorIterator)
            {
                Console.WriteLine(vendor);
            }
        }

        public static void SendEmail(IEnumerable<Vendor> vendors, string message)
        {
            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Message to {vendor} has been sent.");
            }
        }

        public static IEnumerable<Vendor> RetrieveVendors()
        {
            return new List<Vendor>
            {
                new Vendor { Id = 1, Name = "ABC Corp", Email = "abc@abc.com" },
                new Vendor { Id = 2, Name = "XYZ Inc", Email = "xyz@xyz.com" }
            };
        }

        public static IEnumerable<Vendor> RetrieveIterator()
        {
            var vendors =  new List<Vendor>
            {
                new Vendor { Id = 1, Name = "ABC Corp", Email = "abc@abc.com" },
                new Vendor { Id = 2, Name = "XYZ Inc", Email = "xyz@xyz.com" }
            };

            foreach (var vendor in vendors)
            {
                yield return vendor;
            }
        }
    }
}
