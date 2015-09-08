using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class Addresses
    {
        [DataMember]
        public List<Address> Address { get; set; }

        public Addresses() { }

        public Addresses(Addresses addresses)
        {
            if (addresses == null)
            {
                return;
            }
            Address = new List<Address>();
            foreach (Address addr in addresses.Address)
            {
                Address.Add(new Address(addr));
            }
        }
    }
}
