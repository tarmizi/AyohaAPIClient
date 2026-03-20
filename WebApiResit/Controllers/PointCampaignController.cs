using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class PointCampaignController : Controller
    {


        //[HttpPost]
        //[ValidateInput(false)]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult PointCampaignInsertUpdate([System.Web.Http.FromBody] PointCampaignModel I)
        //{
        //    string success = "true";
        //    string _Message = string.Empty;
        //    List<PointCampaignModel> data = new List<PointCampaignModel>();
        //    try
        //    {
        //        success = PointCampaignModel.PointCampaign_InsertUpdate(I.ID, I.PointCampaignCode, I.PointCampaignName,
        //    I.StartDate, I.EndDate, I.StrEndDate, I.RowStatus, I.EnterpriseAccNo,I.CreatedByAccNo,I.CreatedBy,I.Remarks,I.PointCampaignPremiumQRCode);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = "false";
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}




        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PointCampaignInsert([System.Web.Http.FromBody] PointCampaignModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignModel> data = new List<PointCampaignModel>();
            try
            {
                success = PointCampaignModel.PointCampaign_Insert(I.PointCampaignName,I.StartDate, I.EndDate, I.StrEndDate, I.RowStatus, I.EnterpriseAccNo, I.CreatedByAccNo, I.CreatedBy, I.Remarks, I.PointCampaignPremiumQRCode,I.TermAndCondition);
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
        public JsonResult PointCampaignUpdate([System.Web.Http.FromBody] PointCampaignModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignModel> data = new List<PointCampaignModel>();
            try
            {
                success = PointCampaignModel.PointCampaign_Update(I.ID,I.PointCampaignCode,I.PointCampaignName, I.StartDate,I.EndDate,I.StrEndDate,I.RowStatus
, I.EnterpriseAccNo, I.CreatedByAccNo, I.CreatedBy, I.Remarks, I.PointCampaignPremiumQRCode, I.TermAndCondition, I.isPointRulePopUp, I.PointOption, I.PointAmountEquation, I.RequiredReceiptBillNo);
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
        public JsonResult PointCampaignLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<PointCampaignModel> data = new List<PointCampaignModel>();
            try
            {
                data = PointCampaignModel.PointCampaign_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult PointCampaignLoadByPointCampaignCode(string PointCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<PointCampaignModel> data = new List<PointCampaignModel>();
            try
            {
                data = PointCampaignModel.PointCampaign_LoadByPointCampaignCode(PointCampaignCode);
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