using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class PhoneNumber
    {
        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public int PhoneType { get; set; }

        public PhoneNumber() { }

        public PhoneNumber(PhoneNumber clonedNumber)
        {
            Number = clonedNumber.Number;
            PhoneType = clonedNumber.PhoneType;
        }
    }

}
