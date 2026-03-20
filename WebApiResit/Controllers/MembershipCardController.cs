using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class MembershipCardController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardInsertUpdate([System.Web.Http.FromBody] MembershipCardModel MC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                success = MembershipCardModel.MembershipCard_InsertUpdate(MC.ID, MC.MembershipCardCode, MC.EnterpriseAccNo,
          MC.MembershipCardFee, MC.MembershipCardType,MC.ExpiredDate,MC.MembershipCardBackgroundImg, 
         MC.CreatedBy, MC.StartDate,MC.MembershipCardName,MC.MembershipCardFeePaymentCycle,MC.StrExpiredDate,
          MC.isValidLifeTime, MC.MembershipCardBackgroundImgName,MC.isRequiredApproval,
          MC.MembershipCardBackgroundImgName_back,MC.MembershipCardBackgroundImg_back);
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
        //public JsonResult MembershipCardLoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
        public JsonResult MembershipCardLoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo(EnterpriseAccNo, EnterpriseHQAccNo, AyohaUserAccountNo);
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
        //public JsonResult MembershipCardLoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
        public JsonResult MembershipCardLoadBySubscriberAccNoDashboardMain(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadBySubscriberAccNo_DashboardMain(SubscriberAccNo);
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
        public JsonResult MembershipCardLoadByEnterpriseAccNo_DashboardMain([System.Web.Http.FromBody] MembershipCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_DashboardMain(AC.EnterpriseAccNo,  AC.SubscriberAccNo);
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
        public JsonResult MembershipCard_LoadByEnterpriseAccNo_SubscriberAccNo_MembershipCardCode([System.Web.Http.FromBody] MembershipCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_SubscriberAccNo_MembershipCardCode(AC.EnterpriseAccNo, AC.SubscriberAccNo,AC.MembershipCardCode);
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
        public JsonResult MembershipCard_LoadBySubscriberAccNo_MembershipCardCode_EnterpriseAccNo([System.Web.Http.FromBody] MembershipCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadBySubscriberAccNo_MembershipCardCode_EnterpriseAccNo(AC.EnterpriseAccNo, AC.SubscriberAccNo,AC.MembershipCardCode);
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
        ////public JsonResult MembershipCardLoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
        //public JsonResult MembershipCard_LoadforCheck_In(string SubscriberAccNo)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<MembershipCardModel> data = new List<MembershipCardModel>();
        //    try
        //    {
        //        data = MembershipCardModel.MembershipCard_LoadforCheck_In(SubscriberAccNo);
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
        public JsonResult MembershipCard_LoadforCheck_In([System.Web.Http.FromBody] MembershipCardModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadforCheck_In(AC.SubscriberAccNo);
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
        public JsonResult MembershipCardAyohaUserMembershipCard(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)    
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_AyohaUserMembershipCard(EnterpriseAccNo, EnterpriseHQAccNo, AyohaUserAccountNo, MembershipCardCode);
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
        public JsonResult MembershipCardLoadByEnterpriseAccNoMembershipCardCode(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode(EnterpriseAccNo, EnterpriseHQAccNo, AyohaUserAccountNo, MembershipCardCode);
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
        public JsonResult MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode_MembershipCardSaleDetail([System.Web.Http.FromBody] MembershipCardModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {

                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode_MembershipCardSaleDetail(AM.EnterpriseAccNo, AM.MembershipCardCode);
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
        //public JsonResult MembershipCardLoadByEnterpriseAccNoMerchantVersion(string EnterpriseAccNo)
        //{
        //    bool success = true;
        //    string _Message = string.Empty;
        //    List<MembershipCardModel> data = new List<MembershipCardModel>();
        //    try
        //    {
        //        data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_MerchantVersion(EnterpriseAccNo);
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
        public JsonResult MembershipCardLoadByEnterpriseAccNoMerchantVersion(string EnterpriseAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                data = MembershipCardModel.MembershipCard_LoadByEnterpriseAccNo_MerchantVersion_extMembershipCardCode(EnterpriseAccNo,MembershipCardCode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
      //  [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardDelete([System.Web.Http.FromBody] MembershipCardModel MC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {
                success = MembershipCardModel.MembershipCard_Delete(MC.ID, MC.MembershipCardCode, MC.EnterpriseAccNo,
          MC.ModifiedBy);
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
        public JsonResult MembershipCardLoadByMembershipCardCode([System.Web.Http.FromBody] MembershipCardModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardModel> data = new List<MembershipCardModel>();
            try
            {

                data = MembershipCardModel.MembershipCard_LoadByMembershipCardCode(AM.MembershipCardCode,AM.SubscriberAccNo);
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