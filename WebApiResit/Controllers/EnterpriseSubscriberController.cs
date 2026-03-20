using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class EnterpriseSubscriberController : Controller
    {
        // GET: EnterpriseSubscriber
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterpriseSubscriberInsert(string SubcriberAccNo, string EnterpriseAccNo, int SubscribedCloudReceipt, int SubscribedNewsAndPromotion, string User)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterpriseSubscriberModel> data = new List<EnterpriseSubscriberModel>();
            try
            {
                success = EnterpriseSubscriberModel.EnterpriseSubscriber_Insert(SubcriberAccNo, EnterpriseAccNo, SubscribedCloudReceipt, SubscribedNewsAndPromotion, User);
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
        public JsonResult EnterpriseSubscribergetBySubcriberAccNo(string SubcriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterpriseSubscriberModel> data = new List<EnterpriseSubscriberModel>();
            try
            {
                data = EnterpriseSubscriberModel.EnterpriseSubscriber_getBySubcriberAccNo(SubcriberAccNo);
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
        public JsonResult EnterpriseSubscribergetBySubcriberAccNoSearchReceipt(string SubcriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterpriseSubscriberModel> data = new List<EnterpriseSubscriberModel>();
            try
            {
                data = EnterpriseSubscriberModel.EnterpriseSubscriber_getBySubcriberAccNo_SearchReceipt(SubcriberAccNo);
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