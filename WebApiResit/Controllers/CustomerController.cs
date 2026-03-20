using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        //public ActionResult Index()
        //{
        //    return View();
        //}




        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult CustomergetByCustomerNumberJoinVehicle(string CustomerNumber)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CustomerModel> data = new List<CustomerModel>();
            try
            {
                data = CustomerModel.Customer_getByCustomerNumberJoinVehicle(CustomerNumber);
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
        public JsonResult CustomergetByCustomerNumber(string CustomerNumber)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CustomerModel> data = new List<CustomerModel>();
            try
            {
                data = CustomerModel.Customer_getByCustomerNumber(CustomerNumber);
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