using Supermarket.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supermarket.Controllers
{
    public class KPIController : Controller
    {
        // GET: KPI
        public ActionResult Index(string Message)
        {
           List<KPI> KPIList = new List<KPI>();

            if (!String.IsNullOrEmpty(Message))
            {
                ViewBag.SaveMessage = Message;
            }
            try
            {
                using (DataServiceClient client = new DataServiceClient())
                {
                    Response response = client.GetKPIS();
                    if(response.Status == DataService.Response.StatusEnum.Fail)
                    {
                        return View(new List<KPI>());

                    }
                    KPIList = response.KPIList.ToList();
                }
                
            }
            catch(Exception ex)
            {
                return View(new List<KPI>());
            }

            return View(KPIList);
        }


        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(KPI kpi)
        {
            List<KPI> KPIList = new List<KPI>();
            try
            {
                using (DataServiceClient client = new DataServiceClient())
                {
                    Response response = client.CreateKPI(kpi);
                    if (response.Status == DataService.Response.StatusEnum.Fail)
                    {

                    }
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                return View(new List<KPI>());
            }

            return View(KPIList);
        }
    }
}