using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class BusinessTypeGroupController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult BusinessTypeGroupload()
        {
            bool success = true;
            string _Message = string.Empty;
            List<BusinessTypeGroupModel> data = new List<BusinessTypeGroupModel>();
            try
            {
                data = BusinessTypeGroupModel.BusinessTypeGroup_load();
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
        public JsonResult BusinessTypeGroupMerchantCategory()
        {
            bool success = true;
            string _Message = string.Empty;
            List<BusinessTypeGroupModel> data = new List<BusinessTypeGroupModel>();
            try
            {
                data = BusinessTypeGroupModel.BusinessTypeGroup_MerchantCategory();
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