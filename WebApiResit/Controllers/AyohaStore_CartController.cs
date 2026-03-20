using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStore_CartController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreCartInsertUpdate([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                success = AyohaStore_CartModel.AyohaStore_Cart_InsertUpdate(AC.ID, AC.ItemCode, AC.ItemQuantity, AC.ItemSumPrice, AC.ItemCartStatus, AC.CreatedBy, AC.EnterpriseAccNo, AC.SubscriberAccNo,
                     AC.LoyaltyRewardType, AC.MerchantSumPoint, AC.AyohaSumPoint, AC.MerchantSumStamp,AC.MerchantPoint, AC.AyohaPoint,AC.MembershipCardCode,AC.ItemCartCode);
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
        public JsonResult AyohaStoreCartDelete([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                success = AyohaStore_CartModel.AyohaStore_Cart_Delete(AC.ID, AC.EnterpriseAccNo, AC.SubscriberAccNo,AC.MembershipCardCode);
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
        public JsonResult AyohaStoreCartUnSold([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                success = AyohaStore_CartModel.AyohaStore_Cart_UnSold( AC.EnterpriseAccNo, AC.SubscriberAccNo,AC.ItemCartCode);
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
        public JsonResult AyohaStoreCartReOrder([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                success = AyohaStore_CartModel.AyohaStore_Cart_Re_Order(AC.EnterpriseAccNo, AC.SubscriberAccNo, AC.ItemCartCode, AC.NewItemCartCode);
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
        public JsonResult AyohaStoreCartUpdateStatusOrderSent([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                success = AyohaStore_CartModel.AyohaStore_Cart_UpdateStatus_OrderSent(AC.EnterpriseAccNo, AC.SubscriberAccNo,AC.MembershipCardCode);
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
        public JsonResult AyohaStoreCartLoadCartAyohaStore(string ItemCartStatus, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                data = AyohaStore_CartModel.AyohaStore_Cart_LoadCartAyohaStore(ItemCartStatus, EnterpriseAccNo, SubscriberAccNo, MembershipCardCode);
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
        public JsonResult AyohaStoreCartLoadCartAyohaStoreReOrder(string ItemCartStatus, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode, string ItemCartCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                data = AyohaStore_CartModel.AyohaStore_Cart_LoadCartAyohaStore_ReOrder(ItemCartStatus, EnterpriseAccNo, SubscriberAccNo, MembershipCardCode, ItemCartCode);
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
        public JsonResult AyohaStoreCartCartTotalItemQuantity([System.Web.Http.FromBody] AyohaStore_CartModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                data = AyohaStore_CartModel.AyohaStore_Cart_CartTotalItemQuantity(AC.EnterpriseAccNo, AC.SubscriberAccNo);
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
        public JsonResult AyohaStoreCartOrderCart(string ItemCartStatus,string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                data = AyohaStore_CartModel.AyohaStore_Cart_OrderCart(ItemCartStatus,SubscriberAccNo);
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
        public JsonResult AyohaStoreCartLoadItemCartStatus(string EnterpriseAccNo, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_CartModel> data = new List<AyohaStore_CartModel>();
            try
            {
                data = AyohaStore_CartModel.AyohaStore_Cart_LoadItemCartStatus(EnterpriseAccNo, SubscriberAccNo);
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