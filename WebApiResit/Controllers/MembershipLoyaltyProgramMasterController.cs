using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class MembershipLoyaltyProgramMasterController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult MembershipLoyaltyProgramMasterLoadMaster([System.Web.Http.FromBody] EnterprisesModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<MembershipLoyaltyProgramMasterModel> data = new List<MembershipLoyaltyProgramMasterModel>();

            try
            {
                data = MembershipLoyaltyProgramMasterModel.MembershipLoyaltyProgramMaster_LoadMaster(V.SubscriberAccNo);


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