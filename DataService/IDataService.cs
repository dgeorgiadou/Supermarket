using DatabaseData;
using DatabaseData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {

        [OperationContract]
        Response GetKPIS();


        [OperationContract]
        Response CreateKPI(KPI kpi);
    }


}
