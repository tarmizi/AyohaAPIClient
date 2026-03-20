using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class DashboardAyohaUserController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult DashboardAyohaUserMain(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<DashboardAyohaUserModel> data = new List<DashboardAyohaUserModel>();
            try
            {
                data = DashboardAyohaUserModel.DashboardAyohaUser_Main(SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult DashboardAyohaUserMaingetAyohaPoint([System.Web.Http.FromBody] DashboardAyohaUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DashboardAyohaUserModel> data = new List<DashboardAyohaUserModel>();
            try
            {

                data = DashboardAyohaUserModel.DashboardAyohaUser_Main_getAyohaPoint(AM.SubscriberAccNo);
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
        public JsonResult DashBoardStampCardLoadByEnterpriseAccNo([System.Web.Http.FromBody] AyohaUserStampCardModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {

                data = AyohaUserStampCardModel.DashBoard_StampCardLoadByEnterpriseAccNo(AM.EnterpriseAccNo);
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
        public JsonResult DashboardStampCard_SuccessCheckIn_LoadStampCardPerk([System.Web.Http.FromBody] AyohaUserStampCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserStampCardModel> data = new List<AyohaUserStampCardModel>();
            try
            {
                data = AyohaUserStampCardModel.Dashboard_StampCard_SuccessCheckIn_LoadStampCardPerk(AC.EnterpriseAccNo,AC.SubscriberAccNo);
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
        public JsonResult DashboardPointCard_SuccessCheckIn_LoadPointCardPerk([System.Web.Http.FromBody] MerchantLoyaltyCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MerchantLoyaltyCampaignModel> data = new List<MerchantLoyaltyCampaignModel>();
            try
            {
                data = MerchantLoyaltyCampaignModel.Dashboard_PointCard_SuccessCheckIn_LoadPointCardPerk(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult DashboardVoucherCard_SuccessCheckIn_LoadVoucherPerk([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.Dashboard_VoucherCard_SuccessCheckIn_LoadVoucherPerk(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult DashboardContest_SuccessCheckIn_LoadContestPerk([System.Web.Http.FromBody] AyohaRewardContestModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestModel> data = new List<AyohaRewardContestModel>();
            try
            {
                data = AyohaRewardContestModel.Dashboard_Contest_SuccessCheckIn_LoadContestPerk(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult DashboardEvent_SuccessCheckIn_Load_EventPerk([System.Web.Http.FromBody] AyohaRewardEventModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardEventModel> data = new List<AyohaRewardEventModel>();
            try
            {
                data = AyohaRewardEventModel.Dashboard_Event_SuccessCheckIn_Load_EventPerk(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult DashboardDiscount_SuccessCheckIn_Load_DiscountPerk([System.Web.Http.FromBody] DiscountCampaignModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<DiscountCampaignModel> data = new List<DiscountCampaignModel>();
            try
            {
                data = DiscountCampaignModel.Dashboard_Discount_SuccessCheckIn_Load_DiscountPerk(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult DashboardSuccessCheckIn_LoadPerkCanEnjoyInfo([System.Web.Http.FromBody] SuccessCheckInModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SuccessCheckInModel> data = new List<SuccessCheckInModel>();
            try
            {
                data = SuccessCheckInModel.Dashboard_SuccessCheckIn_LoadPerkCanEnjoyInfo(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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