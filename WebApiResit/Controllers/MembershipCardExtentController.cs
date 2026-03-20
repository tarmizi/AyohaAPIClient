using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MembershipCardExtentController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipCardLoadBySubscriberAccNoMembershipCardCodeEnterpriseAccNo(string AyohaUserAccNo, string MMC, string EnterprisesAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardExtentModel> data = new List<MembershipCardExtentModel>();
            try
            {
                data = MembershipCardExtentModel.MembershipCard_LoadBySubscriberAccNoMembershipCardCodeEnterpriseAccNo(AyohaUserAccNo, MMC, EnterprisesAccNo);
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
        public JsonResult MembershipCard_LoadByEnterpriseAccNo_testing(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<MembershipCardExtentModel> data = new List<MembershipCardExtentModel>();
            try
            {
                data = MembershipCardExtentModel.MembershipCard_LoadByEnterpriseAccNo_testing(EnterpriseAccNo);
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