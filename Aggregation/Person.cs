using System;
using System.Collections.Generic;

namespace Aggregation
{

    ///<summary>
    /// A Person has an address. If we delete a Person, the address still remains. Other person can take it.
    ///<summary>
    public class Person
    {
        public string Name => "Jon Doe";

        // we keep a dependency here between classes
        public Address _address;

        public List<Address> OtherAddresses;

        public Person(Address address)
        {
            _address = address;
            _address.HostName = this.Name;

            Console.WriteLine($"The person {Name} has a main address on {_address.Street}");
        }

        public void AddAddresses(Address address)
        {

            OtherAddresses.Add(address);
        }

    }


}