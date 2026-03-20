using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class PointCampaignRedeemItemSettingController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PointCampaignRedeemInsertUpdate([System.Web.Http.FromBody] PointCampaignRedeemItemSettingModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignRedeemItemSettingModel> data = new List<PointCampaignRedeemItemSettingModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = PointCampaignRedeemItemSettingModel.PointCampaignRedeem_InsertUpdate(EE.ID, EE.Img64, EE.AyohaUserGroupCode, EE.ItemName,
            EE.ItemCode, EE.ItemPoint, EE.ItemImg, EE.RowStatus, EE.CreatedBy, EE.Remarks, EE.ItemPrizePriceCost, EE.AyohaUserGroupCategory,EE.PointCampaignCode,EE.EnterpriseAccNo);
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
        public JsonResult PointCampaignRedeemLoadByPointCampaignCode(string PointCampaignCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<PointCampaignRedeemItemSettingModel> data = new List<PointCampaignRedeemItemSettingModel>();
            try
            {
                data = PointCampaignRedeemItemSettingModel.PointCampaignRedeem_LoadByPointCampaignCode(PointCampaignCode, EnterpriseAccNo);
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
        public JsonResult PointCampaignRedeemLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<PointCampaignRedeemItemSettingModel> data = new List<PointCampaignRedeemItemSettingModel>();
            try
            {
                data = PointCampaignRedeemItemSettingModel.PointCampaignRedeem_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult PointCampaignRedeemLoadByPointRedeemStatus([System.Web.Http.FromBody] PointCampaignRedeemItemSettingModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignRedeemItemSettingModel> data = new List<PointCampaignRedeemItemSettingModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                data = PointCampaignRedeemItemSettingModel.PointCampaignRedeem_LoadByPointRedeemStatus(EE.SubscriberAccNo, EE.RedeemPointStatus);
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