using DatabaseData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DatabaseData
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public StatusEnum Status;

        [DataMember]
        public string Message;

        [DataMember]
        public List<KPI> KPIList;


        public enum StatusEnum
        {
            Success,
            Fail 
        }
        public Response()
        {
            this.Status = StatusEnum.Success;
        }
    }
}