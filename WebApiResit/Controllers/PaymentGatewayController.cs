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
    public class PaymentGatewayController : Controller
    {
        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult PaymentGatewayCreateBill_eWalletTopUp([System.Web.Http.FromBody] PaymentGatewayModel AC)
        //{
        //    string success;
        //    string _Message = string.Empty;
        //    List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
        //    try
        //    {
        //        success = PaymentGatewayModel.CreateBill_eWalletTopUp(AC.namBill, AC.name, AC.hpNo, AC.billName, AC.billDesc,AC.billEmail);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = "false";
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);

        //}

          [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PaymentGatewayGetBillTransaction(string billCode, string billpaymentStatus)
        {
            string success;
            string _Message = string.Empty;

            List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
            try
            {
                success = PaymentGatewayModel.GetBillTransaction(billCode, billpaymentStatus);

            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }



            var bla = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(success).Replace("\\\"", string.Empty);

            //return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
            return Json(new { success = success }, JsonRequestBehavior.AllowGet);
        }


          [HttpGet]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult PaymentGatewayCreateBill_MakePayment(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID, int billAmount)
          {
              string success;
              string _Message = string.Empty;

              List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
              try
              {
                  success = PaymentGatewayModel.CreateBill_MakePayment(namBill, name, hpNo, billName, billDesc, billEmail, billExternalID, billAmount);

              }
              catch (Exception ex)
              {
                  _Message = ex.Message;
                  success = "false";
              }



              var bla = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(success).Replace("\\\"", string.Empty);

              return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
          }


          [HttpGet]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult PaymentGatewayCreateBill_MakePaymentAyohaOnlineStore(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID, int billAmount)
          {
              string success;
              string _Message = string.Empty;

              List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
              try
              {
                  success = PaymentGatewayModel.CreateBill_MakePayment_AyohaOnlineStore(namBill, name, hpNo, billName, billDesc, billEmail, billExternalID, billAmount);

              }
              catch (Exception ex)
              {
                  _Message = ex.Message;
                  success = "false";
              }



              var bla = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(success).Replace("\\\"", string.Empty);

              return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
          }

      

        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PaymentGatewayCreateBill_eWalletTopUp(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID)
        {
            string success;
            string _Message = string.Empty;

            List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
            try
            {
                success = PaymentGatewayModel.CreateBill_eWalletTopUp(namBill, name, hpNo, billName, billDesc, billEmail, billExternalID);

            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }



            var bla = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(success).Replace("\\\"", string.Empty);

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult PaymentGatewayCreateBillCallBack([System.Web.Http.FromBody] PaymentGatewayModel AC)
        {
            string success;
            string _Message = string.Empty;
            List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
            try
            {
                success = PaymentGatewayModel.PaymentGatewayCreateBill_CallBack(AC.refno, AC.status, AC.reason, AC.billcode, AC.order_id, AC.amount, AC.transaction_time);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult PaymentGatewayGetBillTransaction([System.Web.Http.FromBody] PaymentGatewayModel AC)
        //{
        //    string success;
        //    string _Message = string.Empty;
        //    List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
        //    try
        //    {
        //        success = PaymentGatewayModel.GetBillTransaction(AC.billCode, AC.billpaymentStatus);
        //    }
        //    catch (Exception ex)
        //    {
        //        _Message = ex.Message;
        //        success = "false";
        //    }

        //    return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        //}



    //    [HttpGet]
    //    [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    //    public JsonResult PaymentGatewayGetBillTransaction(string billCode, string billpaymentStatus)
    //    {
    //        string success;
    //        string _Message = string.Empty;
       
    //        List<PaymentGatewayModel> data = new List<PaymentGatewayModel>();
    //        try
    //        {
    //            success = PaymentGatewayModel.GetBillTransaction(billCode, billpaymentStatus);
              
    //        }
    //        catch (Exception ex)
    //        {
    //            _Message = ex.Message;
    //            success = "false";
    //        }

         

    //        var bla = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(success).Replace("\\\"", string.Empty);

    //        //return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
    //        return Json(new { success = success }, JsonRequestBehavior.AllowGet);
    //    }
    }
}