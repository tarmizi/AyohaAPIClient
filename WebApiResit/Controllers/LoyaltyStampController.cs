using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class LoyaltyStampController : Controller
    {


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyStampInsertLog([System.Web.Http.FromBody] LoyaltyStampModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                success = LoyaltyStampModel.LoyaltyStamp_InsertLog(AP.SubscriberAccNo, AP.EnterpriseAccNo, AP.StampCode, AP.StampQrCode, AP.StampedBy, AP.StampedByPhoneModel,
           AP.StampedByUserAccNo, AP.StampedByPhoneSerialNo, AP.StampedByPhoneManufacturer, AP.StampedByPhonePlatform, AP.StampedByOneSignalID, AP.StampedByPhoneRawInfo,
           AP.StampedCampaignCode,AP.EnterpriseName,AP.PlayerID);
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
        public JsonResult LoyaltyStampInsert(string SubscriberAccNo, string EnterpriseAccNo, string StampCode, string StampQrCode, string StampedBy, string StampedByPhoneModel,
            string StampedByUserAccNo, string StampedByPhoneSerialNo, string StampedByPhoneManufacturer, string StampedByPhonePlatform, string StampedByOneSignalID, string StampedByPhoneRawInfo)
            
        {

            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                success = LoyaltyStampModel.LoyaltyStamp_Insert( SubscriberAccNo,  EnterpriseAccNo,  StampCode,  StampQrCode,  StampedBy,  StampedByPhoneModel,
             StampedByUserAccNo,  StampedByPhoneSerialNo,  StampedByPhoneManufacturer,  StampedByPhonePlatform,  StampedByOneSignalID,  StampedByPhoneRawInfo);
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
        public JsonResult LoyaltyStampLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult LoyaltyStampLoadByStampedByUserAccNoAndEnterpriseAccNo(string StampedByUserAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_LoadByStampedByUserAccNo_And_EnterpriseAccNo(StampedByUserAccNo,EnterpriseAccNo);
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
        public JsonResult LoyaltyStampLoadBySubscriberAccNoAndEnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult LoyaltyStampLoadBySubscriberAccNoAndEnterpriseAccNoHistory(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo_History(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult LoyaltyStampLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel. LoyaltyStamp_LoadBySubscriberAccNo(SubscriberAccNo);
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
        public JsonResult LoyaltyStampLoadBySubscriberAccNoAndMembershipCardCode(string SubscriberAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_LoadBySubscriberAccNoAndMembershipCardCode(SubscriberAccNo, MembershipCardCode);
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
        public JsonResult LoyaltyStampCheckExistingStampQrCode(string StampQrCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyStampModel> data = new List<LoyaltyStampModel>();
            try
            {
                data = LoyaltyStampModel.LoyaltyStamp_CheckExistingStampQrCode(StampQrCode);
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