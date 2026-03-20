using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class MerchantRewardController : Controller
    {
        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult MerchantRewardPerksSummary([System.Web.Http.FromBody] MerchantRewardModel AC)
        //{
        //    string success = "true";
        //    string _Message = string.Empty;
        //    List<MerchantRewardModel> data = new List<MerchantRewardModel>();
        //    try
        //    {
        //        data = MerchantRewardModel.MerchantReward_PerksSummary(AC.SubscriberAccNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = "false";
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MerchantRewardPerks_RedeemJoinedApproved([System.Web.Http.FromBody] MerchantRewardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantRewardModel> data = new List<MerchantRewardModel>();
            try
            {
                data = MerchantRewardModel.MerchantReward_Perks_RedeemJoinedApproved(AC.SubscriberAccNo);
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
        public JsonResult MerchantReward_Perks_DashboardData([System.Web.Http.FromBody] MerchantRewardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantRewardModel> data = new List<MerchantRewardModel>();
            try
            {
                data = MerchantRewardModel.MerchantReward_Perks_DashboardData(AC.SubscriberAccNo);
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