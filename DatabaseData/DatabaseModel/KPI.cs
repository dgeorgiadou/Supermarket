using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData.Model
{
    public class KPI
    {
        public int ID { get; set; }

        public decimal Upthreshold { get; set; }

        public decimal Dowmthreshold { get; set; }

        public decimal Goal { get; set; }

        public static Response CreateKPI(KPI kpi)
        {
            Response toReturn = new Response();
            
            try
            {
                using (DatabaseContext databaseContext = new DatabaseContext())
                {
                    databaseContext.KPIs.Add(kpi);
                    databaseContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                toReturn.Status = Response.StatusEnum.Fail;
                toReturn.Message = ex.Message;
            }
            return toReturn;
        }

        public static Response GetKPIS()
        {
            Response toReturn = new Response();

            try
            {
                using (DatabaseContext databaseContext = new DatabaseContext())
                {
                   toReturn.KPIList =  databaseContext.KPIs.ToList();
                }
            }
            catch (Exception ex)
            {
                toReturn.Status = Response.StatusEnum.Fail;
                toReturn.Message = ex.Message;
            }
            return toReturn;
        }
    }
}
