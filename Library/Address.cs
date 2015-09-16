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
        [DataMember(EmitDefaultValue = false)]
        public string City { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Line1 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Line2 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Line3 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }

        public Address() { }

        public Address(Address address)
        {
            if (address == null)
            {
                return;
            }
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
