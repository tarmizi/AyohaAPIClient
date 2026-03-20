using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStore_ShippingAddressController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreShippingAddressInsertUpdate([System.Web.Http.FromBody] AyohaStore_ShippingAddressModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_ShippingAddressModel> data = new List<AyohaStore_ShippingAddressModel>();
            try
            {
                success = AyohaStore_ShippingAddressModel.AyohaStore_ShippingAddress_InsertUpdate(AC.ID,AC.StreetName,AC.Town,AC.PostCode,AC.StateCode,AC.CountryCode,AC.ContactPersonName,AC.PhoneNo,AC.ItemCartCode
        , AC.OrderCode, AC.SubscriberAccNo, AC.EnterpriseAccNo);
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
        public JsonResult AyohaStoreShippingAddressLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_ShippingAddressModel> data = new List<AyohaStore_ShippingAddressModel>();
            try
            {
                data = AyohaStore_ShippingAddressModel.AyohaStore_ShippingAddress_LoadBySubscriberAccNo(SubscriberAccNo);
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