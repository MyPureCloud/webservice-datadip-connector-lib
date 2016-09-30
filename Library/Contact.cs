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
        [DataMember(EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FullName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CustomAttribute { get; set; }

        [DataMember(EmitDefaultValue=false)]
        public Address Address { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public EmailAddresses EmailAddresses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PhoneNumbers PhoneNumbers { get; set; }

        public Contact() { }

        public Contact(Contact clonedContact)
        {
            FirstName = clonedContact.FirstName;
            LastName = clonedContact.LastName;
            FullName = clonedContact.FullName;

            Id = clonedContact.Id;
            CustomAttribute = clonedContact.CustomAttribute;
            if (clonedContact.Address != null)
            {
                Address = new Address(clonedContact.Address);
            }
            if (clonedContact.EmailAddresses != null)
            {
                EmailAddresses = new EmailAddresses(clonedContact.EmailAddresses);
            }
            if (clonedContact.PhoneNumbers != null)
            {
                PhoneNumbers = new PhoneNumbers(clonedContact.PhoneNumbers);
            }
        }

    }

}
