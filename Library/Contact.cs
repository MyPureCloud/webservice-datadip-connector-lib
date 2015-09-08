using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string CustomAttribute { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public EmailAddresses EmailAddresses { get; set; }

        [DataMember]
        public PhoneNumbers PhoneNumbers { get; set; }

        public Contact() { }

        public Contact(Contact clonedContact)
        {
            FirstName = clonedContact.FirstName;
            LastName = clonedContact.LastName;
            Id = clonedContact.Id;
            CustomAttribute = clonedContact.CustomAttribute;
            Address = new Address(clonedContact.Address);
            EmailAddresses = new EmailAddresses(clonedContact.EmailAddresses);
            PhoneNumbers = new PhoneNumbers(clonedContact.PhoneNumbers);
        }

    }

}
