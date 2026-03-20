using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class RecipientSpecificMemberController : Controller
    {

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult RecipientSpecificMemberInsert([System.Web.Http.FromBody] RecipientSpecificMemberModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<RecipientSpecificMemberModel> data = new List<RecipientSpecificMemberModel>();
            try
            {
              
                    success = RecipientSpecificMemberModel.RecipientSpecificMember_Insert(EE.NotificationCode, EE.SubscriberAccNo,
          EE.EnterpriseAccNo, EE.CreatedBy);

                
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                  success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult RecipientSpecificMemberLoadByNotificationCode(string NotificationCode, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<RecipientSpecificMemberModel> data = new List<RecipientSpecificMemberModel>();
            try
            {
                data = RecipientSpecificMemberModel.RecipientSpecificMember_LoadByNotificationCode(NotificationCode, EnterpriseAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult RecipientSpecificMemberDelete([System.Web.Http.FromBody] RecipientSpecificMemberModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<RecipientSpecificMemberModel> data = new List<RecipientSpecificMemberModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = RecipientSpecificMemberModel.RecipientSpecificMember_Delete(EE.ID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }





    }
}