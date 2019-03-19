

using System;
using System.Runtime.Serialization;

namespace Aarvani.ConstantContactV2.Models.Contacts
{
    [DataContract]
    [Serializable]
    public class EmailAddress 
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "opt_out_date", EmitDefaultValue = false)]
        public string OptOutDate { get; set; }
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }
        [DataMember(Name = "opt_in_source", EmitDefaultValue = false)]
        public string OptInSource { get; set; }
        [DataMember(Name = "opt_in_date", EmitDefaultValue = false)]
        public string OptInDate { get; set; }
        [DataMember(Name = "opt_out_source", EmitDefaultValue = false)]
        public string OptOutSource { get; set; }
        [DataMember(Name = "confirm_status", EmitDefaultValue = false)]
        public string ConfirmStatus { get; set; }
        [DataMember(Name = "email_address")]
        public string EmailAddr { get; set; }

        public EmailAddress()
        {

        }

        public EmailAddress(string emailAddress)
        {
            this.EmailAddr = emailAddress;
        }
    }
}
