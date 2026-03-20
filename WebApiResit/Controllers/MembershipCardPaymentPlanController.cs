using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class MembershipCardPaymentPlanController : Controller
    {

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardPaymentPlanLoadByPaymentPlanCode([System.Web.Http.FromBody] MembershipCardPaymentPlanModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipCardPaymentPlanModel> data = new List<MembershipCardPaymentPlanModel>();
            try
            {
                data = MembershipCardPaymentPlanModel.MembershipCardPaymentPlan_LoadBy_PaymentPlanCode(AP.PaymentPlanCode);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }
	}
}