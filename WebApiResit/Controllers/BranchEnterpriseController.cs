using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class BranchEnterpriseController : Controller
    {

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult BranchEnterpriseLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<BranchEnterpriseModel> data = new List<BranchEnterpriseModel>();
            try
            {
                data = BranchEnterpriseModel.BranchEnterprise_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult BranchEnterpriseLoadByBranchEnterpriseAccNo(string BranchEnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<BranchEnterpriseModel> data = new List<BranchEnterpriseModel>();
            try
            {
                data = BranchEnterpriseModel.BranchEnterprise_LoadByBranchEnterpriseAccNo(BranchEnterpriseAccNo);
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
        public JsonResult BranchEnterpriseInsertUpdate(int ID, string EnterpriseAccNo, string BranchEnterpriseAccNo, string EnterpriseName, string EnterpriseAddress, string EnterprisePhoneNo
            , string EnterpriseRegistrationNo, string EnterpriseEmail, string EnterpriseWebsite, string EnterpriseFacebook, string EnterpriseTwiter
            , string EnterpriseInstagram, string EnterpriseCoordinate, string EnterpriseLogoPath, string RowStatus, string CreatedBy
            , string isFeedBackFormEnabled, string PICContactNo, string PersonInCharge, string LoyaltyCardType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<BranchEnterpriseModel> data = new List<BranchEnterpriseModel>();
            try
            {
                success = BranchEnterpriseModel.BranchEnterprise_InsertUpdate( ID,  EnterpriseAccNo,  BranchEnterpriseAccNo,  EnterpriseName,  EnterpriseAddress,  EnterprisePhoneNo
            ,  EnterpriseRegistrationNo,  EnterpriseEmail,  EnterpriseWebsite,  EnterpriseFacebook,  EnterpriseTwiter
            ,  EnterpriseInstagram,  EnterpriseCoordinate,  EnterpriseLogoPath,  RowStatus,  CreatedBy
            ,  isFeedBackFormEnabled,  PICContactNo,  PersonInCharge,  LoyaltyCardType);
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