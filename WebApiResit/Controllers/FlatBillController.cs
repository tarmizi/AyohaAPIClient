using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class FlatBillController : Controller
    {
        //
        // GET: /FlatBill/
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult FlatBillgetByCustomerIc(string CustomerIC)
        {
            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                data = FlatBillModel.FlatBill_getByCustomerIc(CustomerIC);
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
        public JsonResult FlatBillgetFlatBill(string CustomerIC, string Status, int Month, int Year, string CloudreceiptAccNo, string PremiseNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                data = FlatBillModel.FlatBill_getFlatBill(CustomerIC,Status,Month,Year,CloudreceiptAccNo,PremiseNo);
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
        public JsonResult FlatBillgetFlatBillDetails( int BillID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                data = FlatBillModel.FlatBill_getFlatBillDetails(BillID);
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
        public JsonResult FlatBillUpdateFlatBillStatus(int FlatBillID, string FlatBillUpdateBy, string FlatBillStatus)
        {

            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                success = FlatBillModel.FlatBill_UpdateFlatBillStatus(FlatBillID, FlatBillUpdateBy, FlatBillStatus);
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
        public JsonResult FlatBillUpdateFlatBillCategory(int ID ,int FlatBillID, string FlatBillUpdateBy, string FlatBillCategory)
        {

            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                success = FlatBillModel.FlatBill_UpdateFlatBillCategory(FlatBillID, FlatBillUpdateBy, FlatBillCategory,ID);
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
        public JsonResult FlatBillSearchCloudReceipts(string query)
        {
            bool success = true;
            string _Message = string.Empty;
            List<FlatBillModel> data = new List<FlatBillModel>();
            try
            {
                data = FlatBillModel.FlatBill_SearchCloudReceipts(query);
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