using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SampleService : ISampleService
    {
        public DataModelResponse TestDataModel(DataModelRequest customModel)
        {
            return new DataModelResponse()
            {
                Status = customModel != null ? "Success" : "Fail",
                Id = customModel?.Id ?? "-1"
            };
        }


        public MessageModelResponse TestMessageModel(MessageModelRequest customModel)
        {
            return new MessageModelResponse()
            {
                Status = customModel != null ? "Success" : "Fail",
                Id = customModel?.Id ?? "-1"
            };
        }
    }
}
