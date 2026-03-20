using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class ChargeDeliverySettingController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult ChargeDeliverySettingInsertUpdate([System.Web.Http.FromBody] ChargeDeliverySettingModel MC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<ChargeDeliverySettingModel> data = new List<ChargeDeliverySettingModel>();
            try
            {
                success = ChargeDeliverySettingModel.ChargeDeliverySetting_InsertUpdate(MC.ID, MC.ChargeSettingCode, MC.EnterpriseAccNo,
MC.DeliveryName, MC.ChargeTypeCode, MC.FreeDeliveryConditionCode, MC.Over_Or_Equal, MC.IsEnableDeliveryChargeSetting, MC.CreatedBy, MC.Locations);
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
        public JsonResult ChargeDeliverySettingDelete([System.Web.Http.FromBody] ChargeDeliverySettingModel MC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<ChargeDeliverySettingModel> data = new List<ChargeDeliverySettingModel>();
            try
            {
                success = ChargeDeliverySettingModel.ChargeDeliverySetting_Delete(MC.ChargeSettingCode, MC.CreatedBy, MC.EnterpriseAccNo);
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
        public JsonResult ChargeDeliverySettingLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<ChargeDeliverySettingModel> data = new List<ChargeDeliverySettingModel>();
            try
            {
                data = ChargeDeliverySettingModel.ChargeDeliverySetting_LoadByEnterpriseAccNo(EnterpriseAccNo);
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