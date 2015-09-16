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
        [DataMember(EmitDefaultValue = false)]
        public string CustomAttribute { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Number { get; set; }

        [DataMember(EmitDefaultValue=false)]
        public Addresses Addresses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PhoneNumbers PhoneNumbers { get; set; }

        [DataMember(EmitDefaultValue = false)]
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
            if (clonedAccount.Addresses != null) {
                Addresses = new Addresses(clonedAccount.Addresses);
            }
            if (clonedAccount.PhoneNumbers != null)
            {
                PhoneNumbers = new PhoneNumbers(clonedAccount.PhoneNumbers);
            }
            if (clonedAccount.EmailAddresses != null)
            {
                EmailAddresses = new EmailAddresses(clonedAccount.EmailAddresses);
            }
        }
    }
}
