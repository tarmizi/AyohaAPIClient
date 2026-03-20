using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStore_SaleItemController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreSaleItemloadByEnterpriseAccNoItemCategory(string EnterpriseAccNo, string ItemCategoryCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_loadBy_EnterpriseAccNo_ItemCategory(EnterpriseAccNo, ItemCategoryCode, SubscriberAccNo);
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
        public JsonResult AyohaStoreSaleItemloadByItemCode([System.Web.Http.FromBody] AyohaStore_SaleItemModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
   

                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_loadBy_ItemCode(AM.EnterpriseAccNo,AM.SubscriberAccNo,AM.ReviewCode);
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
        public JsonResult AyohaStoreSaleItemloadByEnterpriseAccNoHotItem(string EnterpriseAccNo, string ItemCategoryCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_loadBy_EnterpriseAccNo_HotItem(EnterpriseAccNo, ItemCategoryCode, SubscriberAccNo);
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
        public JsonResult AyohaStoreSaleItemloadItemCategory(string EnterpriseAccNo, string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_loadItemCategory(EnterpriseAccNo, MembershipCardCode);
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
        public JsonResult AyohaStoreSaleItemImgExtendloadByItemCode(string ItemCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_ImgExtendloadBy_ItemCode(ItemCode);
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
        public JsonResult AyohaStoreSaleItemAyohaStoreFrontPage(string SubscriberAccNo, string EnterpriseAccNo,string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_SaleItemModel> data = new List<AyohaStore_SaleItemModel>();
            try
            {
                data = AyohaStore_SaleItemModel.AyohaStore_SaleItem_AyohaStoreFrontPage(SubscriberAccNo, EnterpriseAccNo, MembershipCardCode);
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