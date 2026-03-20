using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
namespace WebApiResit.Controllers
{
    public class AyohaeWalletAccountSettingController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletAccountSettingload()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaeWalletAccountSettingModel> data = new List<AyohaeWalletAccountSettingModel>();
            try
            {
                data = AyohaeWalletAccountSettingModel.AyohaeWalletAccountSetting_load();
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