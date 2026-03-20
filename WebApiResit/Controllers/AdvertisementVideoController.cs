using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementVideoController : Controller
    {

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementVideoInsertUpdate([System.Web.Http.FromBody] AdvertisementVideoModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementVideoModel> data = new List<AdvertisementVideoModel>();
            try
            {
                success = AdvertisementVideoModel.AdvertisementVideo_InsertUpdate(V.ID, V.AdvertisementCode, V.AdvertisementVideo,
            V.AdvertisementVideoName,V.AdvertisementVideoNote,  V.EnterpriseAccNo, V.EnterpriseHQAccNo, V.RowStatus,V.CreatedBy);
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
        public JsonResult AdvertisementVideoloadByEnterpriseHQAccNoAdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementVideoModel> data = new List<AdvertisementVideoModel>();
            try
            {
                data = AdvertisementVideoModel.AdvertisementVideo_loadBy_EnterpriseHQAccNo_AdvertisementCode(EnterpriseHQAccNo, AdvertisementCode);
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