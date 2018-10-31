using System;

namespace GenericDictionaries
{
    public class Vendor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
