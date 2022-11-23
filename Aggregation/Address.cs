using System;

namespace Aggregation
{

    public class Address
    {
        public string HostName { get; set; }
        public string Street => "Fifth Avenue";
        public Address()
        {
            Console.WriteLine("We have an address now.");
        }
    }

}
