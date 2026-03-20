using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementLinkModuleController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementLinkModuleInsertUpdate([System.Web.Http.FromBody] AdvertisementLinkModuleModel L)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementLinkModuleModel> data = new List<AdvertisementLinkModuleModel>();
            try
            {
                success = AdvertisementLinkModuleModel.AdvertisementLinkModule_InsertUpdate(L.ID, L.AdvertisementCode, L.ModuleCode,
            L.ModuleName,L.ModuleDesc, L.RowStatus, L.EnterpriseHQAccNo, L.EnterpriseAccNo,L.CreatedBy);
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
        public JsonResult AdvertisementLinkModuleloadByEnterpriseHQAccNoAdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementLinkModuleModel> data = new List<AdvertisementLinkModuleModel>();
            try
            {
                data = AdvertisementLinkModuleModel.AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_AdvertisementCode(EnterpriseHQAccNo, AdvertisementCode);
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
        public JsonResult AdvertisementLinkModuleloadByEnterpriseHQAccNoModuleCode(string EnterpriseHQAccNo, int ModuleCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementLinkModuleModel> data = new List<AdvertisementLinkModuleModel>();
            try
            {
                data = AdvertisementLinkModuleModel.AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_ModuleCode(EnterpriseHQAccNo, ModuleCode);
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