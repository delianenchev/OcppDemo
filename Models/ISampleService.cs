using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        DataModelResponse TestDataModel(DataModelRequest inputModel);

        [OperationContract]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        MessageModelResponse TestMessageModel(MessageModelRequest inputModel);
    }
}
