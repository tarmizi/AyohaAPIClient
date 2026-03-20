using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class NotificationsController : Controller
    {
        //
        // GET: /Notifications/
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult NotificationsLoadNotifications(string CR_MykadNo, string CR_AccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                data = NotificationsModel.Notifications_LoadNotifications(CR_MykadNo, CR_AccountNo);
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
        public JsonResult NotificationsCountNotificationsTypeNN(string CR_MykadNo, string CR_AccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                data = NotificationsModel.Notifications_CountNotificationsTypeNN(CR_MykadNo, CR_AccountNo);
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
        public JsonResult NotificationsCountNotificationsTypeR(string CR_MykadNo, string CR_AccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                data = NotificationsModel.Notifications_CountNotificationsTypeR(CR_MykadNo, CR_AccountNo);
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
        public JsonResult NotificationsLoadNotificationsTypeN(string CR_MykadNo,int ID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                data = NotificationsModel.Notifications_LoadNotifications_TypeN(CR_MykadNo,ID);
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
        public JsonResult NotificationsLoadNotificationsTypeNAll(string CR_MykadNo,string Year,string Month)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                data = NotificationsModel.Notifications_LoadNotifications_TypeN_All(CR_MykadNo,Year,Month);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }





        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult NotificationsUpdateReadNotifications(int ID, string CR_AccountNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<NotificationsModel> data = new List<NotificationsModel>();
            try
            {
                success = NotificationsModel.Notifications_UpdateReadNotifications(ID, CR_AccountNo);
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