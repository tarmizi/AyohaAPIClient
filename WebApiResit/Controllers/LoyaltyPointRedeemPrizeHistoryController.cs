using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class LoyaltyPointRedeemPrizeHistoryController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointRedeemPrizeHistoryInsertUpdate([System.Web.Http.FromBody] LoyaltyPointRedeemPrizeHistoryModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<LoyaltyPointRedeemPrizeHistoryModel> data = new List<LoyaltyPointRedeemPrizeHistoryModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = LoyaltyPointRedeemPrizeHistoryModel.LoyaltyPoint_RedeemPrizeHistory_InsertUpdate(EE.ID, EE.ItemCode, EE.RedeemHistoryCode, EE.RedeemHistoryStatus,
            EE.RedeemHistoryStatusBy, EE.RedeemPoint, EE.Remarks, EE.RowStatus, EE.EnterpriseAccNo, EE.PointCampaignCode, EE.RedeemHistoryApprovalStatusBy);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult LoyaltyPointRedeemPrizeHistoryLoadRedeemHistory(string RedeemHistoryStatusBy,string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointRedeemPrizeHistoryModel> data = new List<LoyaltyPointRedeemPrizeHistoryModel>();
            try
            {
                data = LoyaltyPointRedeemPrizeHistoryModel.LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory(RedeemHistoryStatusBy, EnterpriseAccNo);
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
        public JsonResult LoyaltyPointRedeemPrizeHistoryLoadRedeemHistoryMerchant(string RedeemHistoryStatusBy, string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<LoyaltyPointRedeemPrizeHistoryModel> data = new List<LoyaltyPointRedeemPrizeHistoryModel>();
            try
            {
                data = LoyaltyPointRedeemPrizeHistoryModel.LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory_Merchant(RedeemHistoryStatusBy, EnterpriseAccNo);
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