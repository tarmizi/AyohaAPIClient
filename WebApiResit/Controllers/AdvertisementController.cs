using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AdvertisementController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AdvertisementInsertUpdate([System.Web.Http.FromBody] AdvertisementModel A)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                success = AdvertisementModel.Advertisement_InsertUpdate(A.ID, A.AdvertisementCode, A.AdvertisementTitle, A.AdvertisementDesc,A.AdvertisementStartDate,A.AdvertisementEndDate, A.AdvertisementType,A.AdvertisementStatus,
            A.AdvertisementNote,A.EnterpriseAccNo,A.EnterpriseHQAccNo,A.CreatedBy, A.ModifiedRemarks, A.RowStatus, A.AdvertisementPeriod, A.AdvertisementFees, A.AdvertisementMedia);
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
        public JsonResult AdvertisementDelete([System.Web.Http.FromBody] AdvertisementModel A)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                success = AdvertisementModel.Advertisement_Delete(A.ID, A.AdvertisementCode, A.CreatedBy, A.EnterpriseHQAccNo, A.EnterpriseAccNo, A.ModifiedRemarks);
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
        public JsonResult AdvertisementloadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadByEnterpriseHQAccNo(EnterpriseHQAccNo);
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
        public JsonResult AdvertisementDashboardCountByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_DashboardCountByEnterpriseHQAccNo(EnterpriseHQAccNo);
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
        public JsonResult AdvertisementloadByApprovedAdvertisementStartDateEndDate(string ApprovedAdvertisementStartDate, string ApprovedAdvertisementEndDate)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadByApprovedAdvertisementStartDateEndDate(ApprovedAdvertisementStartDate, ApprovedAdvertisementEndDate);
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
        public JsonResult AdvertisementloadMedia(string AdvertisementCode, string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadMedia(AdvertisementCode,EnterpriseHQAccNo);
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
        public JsonResult AdvertisementloadMediaPreview(string AdvertisementCode, string EnterpriseHQAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadMedia_Preview(AdvertisementCode, EnterpriseHQAccNo);
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
        public JsonResult AdvertisementloadMediaAyohaUserDashboard(string AdvertisementCode)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadMedia_AyohaUserDashboard(AdvertisementCode);
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
        public JsonResult AdvertisementloadMediaAdvertisementVIA()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_loadMedia_AdvertisementVIA();
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
        public JsonResult AdvertisementloadHotSeat()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_load_HotSeat();
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
        public JsonResult AdvertisementloadPremiumAdvertisment(string SubscriberAccNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_load_Premium_Advertisment(SubscriberAccNo);
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
        public JsonResult AdvertisementloadFloating()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_load_Floating();
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
        public JsonResult AdvertisementloadStandard()
        {
            bool success = true;
            string _Message = string.Empty;
            List<AdvertisementModel> data = new List<AdvertisementModel>();
            try
            {
                data = AdvertisementModel.Advertisement_load_Standard();
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