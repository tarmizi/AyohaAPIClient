using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaStorePaymentController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStorePaymentInsert([System.Web.Http.FromBody] AyohaStorePaymentModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStorePaymentModel> data = new List<AyohaStorePaymentModel>();
            try
            {
                success = AyohaStorePaymentModel.AyohaStore_Payment_Insert(AC.OrderNo,AC.SubscriberAccNo,AC.EnterpriseAccNo,AC.GrandTotal,AC.PaymentAmount,AC.PaymentMethod,
           AC.PaymentMethodCode, AC.CreatedBy, AC.MembershipCardCode, AC.PaymentStatus, AC.NoteToSeller, AC.MerchantPoint, AC.AyohaPoint, AC.VoucherCode, AC.VoucherCount,
           AC.VoucherDiscount, AC.MemberDiscountPercent, AC.MemberDiscountAmount);
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
        public JsonResult AyohaStorePaymentGenerateReceipt(string OrderNo, string ItemCartCode, string PaymentNo, string SubscriberAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStorePaymentModel> data = new List<AyohaStorePaymentModel>();
            try
            {
                data = AyohaStorePaymentModel.AyohaStore_Payment_GenerateReceipt(OrderNo, ItemCartCode, PaymentNo, SubscriberAccNo, MembershipCardCode);
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