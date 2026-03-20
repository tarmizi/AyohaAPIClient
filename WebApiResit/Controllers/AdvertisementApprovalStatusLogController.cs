using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementApprovalStatusLogController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementApprovalStatusLogLoadByEnterpriseHQAccNoAdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementApprovalStatusLogModel> data = new List<AdvertisementApprovalStatusLogModel>();
            try
            {
                data = AdvertisementApprovalStatusLogModel.AdvertisementApprovalStatusLog_LoadBy_EnterpriseHQAccNo_AdvertisementCode(EnterpriseHQAccNo, AdvertisementCode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

    }
}