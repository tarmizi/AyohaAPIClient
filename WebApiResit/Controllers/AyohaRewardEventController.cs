using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaRewardEventController : Controller
    {


        //[HttpGet]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult AyohaRewardEventLoadBySubscriberAccNo(string SubscriberAccNo)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
        //    try
        //    {
        //        data = AyohaRewardEventModel.AyohaRewardEvent_LoadBySubscriberAccNo(SubscriberAccNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = false;
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}






          [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardEventLoadBySubscriberAccNo([System.Web.Http.FromBody] AyohaRewardEventModel AM)
              
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
            try
            {
                data = AyohaRewardEventModel.AyohaRewardEvent_LoadBySubscriberAccNo(AM.SubscriberAccNo);
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
          public JsonResult EventCampaignRedeemLoadByEventRedeemStatus([System.Web.Http.FromBody] AyohaRewardEventModel AM)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
              try
              {
                  data = AyohaRewardEventModel.EventCampaignRedeemLoadByEventRedeemStatus(AM.SubscriberAccNo,AM.RedeemStatus);
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
        public JsonResult AyohaRewardEventLoadBySubscriberAccNoEnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
            try
            {
                data = AyohaRewardEventModel.AyohaRewardEvent_LoadBySubscriberAccNo_EnterpriseAccNo(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult AyohaRewardEventLoadBySubscriberAccNoAndEventCode([System.Web.Http.FromBody] AyohaRewardEventModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
            try
            {

                data = AyohaRewardEventModel.AyohaRewardEvent_LoadBySubscriberAccNoAndEventCode(AM.SubscriberAccNo, AM.EventCode);
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