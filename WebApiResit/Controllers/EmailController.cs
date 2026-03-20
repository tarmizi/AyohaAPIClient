using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;


namespace WebApiResit.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /Email/
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        //public JsonResult SendEmailForgotPassword(string NewPWD, string Email)

        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileForgotPasswordNotUsed([System.Web.Http.FromBody] AyohaUserProfileModel AP)
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




            //    success = AyohaUserProfileModel.AyohaUserProfile_ForgotPassword(AP.Email, AP.LoginOS, AP.LoginIP,
            //AP.PhoneModel, AP.PhoneImeiNo, AP.PhoneVersion, AP.PhonePlatform, AP.PhonePlatformVersion, AP.PhoneManufacturer,
            //AP.PhoneSerial, AP.RawPhoneInfo, AP.PlayerID);

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
        public JsonResult SendEmailVerifyRegistrationCode(string CR_MykadNo, string Email)
        {
            bool success = true;
            string _Message = string.Empty;
            List<Emails> data = new List<Emails>();
            try
            {
                success = Emails.SendEmail_VerifyRegistrationCode(CR_MykadNo, Email);
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