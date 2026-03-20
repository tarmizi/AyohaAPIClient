using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class StampCampaignEnterprisesController : Controller
    {
        // GET: StampCampaignEnterprises
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult StampCampaignEnterprisesInsertUpdate(int ID, string EnterpriseAccNo, string StampCampaignCode, string CreatedBy, string RowStatus)
        public JsonResult StampCampaignEnterprisesInsertUpdate([System.Web.Http.FromBody] StampCampaignEnterprisesModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<StampCampaignEnterprisesModel> data = new List<StampCampaignEnterprisesModel>();
            try
            {
                success = StampCampaignEnterprisesModel.StampCampaignEnterprises_InsertUpdate(SC.ID, SC.EnterpriseAccNo, SC.StampCampaignCode, SC.CreatedBy, SC.RowStatus);
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
        public JsonResult StampCampaignEnterprisesDelete([System.Web.Http.FromBody] StampCampaignEnterprisesModel SC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<StampCampaignEnterprisesModel> data = new List<StampCampaignEnterprisesModel>();
            try
            {
                success = StampCampaignEnterprisesModel.StampCampaignEnterprises_Delete(SC.ID,SC.StampCampaignCode, SC.CreatedBy);
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
        public JsonResult StampCampaignEnterprisesLoadByEnterpriseAccNo(string EnterpriseAccNo, string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignEnterprisesModel> data = new List<StampCampaignEnterprisesModel>();
            try
            {
                data = StampCampaignEnterprisesModel.StampCampaignEnterprises_LoadByEnterpriseAccNo(EnterpriseAccNo, StampCampaignCode);
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
        public JsonResult StampCampaignEnterprisesLoadByStampCampaignCode(string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignEnterprisesModel> data = new List<StampCampaignEnterprisesModel>();
            try
            {
                data = StampCampaignEnterprisesModel.StampCampaignEnterprises_LoadByStampCampaignCode(StampCampaignCode);
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