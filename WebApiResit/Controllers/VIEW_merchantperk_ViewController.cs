using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;


namespace WebApiResit.Controllers
{
    public class VIEW_merchantperk_ViewController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VIEW_merchantperk_View([System.Web.Http.FromBody] VIEW_merchantperk_ViewModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_merchantperk_ViewModel> data = new List<VIEW_merchantperk_ViewModel>();
            try
            {
                data = VIEW_merchantperk_ViewModel.VIEW_merchantperk_View();
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VIEW_merchantperk_View_LoadbySubscriberAccNo([System.Web.Http.FromBody] VIEW_merchantperk_ViewModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_merchantperk_ViewModel> data = new List<VIEW_merchantperk_ViewModel>();
            try
            {
                data = VIEW_merchantperk_ViewModel.VIEW_merchantperk_View_LoadbySubscriberAccNo(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VIEW_merchantperk_View_DashboardInitialLoad([System.Web.Http.FromBody] VIEW_merchantperk_ViewModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_merchantperk_ViewModel> data = new List<VIEW_merchantperk_ViewModel>();
            try
            {
                data = VIEW_merchantperk_ViewModel.VIEW_merchantperk_View_DashboardInitialLoad(AC.SubscriberAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult VIEW_merchantperk_View_DashboardLoadByEnterpriseAccNo([System.Web.Http.FromBody] VIEW_merchantperk_ViewModel AC)
        {
            string success = "true";
            string _Message = string.Empty;
            List<VIEW_merchantperk_ViewModel> data = new List<VIEW_merchantperk_ViewModel>();
            try
            {
                data = VIEW_merchantperk_ViewModel.VIEW_merchantperk_View_DashboardLoadByEnterpriseAccNo(AC.SubscriberAccNo,AC.EnterpriseAccNo);
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