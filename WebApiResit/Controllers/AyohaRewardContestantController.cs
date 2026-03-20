using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardContestantController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestantInsertUpdate([System.Web.Http.FromBody] AyohaRewardContestantModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestantModel> data = new List<AyohaRewardContestantModel>();
            try
            {
                success = AyohaRewardContestantModel.AyohaRewardContestant_InsertUpdate(I.ID, I.ContestCode,I.SubscriberAccNo,
    I.RowStatus, I.JoinStatus, I.Descriptions, I.ModifiedBy);
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
        public JsonResult AyohaRewardContestantLoadByContestCode(string ContestCode, string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContestantModel> data = new List<AyohaRewardContestantModel>();
            try
            {
                data = AyohaRewardContestantModel.AyohaRewardContestant_LoadByContestCode(ContestCode, SubscriberAccNo);
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
        public JsonResult AyohaRewardContestantLoadBySubscriberAccNo(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContestantModel> data = new List<AyohaRewardContestantModel>();
            try
            {
                data = AyohaRewardContestantModel.AyohaRewardContestant_LoadBySubscriberAccNo(SubscriberAccNo);
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