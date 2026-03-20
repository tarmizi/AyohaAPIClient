using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class SubscriberController : Controller
    {



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriberLoadByEnterpriseAccountNo(string EnterpriseAccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<SubscriberModel> data = new List<SubscriberModel>();
            try
            {
                data = SubscriberModel.Subscriber_LoadByEnterpriseAccountNo(EnterpriseAccountNo);
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