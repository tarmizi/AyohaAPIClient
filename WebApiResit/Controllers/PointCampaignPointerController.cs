using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class PointCampaignPointerController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PointCampaignPointerInsertUpdate([System.Web.Http.FromBody] PointCampaignPointerModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignPointerModel> data = new List<PointCampaignPointerModel>();
            try
            {
                success = PointCampaignPointerModel.PointCampaignPointer_InsertUpdate(SC.ID, SC.AccountName, SC.AccountNo, SC.PointCampaignCode, SC.UserType, SC.CreatedBy, SC.RowStatus);
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
        //public JsonResult StampCampaignEnterprisesInsertUpdate(int ID, string EnterpriseAccNo, string StampCampaignCode, string CreatedBy, string RowStatus)
        public JsonResult PointCampaignPointerDelete([System.Web.Http.FromBody] PointCampaignPointerModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PointCampaignPointerModel> data = new List<PointCampaignPointerModel>();
            try
            {
                success = PointCampaignPointerModel.PointCampaignPointer_Delete(SC.ID, SC.PointCampaignCode, SC.CreatedBy);
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
        public JsonResult PointCampaignPointerLoadByPointCampaignCode(string PointCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<PointCampaignPointerModel> data = new List<PointCampaignPointerModel>();
            try
            {
                data = PointCampaignPointerModel.PointCampaignPointer_LoadByPointCampaignCode(PointCampaignCode);
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