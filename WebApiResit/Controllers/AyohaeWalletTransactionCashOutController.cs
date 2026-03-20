using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaeWalletTransactionCashOutController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletTransactionCashOutLoadByTransactionReferenceNo([System.Web.Http.FromBody] AyohaeWalletTransactionCashOutModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionCashOutModel> data = new List<AyohaeWalletTransactionCashOutModel>();
            try
            {

                data = AyohaeWalletTransactionCashOutModel.AyohaeWalletTransaction_CashOut_LoadByTransactionReferenceNo(AM.TransactionReferenceNo);
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
        public JsonResult AyohaeWalletTransactionCashOutLoadByID([System.Web.Http.FromBody] AyohaeWalletTransactionCashOutModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionCashOutModel> data = new List<AyohaeWalletTransactionCashOutModel>();
            try
            {

                data = AyohaeWalletTransactionCashOutModel.AyohaeWalletTransaction_CashOut_LoadByID(AM.ID);
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