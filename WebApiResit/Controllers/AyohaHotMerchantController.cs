using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaHotMerchantController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaHotMerchantLoadByAyohaHotMerchantStatus(string AyohaHotMerchant_Status)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaHotMerchantModel> data = new List<AyohaHotMerchantModel>();
            try
            {
                data = AyohaHotMerchantModel.AyohaHotMerchant_LoadByAyohaHotMerchant_Status(AyohaHotMerchant_Status);
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