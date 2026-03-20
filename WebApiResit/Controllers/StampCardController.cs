using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class StampCardController : Controller
    {



       


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCardUploadContentCardImg([System.Web.Http.FromBody] StampCardModel CC)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
               // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success=StampCardModel.StampCard_UpdateContentCardImage(CC.ID,CC.StampCampaignCode,CC.StampContent,CC.StampContentNote,CC.ContentCardImg,CC.EnterpriseAccNo,CC.ModifiedBy,CC.TextOne,CC.TextTwo,CC.ContentCardImgName,CC.isRedeemItem);
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
        public JsonResult StampCardLoadByStampCampaignCodeEnterpriseAccNo(string StampCampaignCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
                data = StampCardModel.StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo(StampCampaignCode, EnterpriseAccNo);
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
        public JsonResult StampCardLoadByStampCampaignCodeEnterpriseAccNoShowHide(string StampCampaignCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
                data = StampCardModel.StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide(StampCampaignCode, EnterpriseAccNo);
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
        public JsonResult StampCardInsert(string StampCardCode, string StampCampaignCode, string StampCardType, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
                success = StampCardModel.StampCard_Insert( StampCardCode,  StampCampaignCode,  StampCardType,  EnterpriseAccNo,  CreatedByAccNo,  CreatedBy);
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
        [ValidateInput(false)]
        public JsonResult StampCardUpdate(int ID, string StampCampaignCode, string StampContent, string StampContentNote, string EnterpriseAccNo, string ModifiedBy, string TextOne, string TextTwo,string isRedeemItem)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
                success = StampCardModel.StampCard_Update(ID, StampCampaignCode, StampContent, StampContentNote, EnterpriseAccNo, ModifiedBy, TextOne, TextTwo, isRedeemItem);
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
        public JsonResult StampCardUpdateShowHide(int ID, string StampCampaignCode, string EnterpriseAccNo, string ModifiedBy, string StampContentNote, string ShowHide)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCardModel> data = new List<StampCardModel>();
            try
            {
                success = StampCardModel.StampCard_UpdateShowHide(ID, StampCampaignCode, EnterpriseAccNo, ModifiedBy, StampContentNote, ShowHide);
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