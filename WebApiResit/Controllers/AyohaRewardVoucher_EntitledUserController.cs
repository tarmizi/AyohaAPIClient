using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardVoucher_EntitledUserController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoVoucherType(string SubscriberAccNo, string VoucherType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType(SubscriberAccNo,VoucherType);
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
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoVoucherTypeVoucherHistory(string SubscriberAccNo, string VoucherType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType_VoucherHistory(SubscriberAccNo, VoucherType);
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
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoMerchantRewardVoucherHistory(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward_VoucherHistory(SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


      [ HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoMerchantReward([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward(V.SubscriberAccNo, V.VoucherType);
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
        public JsonResult VoucherCampaignRedeemLoadByVoucherRedeemStatus([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.VoucherCampaignRedeemLoadByVoucherRedeemStatus(V.SubscriberAccNo, V.RedeemStatus);
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
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoAyohaStoreVoucherHistory(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_AyohaStore_VoucherHistory(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MembershipCard(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MembershipCard(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantLoyaltyCampaign(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantLoyaltyCampaign(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoPaymentNoEntitledVoucherStatus(string SubscriberAccNo, string PaymentNo, string EntitledVoucherStatus, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_PaymentNo_EntitledVoucherStatus(SubscriberAccNo, PaymentNo, EntitledVoucherStatus, EnterpriseAccNo);
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
        public JsonResult AyohaRewardVoucherEntitledUserLoadBySubscriberAccNoEnterpriseAccNoMembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo,string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode(SubscriberAccNo, EnterpriseAccNo, MembershipCardCode);
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
        public JsonResult AyohaRewardVoucherEntitledUserEntitledVoucherStatusTempLoadBySubscriberAccNoEnterpriseAccNoMembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {
                data = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode(SubscriberAccNo, EnterpriseAccNo, MembershipCardCode);
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
        public JsonResult AyohaRewardVoucherEntitledUserAyohaStoreCartUpdateVoucherStatus([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {

                success = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus(AM.VoucherCode, AM.SubscriberAccNo, AM.Count);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserEntitledVoucherStatusTempUpdateEntitledVoucherStatus([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {

                success = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_UpdateEntitledVoucherStatus(AM.SubscriberAccNo, AM.VoucherCode, AM.EntitledVoucherStatus, AM.Count);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserUpdateEntitledVoucherStatus([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {

                success = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_UpdateEntitledVoucherStatus(AM.SubscriberAccNo, AM.VoucherCode, AM.EntitledVoucherStatus, AM.Count);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserEntitledVoucherStatusTempAyohaStoreCartUpdateVoucherStatusSingleTap([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {

                success = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_AyohaStoreCart_UpdateVoucherStatus_SingleTap(AM.VoucherCode, AM.SubscriberAccNo, AM.EntitledVoucherStatus);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardVoucherEntitledUserAyohaStoreCartUpdateVoucherStatusSingleTap([System.Web.Http.FromBody] AyohaRewardVoucher_EntitledUserModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardVoucher_EntitledUserModel> data = new List<AyohaRewardVoucher_EntitledUserModel>();
            try
            {

                success = AyohaRewardVoucher_EntitledUserModel.AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus_SingleTap(AM.VoucherCode, AM.SubscriberAccNo, AM.EntitledVoucherStatus);
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