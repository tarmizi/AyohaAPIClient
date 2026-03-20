using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRewardContestTapAndWinSponsorController : Controller
    {
        [HttpPost]
       // [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRewardContestTapAndWinSponsorload([System.Web.Http.FromBody] AyohaRewardContestTapAndWinSponsorModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRewardContestTapAndWinSponsorModel> data = new List<AyohaRewardContestTapAndWinSponsorModel>();
            try
            {

                data = AyohaRewardContestTapAndWinSponsorModel.AyohaRewardContestTapAndWinSponsor_load(AM.IDK);
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