using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class PhoneNumbers
    {
        [DataMember]
        public List<PhoneNumber> PhoneNumber { get; set; }

        public PhoneNumbers() {}

        public PhoneNumbers(PhoneNumbers numbers)
        {
            if (numbers == null)
            {
                return;
            }
            PhoneNumber = new List<PhoneNumber>();
            foreach (PhoneNumber pn in numbers.PhoneNumber)
            {
                PhoneNumber.Add(new PhoneNumber(pn));
            }
        }
    }
}
