using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementAudioController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementVideoInsertUpdate([System.Web.Http.FromBody] AdvertisementAudioModel AU)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementAudioModel> data = new List<AdvertisementAudioModel>();
            try
            {
                success = AdvertisementAudioModel.AdvertisementAudio_InsertUpdate(AU.ID, AU.AdvertisementCode, AU.AdvertisementAudio,
            AU.AdvertisementAudioName, AU.EnterpriseAccNo, AU.EnterpriseHQAccNo, AU.RowStatus);
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
        public JsonResult AdvertisementAudioloadByEnterpriseHQAccNoAdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementAudioModel> data = new List<AdvertisementAudioModel>();
            try
            {
                data = AdvertisementAudioModel.AdvertisementAudio_loadBy_EnterpriseHQAccNo_AdvertisementCode(EnterpriseHQAccNo, AdvertisementCode);
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