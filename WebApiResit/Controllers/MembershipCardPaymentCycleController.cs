using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MembershipCardPaymentCycleController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardPaymentCycleLoad()
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardPaymentCycleModel> data = new List<MembershipCardPaymentCycleModel>();
            try
            {
                data = MembershipCardPaymentCycleModel.MembershipCardPaymentCycleLoad();
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