using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class LoyaltyCardBackgroundImageController : Controller
    {
        // GET: LoyaltyCardBackgroundImage
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyCardBackgroundImageLoadByEnterpriseAccNoStampCampaignCode(string EnterpriseAccNo, string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyCardBackgroundImageModel> data = new List<LoyaltyCardBackgroundImageModel>();
            try
            {
                data = LoyaltyCardBackgroundImageModel.LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode(EnterpriseAccNo, StampCampaignCode);
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
        public JsonResult LoyaltyCardBackgroundImageLoadByEnterpriseAccNoStampCampaignCodeBackgroundImageAnim(string EnterpriseAccNo, string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyCardBackgroundImageModel> data = new List<LoyaltyCardBackgroundImageModel>();
            try
            {
                data = LoyaltyCardBackgroundImageModel.LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode_BackgroundImageAnim(EnterpriseAccNo, StampCampaignCode);
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
        public JsonResult StampCardUploadContentCardImg([System.Web.Http.FromBody] LoyaltyCardBackgroundImageModel CC)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyCardBackgroundImageModel> data = new List<LoyaltyCardBackgroundImageModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = LoyaltyCardBackgroundImageModel.LoyaltyCardBackgroundImage_InsertUpdate(CC.ID, CC.EnterpriseAccNo, CC.StampCampaignCode, CC.ImgName, CC.ImgPath, CC.RowStatus, CC.CreatedBy, CC.ImageBase64,CC.ShowHide);
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