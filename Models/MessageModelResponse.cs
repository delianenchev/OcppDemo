using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    [MessageContract]
    public class MessageModelResponse
    {
        [MessageBodyMember]
        public string Status { get; set; }

        [MessageBodyMember]
        public string Id { get; set; }
    }
}
