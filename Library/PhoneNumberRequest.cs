using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class PhoneNumberRequest
    {
        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string CustomAttribute { get; set; }
    }
}
