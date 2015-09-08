using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class EmailAddresses
    {
        [DataMember]
        public List<EmailAddressModel> EmailAddress { get; set; }

        public EmailAddresses() { }

        public EmailAddresses(EmailAddresses addrs)
        {
            if (addrs == null)
            {
                return;
            }
            EmailAddress = new List<EmailAddressModel>();
            foreach (EmailAddressModel eam in addrs.EmailAddress)
            {
                EmailAddress.Add(new EmailAddressModel(eam));
            }
        }
    }
}
