using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class LoyaltyPointController : Controller
    {

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointInsert([System.Web.Http.FromBody] LoyaltyPointModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = LoyaltyPointModel.LoyaltyPoint_Insert(EE.SubscriberAccNo,EE.EnterpriseAccNo,EE.PointCode,EE.PointQrCode,EE.PointedBy,EE.PointedByPhoneModel,EE.PointedByUserAccNo, EE.PointedByPhoneSerialNo,EE.PointedByPhoneManufacturer,
                    EE.PointedByPhonePlatform,EE.PointedByOneSignalID,EE.PointedByPhoneRawInfo,EE.CountsPoint,EE.PointCampaignCode,EE.Amount, EE.ReceiptBillID, EE.PointEquation,EE.TypeCRDB,EE.PointType,EE.EnterpriseName,EE.PlayerID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointInsertLooping([System.Web.Http.FromBody] LoyaltyPointModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = LoyaltyPointModel.LoyaltyPoint_InsertLooping(EE.SubscriberAccNo, EE.EnterpriseAccNo, EE.PointCode, EE.PointQrCode, EE.PointedBy, EE.PointedByPhoneModel, EE.PointedByUserAccNo, EE.PointedByPhoneSerialNo, EE.PointedByPhoneManufacturer,
                    EE.PointedByPhonePlatform, EE.PointedByOneSignalID, EE.PointedByPhoneRawInfo, EE.CountsPoint, EE.PointCampaignCode, EE.Amount, EE.ReceiptBillID, EE.PointEquation, EE.TypeCRDB, EE.PointType, EE.EnterpriseName, EE.PlayerID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointCreatePointCancelLooping([System.Web.Http.FromBody] LoyaltyPointModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = LoyaltyPointModel.LoyaltyPoint_CreatePoint_CancelLooping(EE.IDS, EE.ModifiedBy);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointLoadByPointCampaignCode(string PointCampaignCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                data = LoyaltyPointModel.LoyaltyPoint_LoadByPointCampaignCode(PointCampaignCode, SubscriberAccNo);
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
        public JsonResult LoyaltyPointLoadByEnterpriseAccNo(string EnterpriseAccNo, string Month, string Year)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                data = LoyaltyPointModel.LoyaltyPoint_LoadByEnterpriseAccNo(EnterpriseAccNo,Month,Year);
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
        public JsonResult LoyaltyPointDashboardAyohaUserLatestPoint(string SubscriberAccNo, string PointCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                data = LoyaltyPointModel.LoyaltyPoint_DashboardAyohaUser_LatestPoint(SubscriberAccNo,PointCampaignCode);
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
        public JsonResult LoyaltyPointLoadByPointCampaignCodeUser(string PointCampaignCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointModel> data = new List<LoyaltyPointModel>();
            try
            {
                data = LoyaltyPointModel.LoyaltyPoint_LoadByPointCampaignCode_User(PointCampaignCode, SubscriberAccNo);
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