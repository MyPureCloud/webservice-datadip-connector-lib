using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class AccountNumberRequest
    {
        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public string CustomAttribute { get; set; }
    }
}