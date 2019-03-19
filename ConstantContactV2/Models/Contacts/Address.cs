

using System;
using System.Runtime.Serialization;

namespace Aarvani.ConstantContactV2.Models.Contacts
{
    [DataContract]
    [Serializable]
    public class Address
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "line1", EmitDefaultValue = false)]
        public string Line1 { get; set; }
        [DataMember(Name = "line2", EmitDefaultValue = false)]
        public string Line2 { get; set; }
        [DataMember(Name = "line3", EmitDefaultValue = false)]
        public string Line3 { get; set; }
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }
        [DataMember(Name = "address_type", EmitDefaultValue = false)]
        public string AddressType { get; set; }
        [DataMember(Name = "state_code", EmitDefaultValue = false)]
        public string StateCode { get; set; }
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string StateName { get; set; }
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }
        [DataMember(Name = "sub_postal_code", EmitDefaultValue = false)]
        public string SubPostalCode { get; set; }
    }
}
