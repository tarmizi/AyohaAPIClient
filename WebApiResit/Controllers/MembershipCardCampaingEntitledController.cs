using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class MembershipCardCampaingEntitledController : Controller
    {

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardCampaingEntitledInsertUpdate([System.Web.Http.FromBody] MembershipCardCampaingEntitledModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardCampaingEntitledModel> data = new List<MembershipCardCampaingEntitledModel>();
            try
            {
                success = MembershipCardCampaingEntitledModel.MembershipCardCampaingEntitled_InsertUpdate(I.ID, I.CampaignCode, I.EnterpriseHQAccNo,
            I.EnterpriseAccNo, I.MembershipCardCode, I.CreatedBy, I.RowStatus, I.CampaignType);
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
        public JsonResult MembershipCardCampaingEntitledLoadByMembershipCardCode(string MembershipCardCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardCampaingEntitledModel> data = new List<MembershipCardCampaingEntitledModel>();
            try
            {
                data = MembershipCardCampaingEntitledModel.MembershipCardCampaingEntitled_LoadByMembershipCardCode(MembershipCardCode, SubscriberAccNo);
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
        public JsonResult MembershipCardCampaingEntitledLoadByEnterpriseAccNoMerchantDetailPage(string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardCampaingEntitledModel> data = new List<MembershipCardCampaingEntitledModel>();
            try
            {
                data = MembershipCardCampaingEntitledModel.MembershipCardCampaingEntitled_LoadByEnterpriseAccNo_MerchantDetailPage(EnterpriseAccNo, SubscriberAccNo);
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
        public JsonResult MembershipCardCampaingEntitledMerchantLoadByMembershipCardCode(string MembershipCardCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardCampaingEntitledModel> data = new List<MembershipCardCampaingEntitledModel>();
            try
            {
                data = MembershipCardCampaingEntitledModel.MembershipCardCampaingEntitled_MerchantLoadByMembershipCardCode(MembershipCardCode, EnterpriseAccNo);
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
        public JsonResult MembershipCardCampaingEntitledDelete([System.Web.Http.FromBody] MembershipCardCampaingEntitledModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardCampaingEntitledModel> data = new List<MembershipCardCampaingEntitledModel>();
            try
            {
                success = MembershipCardCampaingEntitledModel.MembershipCardCampaingEntitled_Delete(I.ID,I.CreatedBy);
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