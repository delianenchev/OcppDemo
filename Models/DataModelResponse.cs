using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class DataModelResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Id { get; set; }
    }
}
