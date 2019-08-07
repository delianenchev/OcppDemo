using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    [MessageContract]
    public class MessageModelRequest
    {
        [MessageHeader]
        public string Id { get; set; }

        [MessageBodyMember]
        public string Name { get; set; }

        [MessageBodyMember]
        public string Email { get; set; }
    }
}
