using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaStore_LikeStatusController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaStoreLikeStatusInsertUpdate([System.Web.Http.FromBody] AyohaStore_LikeStatusModel A)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaStore_LikeStatusModel> data = new List<AyohaStore_LikeStatusModel>();
            try
            {
                success = AyohaStore_LikeStatusModel.AyohaStore_LikeStatus_InsertUpdate(A.SubscriberAccNo, A.EnterpriseAccNo, A.isLike);
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
        public JsonResult AyohaStoreLoadLikeStatus(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaStore_LikeStatusModel> data = new List<AyohaStore_LikeStatusModel>();
            try
            {
                data = AyohaStore_LikeStatusModel.AyohaStore_LoadLikeStatus(EnterpriseAccNo);
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