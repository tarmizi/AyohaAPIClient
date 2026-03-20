using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class EnterprisesFavoriteController : Controller
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult EnterprisesFavorite_LoadFavorite([System.Web.Http.FromBody] EnterprisesModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesModel> data = new List<EnterprisesModel>();

            try
            {
                data = EnterprisesModel.EnterprisesFavorite_LoadFavorite(V.SubscriberAccNo);


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
        public JsonResult EnterprisesFavorite_AddEnterpriseFavorite([System.Web.Http.FromBody] EnterprisesFavoriteModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesFavoriteModel> data = new List<EnterprisesFavoriteModel>();

            try
            {
                success = EnterprisesFavoriteModel.EnterprisesFavorite_AddEnterpriseFavorite(V.EnterpriseAccNo, V.SubscriberAccNo);


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
        public JsonResult EnterprisesFavorite_RemoveEnterpriseFavorite([System.Web.Http.FromBody] EnterprisesFavoriteModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<EnterprisesFavoriteModel> data = new List<EnterprisesFavoriteModel>();

            try
            {
                success = EnterprisesFavoriteModel.EnterprisesFavorite_RemoveEnterpriseFavorite(V.EnterpriseAccNo, V.SubscriberAccNo);


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