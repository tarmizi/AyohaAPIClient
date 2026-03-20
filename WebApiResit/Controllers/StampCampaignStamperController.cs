using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class StampCampaignStamperController : Controller
    {

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCampaignStamperInsertUpdate([System.Web.Http.FromBody] StampCampaignStamperModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<StampCampaignStamperModel> data = new List<StampCampaignStamperModel>();
            try
            {
                success = StampCampaignStamperModel.StampCampaignStamper_InsertUpdate(SC.ID,SC.AccountName,SC.AccountNo, SC.StampCampaignCode,SC.UserType, SC.CreatedBy, SC.RowStatus);
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
        public JsonResult StampCampaignStamperDelete([System.Web.Http.FromBody] StampCampaignStamperModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<StampCampaignStamperModel> data = new List<StampCampaignStamperModel>();
            try
            {
                success = StampCampaignStamperModel.StampCampaignStamper_Delete(SC.ID, SC.StampCampaignCode, SC.CreatedBy);
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
        public JsonResult StampCampaignStamperLoadByStampCampaignCode(string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignStamperModel> data = new List<StampCampaignStamperModel>();
            try
            {
                data = StampCampaignStamperModel.StampCampaignStamper_LoadByStampCampaignCode(StampCampaignCode);
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