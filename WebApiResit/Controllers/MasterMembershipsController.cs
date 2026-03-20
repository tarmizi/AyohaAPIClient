using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MasterMembershipsController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MasterMembershipsLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MasterMembershipsModel> data = new List<MasterMembershipsModel>();
            try
            {
                data = MasterMembershipsModel.MasterMemberships_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult MasterMembershipsDashboardApprovalStatusCount(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MasterMembershipsModel> data = new List<MasterMembershipsModel>();
            try
            {
                data = MasterMembershipsModel.MasterMemberships_DashboardApprovalStatusCount(EnterpriseHQAccNo);
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
        public JsonResult MasterMembershipsVerifiedSubscriber(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MasterMembershipsModel> data = new List<MasterMembershipsModel>();
            try
            {
                data = MasterMembershipsModel.MasterMemberships_VerifiedSubscriber(SubscriberAccNo,EnterpriseAccNo);
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
        public JsonResult MasterMembershipsUpdateStatusApproval([System.Web.Http.FromBody] MasterMembershipsModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MasterMembershipsModel> data = new List<MasterMembershipsModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = MasterMembershipsModel.MasterMemberships_UpdateStatusApproval(EE.ID, EE.EnterpriseHQAccNo, EE.SubscriberAccNo, EE.MembershipCardCode, EE.MembershipApprovalBy
            , EE.MembershipApprovalStatus, EE.Remarks, EE.ReceivedAmount, EE.MembershipPaymentPaidProofName, EE.MembershipPaymentPaidProof, EE.MembershipFeePaymentMethod);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
    }
}