
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Aarvani.ConstantContactV2.Configurations;

namespace Aarvani.ConstantContactV2.Models
{
    [DataContract]
    [Serializable]
    public class ResultSet<T> 
    {
        [DataMember(Name = "results")]
        private List<T> _Results;

        public IList<T> Results
        {
            get { return _Results; }
            set { _Results = value == null ? null : value.ToList(); }
        }
     
        [DataMember(Name = "meta")]
        public Meta Meta { get; set; }
    }
    
    
    [DataContract]
    [Serializable]
    public class Meta
    {
     
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Pagination
    {
        [DataMember(Name = "next_link")]
        public string Next { get; set; }
       
        public string GetNextUrl()
        {
            return String.Concat(Endpoints.api, this.Next.Replace("/v2/", String.Empty));
        }
    }
}
