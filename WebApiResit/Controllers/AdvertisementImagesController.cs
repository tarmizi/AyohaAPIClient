using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class AdvertisementImagesController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementImagesInsertUpdate([System.Web.Http.FromBody] AdvertisementImagesModel I)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementImagesModel> data = new List<AdvertisementImagesModel>();
            try
            {
                success = AdvertisementImagesModel.AdvertisementImages_InsertUpdate(I.ID, I.AdvertisementCode, I.AdvertisementImg,
            I.AdvertisementImgName, I.AdvertisementImgNote, I.EnterpriseAccNo, I.EnterpriseHQAccNo, I.RowStatus, I.CreatedBy);
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
        public JsonResult AdvertisementImagesloadByEnterpriseHQAccNoAdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementImagesModel> data = new List<AdvertisementImagesModel>();
            try
            {
                data = AdvertisementImagesModel.AdvertisementImages_loadBy_EnterpriseHQAccNo_AdvertisementCode(EnterpriseHQAccNo, AdvertisementCode);
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