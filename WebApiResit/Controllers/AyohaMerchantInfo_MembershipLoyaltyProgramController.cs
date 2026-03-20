using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaMerchantInfo_MembershipLoyaltyProgramController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaMerchantInfoMembershipLoyaltyProgram(string MembershipCardCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaMerchantInfo_MembershipLoyaltyProgramModel> data = new List<AyohaMerchantInfo_MembershipLoyaltyProgramModel>();
            try
            {
                data = AyohaMerchantInfo_MembershipLoyaltyProgramModel.AyohaMerchantInfo_MembershipLoyaltyProgram(MembershipCardCode);
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