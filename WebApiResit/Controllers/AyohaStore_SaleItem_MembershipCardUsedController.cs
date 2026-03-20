using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStore_SaleItem_MembershipCardUsedController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStore_SaleItem_MembershipCardUsed_InsertUpdate([System.Web.Http.FromBody] AyohaStore_SaleItem_MembershipCardUsedModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_SaleItem_MembershipCardUsedModel> data = new List<AyohaStore_SaleItem_MembershipCardUsedModel>();
            try
            {

                success = AyohaStore_SaleItem_MembershipCardUsedModel.AyohaStore_SaleItem_MembershipCardUsed_InsertUpdate(I.EnterpriseAccNo,I.SubscriberAccNo,
 I.MembershipCardCode, I.SaleItemCode);
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