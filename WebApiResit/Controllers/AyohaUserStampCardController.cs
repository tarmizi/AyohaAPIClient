using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaUserStampCardController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserStampCardLoadByStampCampaignCodeEnterpriseAccNoShowHideSubscriberAccNo(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo(StampCampaignCode, EnterpriseAccNo, SubscriberAccNo);
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
        public JsonResult AyohaUserStampCardLoadByStampCampaignCodeEnterpriseAccNoShowHide(string StampCampaignCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide(StampCampaignCode, EnterpriseAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        //[HttpGet]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult AyohaUserStampCardLoadByStampCampaignCodeEnterpriseAccNoShowHideSubscriberAccNofromQrCode(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
        //    try
        //    {
        //        data = AyohaUserStampCardModel.AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo_fromQrCode(StampCampaignCode, EnterpriseAccNo, SubscriberAccNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = false;
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserStampCardLoadStampCardfromQrCode(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo_fromQrCode(StampCampaignCode, EnterpriseAccNo, SubscriberAccNo);
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
        public JsonResult AyohaUserStampCardLoadByStampCardCode(string TempStampQRCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_LoadBy_StampCardCode(TempStampQRCode);
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
        public JsonResult AyohaUserStampCardCheckStampedStatus(string TempStampQRCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_Check_StampedStatus(TempStampQRCode);
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
        public JsonResult AyohaUserStampCardNearestRedeemItem(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_NearestRedeemItem(SubscriberAccNo);
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
        public JsonResult AyohaUserDashBoardNearestRedeemItem(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserDashBoard_NearestRedeemItem(SubscriberAccNo);
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
        public JsonResult AyohaUserDashBoardNearestRedeemItemStampCard(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserDashBoard_NearestRedeemItem_StampCard(SubscriberAccNo);
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
        public JsonResult AyohaUserDashBoardStampCardLoadByStampedRedeemStatus([System.Web.Http.FromBody] AyohaUserStampCardModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {

                data = AyohaUserStampCardModel.AyohaUserDashBoard_StampCardLoadByStampedRedeemStatus(AM.SubscriberAccNo, AM.StampedRedeemStatus);
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
        public JsonResult AyohaUserDashBoardStampCardLoadByStampedRedeemExpired([System.Web.Http.FromBody] AyohaUserStampCardModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {

                data = AyohaUserStampCardModel.AyohaUserDashBoard_StampCardLoadByStampedRedeemExpired(AM.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        //[HttpGet]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult AyohaUserDashBoardNearestRedeemItemStampCard(string SubscriberAccNo)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
        //    try
        //    {
        //        data = AyohaUserStampCardModel.AyohaUserDashBoard_NearestRedeemItem_StampCard(SubscriberAccNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = false;
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserDashBoardNearestRedeemItemPointCard(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserDashBoard_NearestRedeemItem_PointCard(SubscriberAccNo);
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
        public JsonResult AyohaUserDashBoardNearestRedeemItemList(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserDashBoard_NearestRedeemItemList(SubscriberAccNo);
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
        public JsonResult AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp([System.Web.Http.FromBody] AyohaUserStampCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp([System.Web.Http.FromBody] AyohaUserStampCardModel AC)
        //{
        //    string success = "true";
        //    string _Message = string.Empty;

        //    // CHANGED HERE: Use the new AyohaStampCardGroupModel for your data list
        //    List<WebApiResit.Models.AyohaUserStampCardModel.AyohaStampCardGroupModel> data = new List<WebApiResit.Models.AyohaUserStampCardModel.AyohaStampCardGroupModel>();

        //    try
        //    {
        //        // This method now correctly returns List<AyohaStampCardGroupModel>
        //        data = AyohaUserStampCardModel.AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp(AC.SubscriberAccNo);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = "false";
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}

    }
}