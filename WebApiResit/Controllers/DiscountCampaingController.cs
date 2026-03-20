using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class DiscountCampaingController : Controller
    {
        [HttpPost]
        
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult DiscountCampaingLoadByEnterpriseAccNoMembershipCardCode([System.Web.Http.FromBody] DiscountCampaignModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DiscountCampaignModel> data = new List<DiscountCampaignModel>();
            try
            {

                data = DiscountCampaignModel.DiscountCampaing_LoadByEnterpriseAccNoMembershipCardCode(AM.EnterpriseAccNo,AM.MembershipCardCode);
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
        public JsonResult DiscountCampaingLoadByDiscountCode([System.Web.Http.FromBody] DiscountCampaignModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DiscountCampaignModel> data = new List<DiscountCampaignModel>();
            try
            {

                data = DiscountCampaignModel.DiscountCampaingLoadByDiscountCode(AM.EnterpriseAccNo, AM.DiscountCode);
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
        public JsonResult DiscountCampaing_LoadBySubscriberAccNo([System.Web.Http.FromBody] DiscountCampaignModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DiscountCampaignModel> data = new List<DiscountCampaignModel>();
            try
            {

                data = DiscountCampaignModel.DiscountCampaing_LoadBySubscriberAccNo(AM.SubscriberAccNo);
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
        public JsonResult DiscountCampaignRedeem_LoadByDiscountRedeemStatus([System.Web.Http.FromBody] DiscountCampaignModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DiscountCampaignModel> data = new List<DiscountCampaignModel>();
            try
            {

                data = DiscountCampaignModel.DiscountCampaignRedeemLoadByDiscountRedeemStatus(AM.SubscriberAccNo,AM.RedeemStatus);
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