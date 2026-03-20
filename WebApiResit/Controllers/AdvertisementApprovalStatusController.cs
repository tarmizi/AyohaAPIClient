using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementApprovalStatusController : Controller
    {
        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementApprovalStatusLoadMaster()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementApprovalStatusModel> data = new List<AdvertisementApprovalStatusModel>();
            try
            {
                data = AdvertisementApprovalStatusModel.AdvertisementApprovalStatus_Load_Master();
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