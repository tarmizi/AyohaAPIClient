using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MembershipCardEnterprisesEntitledController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardEnterprisesEntitledInsertUpdate([System.Web.Http.FromBody] MembershipCardEnterprisesEntitledModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardEnterprisesEntitledModel> data = new List<MembershipCardEnterprisesEntitledModel>();
            try
            {
                success = MembershipCardEnterprisesEntitledModel.MembershipCardEnterprisesEntitled_InsertUpdate(I.ID, I.CampaignCode, I.EnterpriseHQAccNo,
            I.EnterpriseAccNo, I.MembershipCardCode, I.CreatedBy, I.RowStatus);
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
        public JsonResult MembershipCardEnterprisesEntitledLoadByMembershipCardCode(string MembershipCardCode, string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardEnterprisesEntitledModel> data = new List<MembershipCardEnterprisesEntitledModel>();
            try
            {
                data = MembershipCardEnterprisesEntitledModel.MembershipCardEnterprisesEntitled_LoadByMembershipCardCode(MembershipCardCode, EnterpriseHQAccNo);
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
        public JsonResult MembershipCardEnterprisesEntitledDelete([System.Web.Http.FromBody] MembershipCardEnterprisesEntitledModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardEnterprisesEntitledModel> data = new List<MembershipCardEnterprisesEntitledModel>();
            try
            {
                success = MembershipCardEnterprisesEntitledModel.MembershipCardEnterprisesEntitled_Delete(I.ID, I.CreatedBy);
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