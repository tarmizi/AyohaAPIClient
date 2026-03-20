using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class SubscriptionsController : Controller
    {


        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsInsert([System.Web.Http.FromBody] SubscriptionsModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                success = SubscriptionsModel.Subscriptions_Insert(V.SubscriptionCode, V.SubscriberAccNo,
           V.MerchantAccNo, V.SaleItemsCode, V.SubscriptionStatus,
            V.ModifiedBy, V.SubscribedPackage, V.PackagePrice);

                // Check the result of the ApiKeys_UpdateHit method and set the message accordingly
                if (success == "true")
                {
                    _Message = "insert successfully.";
                }
                else
                {
                    _Message = "You Already Subscribed This Product and Package!";
                }
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
        public JsonResult SubscriptionsUpdateSubscriptionStatus([System.Web.Http.FromBody] SubscriptionsModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();



            try
            {
                success = SubscriptionsModel.Subscriptions_UpdateSubscriptionStatus(V.SubscriptionCode, V.SubscriptionStatus,V.billExternalReferenceNo,V.billCode,V.SubscriberAccNo,V.EnterpriseAccNo
                    ,V.MembershipCardCode,V.PackagePrice);

                // Check the result of the ApiKeys_UpdateHit method and set the message accordingly
                if (success == "true")
                {
                    _Message = "Update successfully.";
                }
                else
                {
                    _Message = "Update Failed!";
                }
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
        public JsonResult SubscriptionsInsertUpdate([System.Web.Http.FromBody] SubscriptionsModel V)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                success = SubscriptionsModel.Subscriptions_InsertUpdate(V.SubscriptionCode, V.SubscriberAccNo,
           V.MerchantAccNo, V.SaleItemsCode, V.SubscriptionStatus,
            V.ModifiedBy, V.SubscribedPackage, V.PackagePrice);

                // Check the result of the ApiKeys_UpdateHit method and set the message accordingly
                if (success == "true")
                {
                    _Message = "insert/updated successfully.";
                }
                else
                {
                    _Message = "error unknown.";
                }
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
        public JsonResult SubscriptionsloadByMerchantNo([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadByMerchantNo(AM.MerchantAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid MerchantNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }







        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsListOfSubscriberloadByMerchantNo([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_ListOfSubscriber_loadByMerchantNo(AM.MerchantAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid MerchantNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsListOfSubscriberloadByMerchantNoSaleItemsCode([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_ListOfSubscriber_loadByMerchantNo_SaleItemsCode(AM.MerchantAccNo, AM.SaleItemsCode);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid MerchantNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadBySubscriberAccNo([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadBySubscriberAccNo(AM.SubscriberAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadBySubscriberAccNoMerchantAccNoSaleItemsCode([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadBySubscriberAccNo_MerchantAccNo_SaleItemsCode(AM.SubscriberAccNo, AM.MerchantAccNo, AM.SaleItemsCode);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadBySubscriberAccNoDashboardServices([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadBySubscriberAccNo_DashboardServices(AM.SubscriberAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }








        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadBySubscriberAccNoSubscriptionPackage([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadBySubscriberAccNo_SubscriptionPackage(AM.SubscriberAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadByMerchantAccNoSubscriptionPackageDashbordMerchant([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadByMerchantAccNo_SubscriptionPackage_Dashbord_Merchant(AM.MerchantAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadBySubscriptionCode([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadBySubscriptionCode(AM.SubscriptionCode);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "SubscriptionCode Already Exist";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionscheckBySubscriptionCode([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_checkBySubscriptionCode(AM.SubscriptionCode, AM.PackagePrice, AM.SubscribedPackage);


            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }






        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionscheckBySubscriberAccNo_MerchantAccNo_SaleItemsCode([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_checkBySubscriberAccNo_MerchantAccNo_SaleItemsCode(AM.SubscriberAccNo, AM.MerchantAccNo, AM.SaleItemsCode);


            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult SubscriptionsloadByMerchantAccNoDashboardMerchant([System.Web.Http.FromBody] SubscriptionsModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<SubscriptionsModel> data = new List<SubscriptionsModel>();

            try
            {
                data = SubscriptionsModel.Subscriptions_loadByMerchantAccNo_Dashboard_Merchant(AM.MerchantAccNo);

                // If no data is returned, handle it as a login failure
                if (data == null || data.Count == 0)
                {
                    success = "false";
                    _Message = "Invalid SubscriberAccNo.";  // This message will come from the stored procedure in some cases
                }
            }
            catch (Exception ex)
            {
                // Capture any exceptions thrown by the login method
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

    }
}