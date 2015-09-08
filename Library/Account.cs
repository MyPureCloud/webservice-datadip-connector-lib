using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public string CustomAttribute { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public Addresses Addresses { get; set; }

        [DataMember]
        public PhoneNumbers PhoneNumbers { get; set; }

        [DataMember]
        public EmailAddresses EmailAddresses { get; set; }

        public Account() { }

        public Account(Account clonedAccount)
        {
            if (clonedAccount == null)
            {
                return;
            }
            CustomAttribute = clonedAccount.CustomAttribute;
            Id = clonedAccount.Id;
            Name = clonedAccount.Name;
            Number = clonedAccount.Number;
            Addresses = new Addresses(clonedAccount.Addresses);
            PhoneNumbers = new PhoneNumbers(clonedAccount.PhoneNumbers);
            EmailAddresses = new EmailAddresses(clonedAccount.EmailAddresses);

        }
    }
}
