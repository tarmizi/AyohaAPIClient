using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardContestController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestLoadActive(string RowStatus)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.AyohaRewardContest_LoadActive(RowStatus);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestLoadBySubscriberAccNo([System.Web.Http.FromBody] AyohaRewardContestModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.AyohaRewardContest_LoadBySubscriberAccNo(AM.SubscriberAccNo);
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
        public JsonResult ContestCampaignRedeem_LoadByContestRedeemStatus([System.Web.Http.FromBody] AyohaRewardContestModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.ContestCampaignRedeemLoadByContestRedeemStatus(AM.SubscriberAccNo,AM.RedeemStatus);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestLoadBySubscriberAccNoAndContestCode(string SubscriberAccNo,string ContestCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.AyohaRewardContest_LoadBySubscriberAccNoAndContestCode(SubscriberAccNo, ContestCode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestLoadBySubscriberAccNoEnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.AyohaRewardContest_LoadBySubscriberAccNo_EnterpriseAccNo(SubscriberAccNo, EnterpriseAccNo);
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