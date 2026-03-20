using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class AyohaRewardContest_SelfieAndWinController : Controller
    {

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestSelfieAndWinInsertUpdate([System.Web.Http.FromBody] AyohaRewardContest_SelfieAndWinModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContest_SelfieAndWinModel> data = new List<AyohaRewardContest_SelfieAndWinModel>();
            try
            {

                success = AyohaRewardContest_SelfieAndWinModel. AyohaRewardContest_SelfieAndWin_InsertUpdate(I.ID, I.ContestCode, I.SelfieImagePath,
   I.SelfieImageName, I.SubscriberAccNo, I.CreatedBy, I.ModifiedBy, I.Note, I.ContestStatus, I.EnterpriseAccNo, I.ReceiptLink, I.ReceiptName, I.isRequiredReceipt, I.ContestType);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }







        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestSelfieAndWinDelete([System.Web.Http.FromBody] AyohaRewardContest_SelfieAndWinModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContest_SelfieAndWinModel> data = new List<AyohaRewardContest_SelfieAndWinModel>();
            try
            {

                success = AyohaRewardContest_SelfieAndWinModel.AyohaRewardContest_SelfieAndWin_Delete(I.ID, I.ContestCode, I.SubscriberAccNo);
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
        public JsonResult AyohaRewardContestSelfieAndWinLoadBySubscriberAccNoContestCode(string SubscriberAccNo, string ContestCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRewardContest_SelfieAndWinModel> data = new List<AyohaRewardContest_SelfieAndWinModel>();
            try
            {
                data = AyohaRewardContest_SelfieAndWinModel.AyohaRewardContest_SelfieAndWin_LoadBySubscriberAccNo_ContestCode(SubscriberAccNo, ContestCode);
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