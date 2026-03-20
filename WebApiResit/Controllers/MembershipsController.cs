using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MembershipsController : Controller
    {
        // GET: Memberships
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipsInsert([System.Web.Http.FromBody] MembershipsModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
               
             success = MembershipsModel.Memberships_Insert(I.CampaignEnterpriseAccNo, I.SubscriberAccNo,
            I.MembershipByMethod, I.ReferalSubscriberAccNo, I.MembershipCardCode, I.CreatedBy);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
       // [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipsInsertPayAtCounter([System.Web.Http.FromBody] MembershipsModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {

                success = MembershipsModel.Memberships_Insert_PayAtCounter(I.CampaignEnterpriseAccNo, I.SubscriberAccNo,
               I.MembershipByMethod, I.ReferalSubscriberAccNo, I.MembershipCardCode, I.CreatedBy, I.SubscriptionCode, I.SubscribedPackage, I.PackagePrice);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
      //  [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipsInsertMembershipCardFOCFee([System.Web.Http.FromBody] MembershipsModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {

                success = MembershipsModel.Memberships_Insert_MembershipCardFOCFee(I.CampaignEnterpriseAccNo, I.SubscriberAccNo,
               I.MembershipByMethod, I.ReferalSubscriberAccNo, I.MembershipCardCode, I.CreatedBy, I.SubscriptionCode, I.SubscribedPackage, I.PackagePrice);
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
        public JsonResult MembershipsDelete([System.Web.Http.FromBody] MembershipsModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {

                success = MembershipsModel.Memberships_Delete(I.ID, I.SubscriberAccNo,I.MembershipCardCode, I.CreatedBy);
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
        public JsonResult MembershipsLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_LoadBySubscriberAccNo(SubscriberAccNo);
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
        public JsonResult MembershipsLoadBySubscriberAccNoAndEnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_LoadBySubscriberAccNoAndEnterpriseAccNo(SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult MembershipsLoadBySubscriberAccNoAndEnterpriseAccNoAndMembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_LoadBySubscriberAccNoAndEnterpriseAccNoAndMembershipCardCode(SubscriberAccNo, EnterpriseAccNo, MembershipCardCode);
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
        public JsonResult MembershipsLoadByCampaignCode(string CampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_LoadByCampaignCode(CampaignCode);
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
        public JsonResult MembershipsCheckIsMember(string CampaignCode, string SubscriberAccNo, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_CheckIsMember(CampaignCode, SubscriberAccNo, EnterpriseAccNo);
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
        public JsonResult MembershipsCheckIsMemberScanAndPay(string SubscriberAccNo, string CampaignEnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_CheckIsMember_ScanAndPay(SubscriberAccNo,CampaignEnterpriseAccNo);
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
        public JsonResult Memberships_MyMembershipCardStatus([System.Web.Http.FromBody] MembershipsModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipsModel> data = new List<MembershipsModel>();
            try
            {
                data = MembershipsModel.Memberships_MyMembershipCardStatus(AC.SubscriberAccNo);
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