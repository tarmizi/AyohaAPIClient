using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MerchantLoyaltyCampaignController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantLoyaltyCampaign_LoadPoint([System.Web.Http.FromBody] MerchantLoyaltyCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantLoyaltyCampaignModel> data = new List<MerchantLoyaltyCampaignModel>();
            try
            {
                data = MerchantLoyaltyCampaignModel.MerchantLoyaltyCampaign_LoadPoint(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantLoyaltyCampaign_LoadDiscount([System.Web.Http.FromBody] MerchantLoyaltyCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantLoyaltyCampaignModel> data = new List<MerchantLoyaltyCampaignModel>();
            try
            {
                data = MerchantLoyaltyCampaignModel.MerchantLoyaltyCampaign_LoadDiscount(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantLoyaltyCampaign_LoadContest([System.Web.Http.FromBody] MerchantLoyaltyCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantLoyaltyCampaignModel> data = new List<MerchantLoyaltyCampaignModel>();
            try
            {
                data = MerchantLoyaltyCampaignModel.MerchantLoyaltyCampaign_LoadContest(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantLoyaltyCampaign_LoadEvent([System.Web.Http.FromBody] MerchantLoyaltyCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantLoyaltyCampaignModel> data = new List<MerchantLoyaltyCampaignModel>();
            try
            {
                data = MerchantLoyaltyCampaignModel.MerchantLoyaltyCampaign_LoadEvent(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
	}
}