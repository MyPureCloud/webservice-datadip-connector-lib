using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class EmailAddressModel
    {
        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public int EmailType { get; set; }

        public EmailAddressModel() { }

        public EmailAddressModel(EmailAddressModel eam)
        {
            EmailAddress = eam.EmailAddress;
            EmailType = eam.EmailType;
        }
    }
}
