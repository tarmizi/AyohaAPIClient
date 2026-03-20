using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class AyohaRedeemPrizeController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaRedeemPrizeInsertUpdate([System.Web.Http.FromBody] AyohaRedeemPrizeModel EE)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaRedeemPrizeModel> data = new List<AyohaRedeemPrizeModel>();
            try
            {
                // _Message = StampCardModel.SaveImage(CC.ContentCardImg, CC.EnterpriseAccNo, CC.ContentCardImgName);

                success = AyohaRedeemPrizeModel.AyohaRedeemPrize_InsertUpdate(EE.ID, EE.Img64, EE.AyohaUserGroupCode, EE.ItemName,
            EE.ItemCode, EE.ItemPoint, EE.ItemImg, EE.RowStatus, EE.CreatedBy, EE.Remarks, EE.ItemPrizePriceCost, EE.AyohaUserGroupCategory);
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
        public JsonResult AyohaRedeemPrizeLoadByAyohaUserGroupCode(string AyohaUserGroupCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeModel> data = new List<AyohaRedeemPrizeModel>();
            try
            {
                data = AyohaRedeemPrizeModel.AyohaRedeemPrize_LoadByAyohaUserGroupCode(AyohaUserGroupCode);
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
        public JsonResult AyohaRedeemPrizeLoadByRowStatusAndGC(string RowStatus, string GroupCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeModel> data = new List<AyohaRedeemPrizeModel>();
            try
            {
                data = AyohaRedeemPrizeModel.AyohaRedeemPrize_LoadByRowStatusAndGC(RowStatus, GroupCode);
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
        public JsonResult AyohaRedeemPrizeLoadByRowStatus(string RowStatus)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaRedeemPrizeModel> data = new List<AyohaRedeemPrizeModel>();
            try
            {
                data = AyohaRedeemPrizeModel.AyohaRedeemPrize_LoadByRowStatus(RowStatus);
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