using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaRewardContestTapAndWinLogController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestTapAndWinLogInsert([System.Web.Http.FromBody] AyohaRewardContestTapAndWinLogModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestTapAndWinLogModel> data = new List<AyohaRewardContestTapAndWinLogModel>();
            try
            {
                success = AyohaRewardContestTapAndWinLogModel.AyohaRewardContestTapAndWinLog_Insert(AC.ContestCode, AC.SubscriberAccNo, AC.TapCount, AC.TapStatus, AC.TapNo,AC.TapNoSecret,
          AC.TapWinAmount, AC.MembershipGroupCode);
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
        public JsonResult AyohaRewardContestTapAndWinTapNoSecInsert([System.Web.Http.FromBody] AyohaRewardContestTapAndWinLogModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestTapAndWinLogModel> data = new List<AyohaRewardContestTapAndWinLogModel>();
            try
            {
                success = AyohaRewardContestTapAndWinLogModel.AyohaRewardContestTapAndWinTapNoSec_Insert(AC.TapNo, AC.SubscriberAccNo,AC.ContestCode);
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