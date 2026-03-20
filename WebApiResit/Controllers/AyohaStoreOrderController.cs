using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaStoreOrderController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreOrderInsert([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                success = AyohaStoreOrderModel.AyohaStore_Order_Insert(AC.ItemCartCode,AC.DeliveryChargeCode,AC.DeliveryCharge,AC.MembershipDiscountCampaignCode,AC.MembershipDiscount,AC.VoucherCampaignCode,
            AC.VoucherDiscount,AC.GrandTotal,AC.DeliveryAddress_StreetName,AC.DeliveryAddress_Town,AC.DeliveryAddress_Postcode,AC.DeliveryAddress_StateCode,AC.DeliveryAddress_CountryCode,
            AC.ReferenceName, AC.ReferencePhoneNo, AC.NoteToSeller, AC.MerchantPointEarn, AC.AyohaPointEarn, AC.EnterpriseAccNo, AC.SubscriberAccNo, AC.MembershipCardCode, AC.DeliveryName,
            AC.TotalQuantity, AC.SubTotal, AC.VoucherCount, AC.VoucherCode,AC.TotalStampEarn);
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
        public JsonResult AyohaStoreOrderAyohaStorePaymentOrderAndConfirmPayInsert([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                success = AyohaStoreOrderModel.AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_Insert(AC.ItemCartCode, AC.DeliveryChargeCode, AC.DeliveryCharge, AC.MembershipDiscountCampaignCode, AC.MembershipDiscount, AC.VoucherCampaignCode,
            AC.VoucherDiscount, AC.GrandTotal, AC.DeliveryAddress_StreetName, AC.DeliveryAddress_Town, AC.DeliveryAddress_Postcode, AC.DeliveryAddress_StateCode, AC.DeliveryAddress_CountryCode,
            AC.ReferenceName, AC.ReferencePhoneNo, AC.NoteToSeller, AC.MerchantPointEarn, AC.AyohaPointEarn, AC.EnterpriseAccNo, AC.SubscriberAccNo, AC.MembershipCardCode, AC.DeliveryName, AC.TotalQuantity, AC.SubTotal,
             AC.PaymentAmount, AC.PaymentMethod, AC.PaymentMethodCode, AC.CreatedBy, AC.PaymentStatus, AC.VoucherCount, AC.VoucherCode, AC.TotalStampEarn, AC.MemberDiscountPercent, AC.MemberDiscountAmount);
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
        public JsonResult AyohaStoreOrderAyohaStorePaymentOrderAndConfirmPayInsertAyohaStoreOnline([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                success = AyohaStoreOrderModel.AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_InsertAyohaStoreOnline(AC.ItemCartCode, AC.DeliveryChargeCode, AC.DeliveryCharge, AC.MembershipDiscountCampaignCode, AC.MembershipDiscount, AC.VoucherCampaignCode,
            AC.VoucherDiscount, AC.GrandTotal, AC.DeliveryAddress_StreetName, AC.DeliveryAddress_Town, AC.DeliveryAddress_Postcode, AC.DeliveryAddress_StateCode, AC.DeliveryAddress_CountryCode,
            AC.ReferenceName, AC.ReferencePhoneNo, AC.NoteToSeller, AC.MerchantPointEarn, AC.AyohaPointEarn, AC.EnterpriseAccNo, AC.SubscriberAccNo, AC.MembershipCardCode, AC.DeliveryName, AC.TotalQuantity, AC.SubTotal,
             AC.PaymentAmount, AC.PaymentMethod, AC.PaymentMethodCode, AC.CreatedBy, AC.PaymentStatus, AC.VoucherCount, AC.VoucherCode, AC.TotalStampEarn, AC.MemberDiscountPercent, AC.MemberDiscountAmount, AC.billExternalReferenceNo);
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
        public JsonResult AyohaStoreOrderUpdateOrderStatus([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                success = AyohaStoreOrderModel.AyohaStore_Order_UpdateOrderStatus(AC.OrderNo, AC.SubscriberAccNo, AC.OrderStatus,AC.OrderLogOrderStatus,AC.EnterpriseAccNo);
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
        public JsonResult AyohaStoreOrderUpdateRowStatus([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                success = AyohaStoreOrderModel.AyohaStore_Order_UpdateRowStatus(AC.OrderNo, AC.SubscriberAccNo, AC.RowStatus);
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
        public JsonResult AyohaStoreOrderLoadByEnterpriseAccNoAndOrderStatus(string EnterpriseAccNo, string OrderStatus)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_LoadByEnterpriseAccNoAndOrderStatus(EnterpriseAccNo, OrderStatus);
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
        public JsonResult AyohaStoreOrderLoadBySubscriberAccNoAndOrderStatus(string SubscriberAccNo, string OrderStatus,string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus(SubscriberAccNo, OrderStatus, EnterpriseAccNo);
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
        public JsonResult AyohaStoreOrderLoadBySubscriberAccNoAndOrderStatusDashboardOrderHistory(string SubscriberAccNo, string OrderStatus)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus_DashboardOrderHistory(SubscriberAccNo, OrderStatus);
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
        public JsonResult AyohaStoreOrderLoadByItemCartCodeAndMembershipCardCode(string ItemCartCode, string MembershipCardCode,string OrderNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_LoadByItemCartCodeAndMembershipCardCode(ItemCartCode, MembershipCardCode, OrderNo);
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
        public JsonResult AyohaStoreOrderPendingOrderMainDashbord([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_PendingOrder_MainDashbord( AC.SubscriberAccNo);
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
        public JsonResult AyohaStoreOrderPendingOrderMainDashbord_Count([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_PendingOrder_MainDashbord_Count(AC.SubscriberAccNo);
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
        public JsonResult AyohaStoreOrderLoadByOrderNoSubscriberAccNo([System.Web.Http.FromBody] AyohaStoreOrderModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStoreOrderModel> data = new List<AyohaStoreOrderModel>();
            try
            {
                data = AyohaStoreOrderModel.AyohaStore_Order_LoadByOrderNo_SubscriberAccNo(AC.OrderNo,AC.SubscriberAccNo);
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