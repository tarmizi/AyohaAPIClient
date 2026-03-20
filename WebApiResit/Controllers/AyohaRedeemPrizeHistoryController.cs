using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaRedeemPrizeHistoryController : Controller
    {


      


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRedeemPrizeHistoryInsertUpdate([System.Web.Http.FromBody] AyohaRedeemPrizeHistoryModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRedeemPrizeHistoryModel> data = new List<AyohaRedeemPrizeHistoryModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = AyohaRedeemPrizeHistoryModel.AyohaRedeemPrizeHistory_InsertUpdate(EE.ID, EE.ItemCode, EE.RedeemHistoryCode, EE.RedeemHistoryStatus,
            EE.RedeemHistoryStatusBy, EE.RedeemPoint, EE.Remarks, EE.RowStatus,EE.AyohaPoint);
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
        public JsonResult AyohaRedeemPrizeHistoryLoadRedeemHistoryStatusBy(string RedeemHistoryStatusBy)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeHistoryModel> data = new List<AyohaRedeemPrizeHistoryModel>();
            try
            {
                data = AyohaRedeemPrizeHistoryModel.AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy(RedeemHistoryStatusBy);
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
        public JsonResult AyohaRedeemPrizeHistoryLoadRedeemHistoryStatusByYearStatus(string RedeemHistoryStatusBy, string Year, string Status)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeHistoryModel> data = new List<AyohaRedeemPrizeHistoryModel>();
            try
            {
                data = AyohaRedeemPrizeHistoryModel.AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy_Year_Status(RedeemHistoryStatusBy, Year, Status);
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
        public JsonResult AyohaRedeemPrizeHistoryLoadByRedeemHistoryCode(string RedeemHistoryStatusBy, string RedeemHistoryCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeHistoryModel> data = new List<AyohaRedeemPrizeHistoryModel>();
            try
            {
                data = AyohaRedeemPrizeHistoryModel.AyohaRedeemPrizeHistory_LoadByRedeemHistoryCode(RedeemHistoryStatusBy, RedeemHistoryCode);
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
        public JsonResult AyohaRedeemPrizeHistoryCountStatusBySubscriberAccNoYear(string SubscriberAccNo, string Year)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeHistoryModel> data = new List<AyohaRedeemPrizeHistoryModel>();
            try
            {
                data = AyohaRedeemPrizeHistoryModel.AyohaRedeemPrizeHistory_CountStatusBySubscriberAccNo_Year(SubscriberAccNo, Year);
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