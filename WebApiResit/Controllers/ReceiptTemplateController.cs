using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class ReceiptTemplateController : Controller
    {
        // GET: ReceiptTemplate
        //public ActionResult Index()
        //{
        //    return View();
        //}



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult ReceiptTemplategetByTemplateEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<ReceiptTemplateModel> data = new List<ReceiptTemplateModel>();
            try
            {
                data = ReceiptTemplateModel.ReceiptTemplate_getByTemplateEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult ReceiptTemplategetByTemplateCode(string TemplateCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<ReceiptTemplateModel> data = new List<ReceiptTemplateModel>();
            try
            {
                data = ReceiptTemplateModel.ReceiptTemplate_getByTemplateCode(TemplateCode);
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