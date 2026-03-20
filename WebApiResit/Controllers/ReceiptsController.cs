using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class ReceiptsController : Controller
    {
        //
        // GET: /Receipts/
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult ReceiptgetByIc(string CustomerIC)
        {
            bool success = true;
            string _Message = string.Empty;
            List<ReceiptsModel> data = new List<ReceiptsModel>();
            try
            {
                data = ReceiptsModel.Receipt_getByIc(CustomerIC);
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
        public JsonResult ReceiptTypeCategoryCountgetByIcNumber(string MykadID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<ReceiptsModel> data = new List<ReceiptsModel>();
            try
            {
                data = ReceiptsModel.ReceiptTypeCategoryCount_getByIcNumber(MykadID);
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