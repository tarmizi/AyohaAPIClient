using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class MembershipCardTermsController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardTermsInsert([System.Web.Http.FromBody] MembershipCardTermsModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardTermsModel> data = new List<MembershipCardTermsModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = MembershipCardTermsModel.MembershipCardTerms_Insert(EE.EnterpriseAccNo, EE.MembershipCardCode, EE.TermAndConditions, EE.CreatedBy);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




       
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardTermsUpdateTermsStatus([System.Web.Http.FromBody] MembershipCardTermsModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardTermsModel> data = new List<MembershipCardTermsModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = MembershipCardTermsModel.MembershipCardTerms_UpdateTermsStatus(EE.MembershipCardCode, EE.EnterpriseAccNo, EE.TermsStatus, EE.CreatedBy,EE.TermAndConditions);
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
        public JsonResult MembershipCardTermsLoadByMembershipCardCode(string MembershipCardCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardTermsModel> data = new List<MembershipCardTermsModel>();
            try
            {
                data = MembershipCardTermsModel.MembershipCardTerms_LoadByMembershipCardCode(MembershipCardCode, EnterpriseAccNo);
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
        public JsonResult MembershipCardTermsLoadByMembershipCardCodePostStyle([System.Web.Http.FromBody] MembershipCardTermsModel MT)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardTermsModel> data = new List<MembershipCardTermsModel>();
            try
            {

                data = MembershipCardTermsModel.MembershipCardTerms_LoadByMembershipCardCode(MT.MembershipCardCode,MT.EnterpriseAccNo);
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