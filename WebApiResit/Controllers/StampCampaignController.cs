using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class StampCampaignController : Controller
    {

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCampaignLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                data = StampCampaignModel.StampCampaign_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult StampCampaignLoadByGetLoyaltyCard(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                data = StampCampaignModel.StampCampaign_LoadByGetLoyaltyCard(EnterpriseAccNo);
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
        public JsonResult StampCampaignLoadByStampCampaignCode(string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                data = StampCampaignModel.StampCampaign_LoadByStampCampaignCode(StampCampaignCode);
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
        public JsonResult StampCampaignDashboardAyohaUserLatestStamp(string SubscriberAccNo, string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                data = StampCampaignModel.StampCampaign_DashboardAyohaUser_LatestStamp(SubscriberAccNo, StampCampaignCode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult StampCampaignInsert(string StampCampaignName, string StampCardType, string StartDate, string EndDate, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy, string StampCardBackground)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<StampCampaignModel> data = new List<StampCampaignModel>();
        //    try
        //    {
        //        success = StampCampaignModel.StampCampaign_Insert( StampCampaignName,  StampCardType,  StartDate,  EndDate,  EnterpriseAccNo,  CreatedByAccNo,  CreatedBy,  StampCardBackground);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = false;
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCampaignInsert([System.Web.Http.FromBody] StampCampaignModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = StampCampaignModel.StampCampaign_Insert(EE.StampCampaignName, EE.StampCardType, EE.StartDate, EE.EndDate, EE.EnterpriseAccNo, EE.CreatedByAccNo
      , EE.CreatedBy, EE.StampCardBackground);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }





        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCampaignUpdate(string StampCampaignCode, string StampCampaignName, string StartDate, string EndDate, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy
            , string isAnimated, int AnimatedInterval, string RowStatus, string StampRuleRemarks, string isStampRulePopUp, string LoyaltyCustomerType,string strEndDate)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                success = StampCampaignModel.StampCampaign_Update( StampCampaignCode,  StampCampaignName,  StartDate,  EndDate,  EnterpriseAccNo,  CreatedByAccNo,  CreatedBy
            , isAnimated, AnimatedInterval, RowStatus, StampRuleRemarks, isStampRulePopUp, LoyaltyCustomerType, strEndDate);
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
        public JsonResult StampCampaignUpdateStampContent(string StampContentNo, string StampCampaignCode, string StampContent)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignModel> data = new List<StampCampaignModel>();
            try
            {
                success = StampCampaignModel.StampCampaign_UpdateStampContent(StampContentNo, StampCampaignCode, StampContent);
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