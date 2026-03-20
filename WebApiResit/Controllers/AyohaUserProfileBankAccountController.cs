using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaUserProfileBankAccountController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileBankAccountRequestCashOutLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfile_BankAccountModel> data = new List<AyohaUserProfile_BankAccountModel>();
            try
            {
                data = AyohaUserProfile_BankAccountModel.AyohaUserProfile_BankAccount_RequestCashOut_LoadBySubscriberAccNo(SubscriberAccNo);
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
        public JsonResult AyohaUserProfileBankAccountInsertUpdate([System.Web.Http.FromBody] AyohaUserProfile_BankAccountModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfile_BankAccountModel> data = new List<AyohaUserProfile_BankAccountModel>();
            try
            {
                success = AyohaUserProfile_BankAccountModel.AyohaUserProfile_BankAccount_InsertUpdate(AP.SubscriberAccNo, AP.BankAccountNo, AP.BankName,
            AP.BankAccountType, AP.BankAccountName);
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