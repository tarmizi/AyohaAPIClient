using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaNotificationMasterEnterprisesController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationMasterEnterprisesLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationMasterEnterprisesModel> data = new List<AyohaNotificationMasterEnterprisesModel>();
            try
            {
                data = AyohaNotificationMasterEnterprisesModel.AyohaNotificationMaster_Enterprises_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
        public JsonResult AyohaNotificationMaster_Enterprises_LoadByID(string EnterpriseAccNo,int ID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AyohaNotificationMasterEnterprisesModel> data = new List<AyohaNotificationMasterEnterprisesModel>();
            try
            {
                data = AyohaNotificationMasterEnterprisesModel.AyohaNotificationMaster_Enterprises_LoadByID(EnterpriseAccNo,ID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }










        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaNotificationMasterEnterprisesDelete([System.Web.Http.FromBody] AyohaNotificationMasterEnterprisesModel AM)
        {
            string success = "true";
            string _Message = string.Empty;

            List<AyohaNotificationMasterEnterprisesModel> data = new List<AyohaNotificationMasterEnterprisesModel>();
            try
            {

                success = AyohaNotificationMasterEnterprisesModel.AyohaNotificationMaster_Enterprises_Delete(AM.EnterpriseAccNo,AM.ID);

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
        public JsonResult AyohaNotificationMasterEnterprisesUpdateIsRead([System.Web.Http.FromBody] AyohaNotificationMasterEnterprisesModel AM)
        {
            string success = "true";
            string _Message = string.Empty;

            List<AyohaNotificationMasterEnterprisesModel> data = new List<AyohaNotificationMasterEnterprisesModel>();
            try
            {

                success = AyohaNotificationMasterEnterprisesModel.AyohaNotificationMaster_Enterprises_UpdateIsRead(AM.EnterpriseAccNo, AM.ID);

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