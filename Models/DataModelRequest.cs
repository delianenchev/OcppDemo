using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    [DataContract]
    public class DataModelRequest
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
