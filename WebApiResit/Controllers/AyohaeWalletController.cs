using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaeWalletController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletLoadeWallet([System.Web.Http.FromBody] AyohaeWalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletModel> data = new List<AyohaeWalletModel>();
            try
            {

                data = AyohaeWalletModel.AyohaeWallet_LoadeWallet(AM.eWalletAccNo);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletInsert([System.Web.Http.FromBody] AyohaeWalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletModel> data = new List<AyohaeWalletModel>();
            try
            {

                success = AyohaeWalletModel.AyohaeWallet_Insert(AM.eWalletAccNo, AM.eWalletType, AM.DebitLimitPerDay, AM.PassCode,AM.isUsedDeviceID_Detection,AM.isUsedTAC_Code);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletUpdate([System.Web.Http.FromBody] AyohaeWalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletModel> data = new List<AyohaeWalletModel>();
            try
            {

                success = AyohaeWalletModel.AyohaeWallet_Update(AM.eWalletAccNo, AM.PassCode, AM.isUsedDeviceID_Detection, AM.isUsedTAC_Code);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = "false";
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaeWalletUpdateDebitLimit([System.Web.Http.FromBody] AyohaeWalletModel AM)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaeWalletModel> data = new List<AyohaeWalletModel>();
            try
            {

                success = AyohaeWalletModel.AyohaeWallet_UpdateDebitLimit(AM.eWalletAccNo, AM.DebitLimitPerDay);
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
        public JsonResult AyohaeWalletForgotPassword([System.Web.Http.FromBody] AyohaUserProfileModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
            try
            {
                //MailMessage o = new MailMessage("AyohaReward@ianMizi.com", Email, "Ayoha Reward - Forgot Password Re-generate", "Dear Ayoha Reward User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for Ayoha Reward Application re-generate Password." + Environment.NewLine + Environment.NewLine + " your new re-generate password as below:" + Environment.NewLine + NewPWD + "" + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha Reward application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha Reward Team");
                //NetworkCredential netCred = new NetworkCredential("AyohaReward@ianMizi.com", "dsmaf@51ap");
                //SmtpClient smtpobj = new SmtpClient("mail.ianmizi.com", 8889);
                //smtpobj.EnableSsl = false;
                //smtpobj.Credentials = netCred;
                //smtpobj.Send(o);




                success = AyohaeWalletModel.AyohaeWallet_ForgotPassword(AP.Email,AP.AccountNo, AP.LoginOS, AP.LoginIP,
            AP.PhoneModel, AP.PhoneImeiNo, AP.PhoneVersion, AP.PhonePlatform, AP.PhonePlatformVersion, AP.PhoneManufacturer,
            AP.PhoneSerial, AP.RawPhoneInfo, AP.PlayerID);

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