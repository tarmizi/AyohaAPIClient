using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class AyohaUserProfileController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileInsert([System.Web.Http.FromBody] AyohaUserProfileModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
            try
            {
                success = AyohaUserProfileModel.AyohaUserProfile_Insert(AP.AccountNo,AP.AccountName, AP.Email, AP.PhoneNo
      , AP.Photo, AP.UserName, AP.Katalaluan, AP.PhotoName,AP.PlayerID);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
       // [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileUpdate([System.Web.Http.FromBody] AyohaUserProfileModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
            try
            {
                success = AyohaUserProfileModel.AyohaUserProfile_Update(AP.ID,AP.AccountNo,AP.AccountName,AP.Email,AP.PhoneNo
      ,AP.Photo,AP.Gender,AP.DOB,AP.PhotoName,AP.StreetAddress,AP.Town,AP.PostCode,AP.Country,AP.Profession,AP.Hobby,AP.States);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }



          [HttpPost]
        [ValidateInput(false)]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult AyohaUserProfileUpdateKataLaluan([System.Web.Http.FromBody] AyohaUserProfileModel AP)
        {
            string success = "true";
            string _Message = string.Empty;
            List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
            try
            {
                success = AyohaUserProfileModel.AyohaUserProfile_UpdateKataLaluan(AP.ID,AP.AccountNo,AP.Katalaluan);
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                //   success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }

          [HttpPost]
          [ValidateInput(false)]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult AyohaUserProfileCheckExistingUser([System.Web.Http.FromBody] AyohaUserProfileModel AP)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_CheckExistingUser(AP.UserName, AP.Email);
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
          public JsonResult AyohaUserProfileLoginBody([System.Web.Http.FromBody] AyohaUserProfileModel AP)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_LoginBody(AP.UserName, AP.Katalaluan, AP.LoginOS, AP.LoginIP,
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



          [HttpPost]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult AyohaUserProfileCheckIsEmailExist([System.Web.Http.FromBody] AyohaUserProfileModel AP)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_CheckIsEmailExist(AP.Email);
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
          public JsonResult AyohaUserProfileCheckIsEmailExisteWallet([System.Web.Http.FromBody] AyohaUserProfileModel AP)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_CheckIsEmailExist_eWallet(AP.Email);
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
          public JsonResult AyohaUserProfileForgotPassword([System.Web.Http.FromBody] AyohaUserProfileModel AP)
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




                  success = AyohaUserProfileModel.AyohaUserProfile_ForgotPassword(AP.Email, AP.LoginOS, AP.LoginIP,
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






          [HttpGet]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult AyohaUserProfileLogin(string UserName, string KataLaluan, string LoginOS, string LoginIP,
           string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
           string PhoneSerial, string RawPhoneInfo, string PlayerID)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_Login( UserName,  KataLaluan,  LoginOS,  LoginIP,
            PhoneModel,  PhoneImeiNo,  PhoneVersion,  PhonePlatform,  PhonePlatformVersion,  PhoneManufacturer,
            PhoneSerial,  RawPhoneInfo,  PlayerID);
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
          public JsonResult AyohaUserProfileLoadProfile(string AccountNo)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_LoadProfile(AccountNo);
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
          public JsonResult AyohaUserProfileLoadByEnterpriseAccNo(string EnterpriseAccNo)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_LoadByEnterpriseAccNo(EnterpriseAccNo);
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
          public JsonResult AyohaUserProfileLoadForPointCampaign(string AccountNo, string PointCampaignCode)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_LoadForPointCampaign(AccountNo,PointCampaignCode);
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
          public JsonResult AyohaUserProfileUnClaimedTotalStampPoint(string SubscriberAccNo)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_UnClaimedTotalStampPoint(SubscriberAccNo);
              }
              catch (Exception ex)
              {
                  _Message = ex.Message;
                  success = false;
              }

              return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
          }


          [HttpPost]
          [ValidateInput(false)]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult AyohaUserProfileVerifyString([System.Web.Http.FromBody] AyohaUserProfileModel AP)
          {
              string success = "true";
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  success = AyohaUserProfileModel.AyohaUserProfile_VerifyString(AP.AccountNo);
              }
              catch (Exception ex)
              {
                  _Message = ex.Message;
                  //   success = false;
              }

              return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
          }

          [HttpGet]
          [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
          public JsonResult AyohaUserProfileLoadByPhoneNo(string PhoneNo,string SubscriberAccNo)
          {
              bool success = true;
              string _Message = string.Empty;
              List<AyohaUserProfileModel> data = new List<AyohaUserProfileModel>();
              try
              {
                  data = AyohaUserProfileModel.AyohaUserProfile_LoadByPhoneNo(PhoneNo,SubscriberAccNo);
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