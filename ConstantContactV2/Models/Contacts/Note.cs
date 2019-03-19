
using System;
using System.Runtime.Serialization;

namespace Aarvani.ConstantContactV2.Models.Contacts
{
    [DataContract]
    [Serializable]
    public class Note
    {
        
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Content { get; set; }
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }
        [DataMember(Name = "modified_date", EmitDefaultValue = false)]
        public string ModifiedDate { get; set; }
    }
}
