using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class EnterprisesCheckInController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesCheckIn_Insert([System.Web.Http.FromBody] EnterprisesCheckInModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesCheckInModel> data = new List<EnterprisesCheckInModel>();

            try
            {
                success = EnterprisesCheckInModel.EnterprisesCheckIn_Insert(V.EnterpriseHQAccNo, V.EnterpriseAccNo,
           V.SubscriberAccNo, V.CheckInCode, V.CheckInMethod,V.CheckInPage);

                // Check the result of the ApiKeys_UpdateHit method and set the message accordingly
                if (success == "true")
                {
                    _Message = "insert successfully.";
                }
                else
                {
                    _Message = "Exceed Limit CheckIn, Please check in next day!";
                }
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }







        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesCheckIn_InsertCheckOut([System.Web.Http.FromBody] EnterprisesCheckInModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesCheckInModel> data = new List<EnterprisesCheckInModel>();

            try
            {
                success = EnterprisesCheckInModel.EnterprisesCheckIn_InsertCheckOut(V.EnterpriseHQAccNo, V.EnterpriseAccNo,
           V.SubscriberAccNo, V.CheckInCode, V.CheckInMethod, V.CheckInPage);

                // Check the result of the ApiKeys_UpdateHit method and set the message accordingly
                if (success == "true")
                {
                    _Message = "insert successfully.";
                }
                else
                {
                    _Message = "Error Check Out!";
                }
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesCheckIn_CanCheckIn([System.Web.Http.FromBody] EnterprisesCheckInModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesCheckInModel> data = new List<EnterprisesCheckInModel>();

            try
            {
                data = EnterprisesCheckInModel.EnterprisesCheckIn_CanCheckIn(V.EnterpriseAccNo,V.SubscriberAccNo);

              
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