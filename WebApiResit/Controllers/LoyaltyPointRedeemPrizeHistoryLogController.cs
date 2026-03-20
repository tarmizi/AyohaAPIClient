using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class LoyaltyPointRedeemPrizeHistoryLogController : Controller
    {

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointRedeemPrizeHistoryLogLoad(string RedeemHistoryCode, string RedeemHistoryStatusBy)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPoint_RedeemPrizeHistoryLogModel> data = new List<LoyaltyPoint_RedeemPrizeHistoryLogModel>();
            try
            {
                data = LoyaltyPoint_RedeemPrizeHistoryLogModel.LoyaltyPoint_RedeemPrizeHistoryLog_Load( RedeemHistoryCode,RedeemHistoryStatusBy);
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