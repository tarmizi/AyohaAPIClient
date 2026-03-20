using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardEvent_RespondController : Controller
    {


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardEventRespondInsertUpdate([System.Web.Http.FromBody] AyohaRewardEvent_RespondModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardEvent_RespondModel> data = new List<AyohaRewardEvent_RespondModel>();
            try
            {

                success = AyohaRewardEvent_RespondModel.AyohaRewardEvent_Respond_InsertUpdate(I.ID,I.EventCode,I.SubscriberAccNo,I.RespondStatus,I.CreatedBy,I.Noted,I.EnterpriseAccNo);
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