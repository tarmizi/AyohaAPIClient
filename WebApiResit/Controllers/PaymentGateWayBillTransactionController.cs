using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace WebApiResit.Controllers
{
    public class PaymentGateWayBillTransactionController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PaymentGatewayCreateBilleWalletTopUp([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBillTransaction_Insert(AC.billName, AC.billDescription, AC.billTo, AC.billEmail, AC.billPhone, AC.billStatus, AC.billpaymentStatus,
             AC.billpaymentChannel,AC.billpaymentAmount,AC.billpaymentInvoiceNo,AC.billSplitPayment,AC.billSplitPaymentArgs,AC.billpaymentSettlement,
                 AC.billpaymentSettlementDate,AC.SettlementReferenceNo,AC.billPaymentDate,AC.billExternalReferenceNo,AC.billCode);
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
        public JsonResult PaymentGatewayCreateBillMakePayment([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBillTransaction_InsertMembershipPayment(AC.billName, AC.billDescription, AC.billTo, AC.billEmail, AC.billPhone, AC.billStatus, AC.billpaymentStatus,
             AC.billpaymentChannel, AC.billpaymentAmount, AC.billpaymentInvoiceNo, AC.billSplitPayment, AC.billSplitPaymentArgs, AC.billpaymentSettlement,
                 AC.billpaymentSettlementDate, AC.SettlementReferenceNo, AC.billPaymentDate, AC.billExternalReferenceNo, AC.billCode, AC.SaleItemsCode);
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
        public JsonResult PaymentGatewayCreateBillMakePaymentAyohaStoreOnline([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBillTransaction_InsertMembershipPaymentAyohaStoreOnline(AC.billName, AC.billDescription, AC.billTo, AC.billEmail, AC.billPhone, AC.billStatus, AC.billpaymentStatus,
             AC.billpaymentChannel, AC.billpaymentAmount, AC.billpaymentInvoiceNo, AC.billSplitPayment, AC.billSplitPaymentArgs, AC.billpaymentSettlement,
                 AC.billpaymentSettlementDate, AC.SettlementReferenceNo, AC.billPaymentDate, AC.billExternalReferenceNo, AC.billCode, AC.SaleItemsCode);
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
        public JsonResult PaymentGateWayBillMasterInsert([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBill_Master_Insert(AC.billCode, AC.billName, AC.SubscriberAccNo, AC.EnterpriseAccNo, AC.billExternalReferenceNo);
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
        public JsonResult PaymentGateWayBillMasterInsertMembershipCardPayment([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBill_Master_InsertMembershipCardPayment(AC.billCode, AC.billName, AC.SubscriberAccNo, AC.EnterpriseAccNo, 
                    AC.billExternalReferenceNo,AC.SaleItemsCode,AC.PaymentMethod,AC.PaymentChannel);
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
        public JsonResult PaymentGateWayBillMasterInsertAyohaOnlineStorePayment([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {
                success = PaymentGateWayBillTransactionModel.PaymentGateWayBill_Master_InsertAyohaOnlineStorePayment(AC.billCode, AC.billName, AC.SubscriberAccNo, AC.EnterpriseAccNo,
                    AC.billExternalReferenceNo, AC.SaleItemsCode, AC.PaymentMethod, AC.PaymentChannel);
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
        public JsonResult PaymentGateWayBillTransactionloadBybillCodeAndbillExternalReferenceNoAyohaStoreOnline([System.Web.Http.FromBody] PaymentGateWayBillTransactionModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<PaymentGateWayBillTransactionModel> data = new List<PaymentGateWayBillTransactionModel>();
            try
            {

                data = PaymentGateWayBillTransactionModel.PaymentGateWayBillTransaction_loadBybillCodeAndbillExternalReferenceNo_AyohaStoreOnline(AM.billCode, AM.billExternalReferenceNo);
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