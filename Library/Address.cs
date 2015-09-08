using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Line1 { get; set; }

        [DataMember]
        public string Line2 { get; set; }

        [DataMember]
        public string Line3 { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Type { get; set; }

        public Address() { }

        public Address(Address address)
        {
            City = address.City;
            Country = address.Country;
            Line1 = address.Line1;
            Line2 = address.Line2;
            Line3 = address.Line3;
            PostalCode = address.PostalCode;
            State = address.State;
            Type = address.Type;
        }
    }
}
