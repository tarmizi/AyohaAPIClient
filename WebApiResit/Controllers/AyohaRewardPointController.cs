using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardPointController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardPointLoadBySubscriberAccNo(string SubscriberAccNo,string Year)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardPointModel> data = new List<AyohaRewardPointModel>();
            try
            {
                data = AyohaRewardPointModel.AyohaRewardPoint_LoadBySubscriberAccNo(SubscriberAccNo,Year);
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
        public JsonResult AyohaRewardPointLoadBySubscriberAccNoEnterpriseAccNoMCC(string AyohaUserAccNo, string EnterprisesAccNo, string MCC)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardPointModel> data = new List<AyohaRewardPointModel>();
            try
            {
                data = AyohaRewardPointModel.AyohaRewardPoint_LoadBySubscriberAccNoEnterpriseAccNoMCC(AyohaUserAccNo, EnterprisesAccNo, MCC);
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
        public JsonResult AyohaRewardPointRewardRanking(string RankingLevel, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardPointModel> data = new List<AyohaRewardPointModel>();
            try
            {
                data = AyohaRewardPointModel.AyohaRewardPoint_RewardRanking(RankingLevel, SubscriberAccNo);
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