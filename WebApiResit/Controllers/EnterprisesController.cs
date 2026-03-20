using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class EnterprisesController : Controller
    {
     


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult Enterprises_LoadByEnterpriseAccNo([System.Web.Http.FromBody] EnterprisesModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseAccNo(AP.EnterpriseAccNo);
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
        public JsonResult EnterprisesLoadByEnterpriseAccNoScannedQR([System.Web.Http.FromBody] EnterprisesModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseAccNo_ScannedQR(AP.EnterpriseAccNo);
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
        public JsonResult EnterprisesLoadByRowStatus(string RowStatus)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByRowStatus(RowStatus);
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
        public JsonResult EnterprisesLoadAyohaMerchantList(string RowStatus, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadAyohaMerchantList(RowStatus, SubscriberAccNo);
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
        public JsonResult Enterprises_LoadLastCheckIn([System.Web.Http.FromBody] EnterprisesModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();

            try
            {
                data = EnterprisesModel.Enterprises_LoadLastCheckIn(V.EnterpriseAccNo, V.SubscriberAccNo);


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
        public JsonResult Enterprises_LoadRecentlyCheckIn([System.Web.Http.FromBody] EnterprisesModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();

            try
            {
                data = EnterprisesModel.Enterprises_LoadRecentlyCheckIn(V.SubscriberAccNo);


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
        public JsonResult EnterprisesLoadAyohaMerchantListbyEnterpriseBusinessType(string RowStatus, string SubscriberAccNo, string EnterpriseBusinessType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadAyohaMerchantList_byEnterpriseBusinessType(RowStatus, SubscriberAccNo, EnterpriseBusinessType);
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
        public JsonResult EnterprisesLoadByMerchantCategory(string Category,string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByMerchantCategory(Category, SubscriberAccNo);
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
        public JsonResult EnterprisesLoadByEnterpriseAccNoAndSubscriberAccNo(string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseAccNoAndSubscriberAccNo(EnterpriseAccNo, SubscriberAccNo);
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
        public JsonResult EnterprisesLoadByEnterpriseBusinessType(string EnterpriseBusinessType, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseBusinessType(EnterpriseBusinessType, SubscriberAccNo);
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
        public JsonResult EnterprisesDashboardSearchAyohaMerchantEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_DashboardSearchAyohaMerchantEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult EnterprisesLoadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_LoadByEnterpriseHQAccNo(EnterpriseHQAccNo);
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
        public JsonResult EnterprisesGetEnterprisesHQAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_GetEnterprisesHQAccNo(EnterpriseAccNo);
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
        public JsonResult EnterprisesContactUsLink(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                data = EnterprisesModel.Enterprises_ContactUsLink(EnterpriseHQAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


//        AyohaVersion: "Pro"
//CreatedBy: "Ianmizi"
//EnterpriseAccNo: 
//EnterpriseAddress: 
//EnterpriseBusinessType: "Restaurant"
//EnterpriseCoordinate: "103.0321556,3.15414551"
//EnterpriseDescriptions: "Others"
//EnterpriseEmail: "CC@CC.com.my"
//EnterpriseFacebook: "https://www.facebook.com/tarmizi.abdrahim.1"
//EnterpriseInstagram: "https://www.facebook.com/tarmizi.abdrahim.1"
//EnterpriseLogoImg64: "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGIA"
//EnterpriseLogoName: "AyohaStampCardPurple.png"
//EnterpriseLogoPath: "NA"
//EnterpriseName: "Community Coffee Sdn Bhd"
//EnterprisePhoneNo: 
//EnterpriseRegistrationNo: 
//EnterpriseTwiter: "https://www.facebook.com/tarmizi.abdrahim.1"
//EnterpriseType: "Head Quarters"
//EnterpriseWebsite: "https://www.facebook.com/tarmizi.abdrahim.1"
//ID: "30"
//LoyaltyCardType: "Stamp"
//PICContactNo: "011112457965"
//PersonInCharge: "Mr Rafiq"
//RowStatus: "Active"

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesInsertUpdate([System.Web.Http.FromBody] EnterprisesModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = EnterprisesModel.Enterprises_InsertUpdate(EE.ID,EE.EnterpriseHQAccNo, EE.EnterpriseAccNo, EE.EnterpriseName, EE.EnterpriseAddress, EE.EnterprisePhoneNo
      , EE.EnterpriseRegistrationNo, EE.EnterpriseEmail, EE.EnterpriseWebsite, EE.EnterpriseDescriptions, EE.EnterpriseFacebook, EE.EnterpriseTwiter
      , EE.EnterpriseInstagram, EE.EnterpriseCoordinate, EE.EnterpriseLogoPath, EE.EnterpriseLogoName, EE.RowStatus, EE.CreatedBy
     , EE.PICContactNo, EE.PersonInCharge, EE.LoyaltyCardType, EE.EnterpriseType, EE.EnterpriseBusinessType, EE.AyohaVersion, EE.EnterpriseLogoImg64, EE.BusinessTypeGroupCode, EE.MerchantLinkType, EE.BusinessMode);
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
        public JsonResult EnterprisesUpdateCountStar([System.Web.Http.FromBody] EnterprisesModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = EnterprisesModel.Enterprises_UpdateCountStar(EE.EnterpriseAccNo, EE.CountStar);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

     //    [HttpPost]
     //   [ValidateInput(false)]
     //   [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
     //   public JsonResult EnterprisesInsertUpdate([System.Web.Http.FromBody] EnterprisesModel EE)
     //   {
     //       // bool success = true;
     //       string _Message = string.Empty;
     //       string _Messages = string.Empty;
     //       List<EnterprisesModel> data = new List<EnterprisesModel>();
     //       try
     //       {
     //           // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

     //           _Messages = EnterprisesModel.Enterprises_InsertUpdate(30, "CRCom-71100", EE.EnterpriseName,"Petronas Wangsa Maju Sekysen 3,Jalan Genting Kelang,5215461 Ampang. Selangor Darul Ehsan","0133376958"
     // , "154565", EE.EnterpriseEmail, EE.EnterpriseWebsite, EE.EnterpriseDescriptions, EE.EnterpriseFacebook, EE.EnterpriseTwiter
     // , EE.EnterpriseInstagram, EE.EnterpriseCoordinate, EE.EnterpriseLogoPath, EE.EnterpriseLogoName, EE.RowStatus, EE.CreatedBy
     //, EE.PICContactNo, EE.PersonInCharge, EE.LoyaltyCardType, EE.EnterpriseType, EE.EnterpriseBusinessType, EE.AyohaVersion, EE.EnterpriseLogoImg64);
     //       }
     //       catch (Exception ex)
     //       {
     //           _Message = ex.Message;
     //           //   success = false;
     //       }

     //       return Json(new { success = _Messages, message = _Messages, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
     //   }


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesInsertUpdateModified(int ID,string EnterpriseHQAccNo, string EnterpriseAccNo, string EnterpriseName, string EnterpriseAddress, string EnterprisePhoneNo
      , string EnterpriseRegistrationNo, string EnterpriseEmail, string EnterpriseWebsite, string EnterpriseDescriptions, string EnterpriseFacebook, string EnterpriseTwiter
      , string EnterpriseInstagram, string EnterpriseCoordinate, string EnterpriseLogoPath, string EnterpriseLogoName, string RowStatus, string CreatedBy
     , string PICContactNo, string PersonInCharge, string LoyaltyCardType, string EnterpriseType, string EnterpriseBusinessType, string AyohaVersion, string EnterpriseLogoImg64, string BusinessTypeGroupCode, string MerchantLinkType, string BusinessMode)
        {
            // bool success = true;
            string _Message = string.Empty;
            string _Messages = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                _Messages = EnterprisesModel.Enterprises_InsertUpdate(ID,EnterpriseHQAccNo, EnterpriseAccNo, EnterpriseName,EnterpriseAddress, EnterprisePhoneNo
      , EnterpriseRegistrationNo, EnterpriseEmail, EnterpriseWebsite, EnterpriseDescriptions,EnterpriseFacebook, EnterpriseTwiter
      , EnterpriseInstagram, EnterpriseCoordinate,EnterpriseLogoPath,EnterpriseLogoName, RowStatus, CreatedBy
     , PICContactNo, PersonInCharge, LoyaltyCardType, EnterpriseType, EnterpriseBusinessType, AyohaVersion, EnterpriseLogoImg64, BusinessTypeGroupCode, MerchantLinkType, BusinessMode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = _Messages, message = _Messages, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

    }
}