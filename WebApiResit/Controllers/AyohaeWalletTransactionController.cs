using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaeWalletTransactionController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoLatestTransactions(string eWalletAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {
                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransactions(eWalletAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
     //   [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_TransactionReferenceNo([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_TransactionReferenceNo(AM.eWalletAccNo, AM.TransactionReferenceNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        //   [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_billExternalNo([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_billExternalNo(AM.eWalletAccNo, AM.billExternalNo);
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
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoLatestTransferTransactions(string eWalletAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {
                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransferTransactions(eWalletAccNo);
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
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoRecentlyTransferTo(string eWalletAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {
                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_RecentlyTransferTo(eWalletAccNo);
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
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoFilterType(string FilterType, string eWalletAccNo, string Year, string TransactionType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {
                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType(FilterType,eWalletAccNo,Year,TransactionType);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        //   [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoFilterTypeAllTransaction([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType_AllTransaction(AM.FilterType, AM.eWalletAccNo, AM.Year, AM.TransactionType);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        //   [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult DiscountCampaignRedeemLoadByDiscountRedeemStatus_OnlineOffline([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                data = AyohaeWalletTransactionModel.DiscountCampaignRedeemLoadByDiscountRedeemStatus_OnlineOffline(AM.SubscriberAccNo, AM.RedeemStatus);
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
        public JsonResult AyohaeWalletTransactionLoadByeWalletAccNoDebitCredit(string eWalletAccNo, string CreditDebitType)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {
                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_DebitCredit(eWalletAccNo,CreditDebitType);
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
        public JsonResult AyohaeWalletTransactionInsertTransferEwallet([System.Web.Http.FromBody] AyohaeWalletTransactionTransferEwalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
          
            List<AyohaeWalletTransactionTransferEwalletModel> data = new List<AyohaeWalletTransactionTransferEwalletModel>();
            try
            {

                success = AyohaeWalletTransactionTransferEwalletModel.AyohaeWalletTransaction_Insert_TransferEwallet(AM.eWalletAccNo_Credit,AM.TransactionType_Credit,AM.TransactionAmount_Credit,AM.TransactionReferenceNo_Credit,AM.TransactionStatus_Credit,AM.TransactionNote_Credit,
          AM.CreditDebitType_Credit,AM.CustomerAccNo_Credit,AM.Email_Credit,AM.eWalletAccNo_Debit,AM.TransactionType_Debit,AM.TransactionAmount_Debit,AM.TransactionReferenceNo_Debit,AM.TransactionStatus_Debit,
          AM.TransactionNote_Debit, AM.CreditDebitType_Debit, AM.CustomerAccNo_Debit, AM.Email_Debit, AM.PlayerID_Credit, AM.AyohaeWalletTransactionTransactionType);
               
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
        public JsonResult AyohaeWalletTransactionPaymentInsert([System.Web.Http.FromBody] AyohaeWalletTransactionTransferEwalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionTransferEwalletModel> data = new List<AyohaeWalletTransactionTransferEwalletModel>();
            try
            {

                success = AyohaeWalletTransactionTransferEwalletModel.AyohaeWalletTransaction_Payment_Insert(AM.OrderNo, AM.SubscriberAccNo, AM.EnterpriseAccNo, AM.GrandTotal, AM.PaymentAmount, AM.PaymentMethod,
           AM.PaymentMethodCode, AM.CreatedBy, AM.MembershipCardCode, AM.PaymentStatus, AM.NoteToSeller, AM.MerchantPoint, AM.AyohaPoint, AM.eWalletAccNo_Credit, AM.TransactionType_Credit, AM.TransactionAmount_Credit, AM.TransactionReferenceNo_Credit, AM.TransactionStatus_Credit, AM.TransactionNote_Credit,
          AM.CreditDebitType_Credit, AM.CustomerAccNo_Credit, AM.Email_Credit, AM.eWalletAccNo_Debit, AM.TransactionType_Debit, AM.TransactionAmount_Debit, AM.TransactionReferenceNo_Debit, AM.TransactionStatus_Debit,
          AM.TransactionNote_Debit, AM.CreditDebitType_Debit, AM.CustomerAccNo_Debit, AM.Email_Debit,AM.Points);
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
        public JsonResult AyohaeWalletTransaction_LoadBy_eWalletAccNo_TransactionReferenceNo([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                data = AyohaeWalletTransactionModel.AyohaeWalletTransaction_LoadBy_eWalletAccNo_TransactionReferenceNo(AM.eWalletAccNo, AM.TransactionReferenceNo);
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
        public JsonResult AyohaeWalletTransactionInsertRequestCashOut([System.Web.Http.FromBody] AyohaeWalletTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;

            List<AyohaeWalletTransactionModel> data = new List<AyohaeWalletTransactionModel>();
            try
            {

                success = AyohaeWalletTransactionModel.AyohaeWalletTransaction_InsertRequestCashOut(AM.eWalletAccNo, AM.TransactionType, AM.TransactionAmount, AM.TransactionReferenceNo, AM.TransactionStatus, AM.TransactionNote,
          AM.CreditDebitType, AM.CustomerAccNo, AM.CashOutCharge, AM.CashOutPercentageCharge, AM.TotalCashOutAmount);

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