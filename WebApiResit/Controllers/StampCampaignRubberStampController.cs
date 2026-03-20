using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class StampCampaignRubberStampController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult StampCampaignRubberStampLoadByStampCampaignCode(string StampCampaignCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<StampCampaignRubberStampModel> data = new List<StampCampaignRubberStampModel>();
            try
            {
                data = StampCampaignRubberStampModel.StampCampaignRubberStamp_LoadByStampCampaignCode(StampCampaignCode);
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