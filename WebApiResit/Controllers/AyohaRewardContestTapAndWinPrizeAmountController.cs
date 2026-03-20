using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardContestTapAndWinPrizeAmountController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestTapAndWinPrizeAmountLoadContestRule([System.Web.Http.FromBody] AyohaRewardContestTapAndWinPrizeAmountModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestTapAndWinPrizeAmountModel> data = new List<AyohaRewardContestTapAndWinPrizeAmountModel>();
            try
            {

                data = AyohaRewardContestTapAndWinPrizeAmountModel.AyohaRewardContestTapAndWinPrizeAmount_LoadContestRule(AM.SubscriberAccNo,AM.ContestCode);
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