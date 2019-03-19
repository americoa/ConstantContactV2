
using System.Runtime.Serialization;

namespace Aarvani.ConstantContactV2.Models.Contacts
{
    public class ContactList
    {

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }
        [DataMember(Name = "contact_count", EmitDefaultValue = false)]
        public int ContactCount { get; set; }
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public string DateCreated { get; set; }
        [DataMember(Name = "modified_date", EmitDefaultValue = false)]
        public string DateModified { get; set; }
    }
}
