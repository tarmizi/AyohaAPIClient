using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class AyohaMerchantReviewController : Controller
    {

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaMerchantReviewInsertUpdate([System.Web.Http.FromBody] AyohaMerchantReviewModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {
                
                success = AyohaMerchantReviewModel.AyohaMerchantReview_InsertUpdate(AM.ID,AM.ReviewCode,AM.SubscriberAccNo,AM.EnterpriseAccNo,AM.StarReview,AM.ReviewText,AM.RowStatusMerchant,AM.RowStatusAyoha,AM.ItemCodeReview);
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
        public JsonResult AyohaMerchantReviewLoadByEnterpriseAccNo(string EnterpriseAccNo, string ItemCodeReview)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {
                data = AyohaMerchantReviewModel.AyohaMerchantReview_LoadByEnterpriseAccNo(EnterpriseAccNo, ItemCodeReview);
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
        public JsonResult AyohaMerchantReviewLoadByEnterpriseAccNoAndItemCodeReviewMembershipCardSale([System.Web.Http.FromBody] AyohaMerchantReviewModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {

                data = AyohaMerchantReviewModel.AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview_MembershipCardSale(AM.EnterpriseAccNo,AM.ItemCodeReview);
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
        public JsonResult AyohaMerchantReviewLoadByEnterpriseAccNoAndItemCodeReview(string EnterpriseAccNo, string ItemCodeReview)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {
                data = AyohaMerchantReviewModel.AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview(EnterpriseAccNo, ItemCodeReview);
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
        public JsonResult AyohaMerchantReviewCalculateRating([System.Web.Http.FromBody] AyohaMerchantReviewModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {

                data = AyohaMerchantReviewModel.AyohaMerchantReview_CalculateRating(AM.EnterpriseAccNo);
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
        public JsonResult AyohaMerchantReviewCalculateRatingSaleItemDetail([System.Web.Http.FromBody] AyohaMerchantReviewModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaMerchantReviewModel> data = new List<AyohaMerchantReviewModel>();
            try
            {

                data = AyohaMerchantReviewModel.AyohaMerchantReview_CalculateRating_SaleItemDetail(AM.EnterpriseAccNo,AM.ItemCodeReview);
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