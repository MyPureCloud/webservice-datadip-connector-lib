using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace inin.Bridge.WebServices.Datadip.Lib
{
    [DataContract]
    public class Case
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string AssigneeId { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ContactId { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CustomAttribute { get; set; }

        public Case() { }

        public Case(Case clonedCase)
        {
            Id = clonedCase.Id;
            AssigneeId = clonedCase.AssigneeId;
            Subject = clonedCase.Subject;
            Status = clonedCase.Status;
            ContactId = clonedCase.ContactId;
            ContactName = clonedCase.ContactName;
            CustomAttribute = clonedCase.CustomAttribute;
        }

    }
}
