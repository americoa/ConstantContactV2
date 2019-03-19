using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Aarvani.ConstantContactV2.Models.Contacts
{
    [DataContract]
    [Serializable]
    public class Contact
    {
        [DataMember(Name = "email_addresses")]
        private List<EmailAddress> _emailAddresses = new List<EmailAddress>();

        [DataMember(Name = "addresses")]
        private List<Address> _addresses = new List<Address>();

        [DataMember(Name = "notes")]
        private List<Note> _notes = new List<Note>();

        [DataMember(Name = "lists")]
        private List<ContactList> _lists = new List<ContactList>();

        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        private string DateCreatedString { get; set; }

        [DataMember(Name = "modified_date", EmitDefaultValue = false)]
        private string DateModifiedString { get; set; }
       
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }
        
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }
        
        [DataMember(Name = "middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }
        
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }
        
        [DataMember(Name = "confirmed", EmitDefaultValue = false)]
        public bool Confirmed { get; set; }
        
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }
        
        public IList<EmailAddress> EmailAddresses
        {
            get { return _emailAddresses; }
            set { _emailAddresses = value == null ? null : value.ToList(); }
        }
        
        [DataMember(Name = "prefix_name", EmitDefaultValue = false)]
        public string PrefixName { get; set; }
        
        [DataMember(Name = "job_title", EmitDefaultValue = false)]
        public string JobTitle { get; set; }
        
        public IList<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value == null ? null : value.ToList(); }
        }
        
        public IList<Note> Notes
        {
            get { return _notes; }
            set { _notes = value == null ? null : value.ToList(); }
        }
        
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

     
        [DataMember(Name = "home_phone", EmitDefaultValue = false)]
        public string HomePhone { get; set; }
        
        [DataMember(Name = "work_phone", EmitDefaultValue = false)]
        public string WorkPhone { get; set; }


        [DataMember(Name = "cell_phone", EmitDefaultValue = false)]
        public string CellPhone { get; set; }
        
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }
        
        public List<ContactList> Lists
        {
            get { return _lists; }
            set { _lists = value == null ? null : value.ToList(); }
        }
        
        [DataMember(Name = "source_details", EmitDefaultValue = false)]
        public string SourceDetails { get; set; }
    }
}
