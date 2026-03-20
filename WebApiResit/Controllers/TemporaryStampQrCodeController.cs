using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class TemporaryStampQrCodeController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult TemporaryStampQrCodeGenerateTempQrCode(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<TemporaryStampQrCodeModel> data = new List<TemporaryStampQrCodeModel>();
            try
            {
                data = TemporaryStampQrCodeModel.TemporaryStampQrCode_GenerateTempQrCode(StampCampaignCode, EnterpriseAccNo, SubscriberAccNo);
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