using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class EnterpriseController : Controller
    {
        // GET: Enterprise
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisegetAll(string None)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterpriseModel> data = new List<EnterpriseModel>();
            try
            {
                data = EnterpriseModel.Enterprise_getAll();
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
        public JsonResult EnterprisegetDetails(int ID, string EnterpriseAccNo, string SubcriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<EnterpriseModel> data = new List<EnterpriseModel>();
            try
            {
                data = EnterpriseModel.Enterprise_getDetails(ID, EnterpriseAccNo, SubcriberAccNo);
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