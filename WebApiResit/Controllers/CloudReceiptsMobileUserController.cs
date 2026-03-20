using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApiResit.Models;

namespace WebApiResit.Controllers
{
    public class CloudReceiptsMobileUserController : Controller
    {
        //
        // GET: /CloudReceiptsMobileUser/
        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult CRMobileUserVerifyRegistrationEmailID(string EmailID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_VerifyRegistrationEmailID(EmailID);
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
        public JsonResult CRMobileUserVerifyRegistrationMyKadNo(string MyKadNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_VerifyRegistrationMyKadNo(MyKadNo);
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
        public JsonResult CRMobileUserVerifyRegistrationUserName(string UserName)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_VerifyRegistrationUserName(UserName);
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
        public JsonResult CRMobileUserInsertUser(string CR_MykadNo, string CR_UseName, string CR_Password, string CR_Email, string CR_PhoneNumber
              , string CR_LoginIP, string CR_PhoneModel, string CR_PhoneUniqueID, string CR_PhonePlatform, string CR_PhoneVersion
            , string CR_PhoneManufacturer, string CR_PhoneIsVirtual, string CR_PhoneSerial, string CR_RawPhoneInfo, string CR_PlayerID)
        {
         
      
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                success = CloudReceiptsMobileUserModel.CR_MobileUser_InsertUser(CR_MykadNo, CR_UseName, CR_Password, CR_Email, CR_PhoneNumber, CR_LoginIP, CR_PhoneModel
                    , CR_PhoneUniqueID, CR_PhonePlatform, CR_PhoneVersion, CR_PhoneManufacturer, CR_PhoneIsVirtual, CR_PhoneSerial, CR_RawPhoneInfo, CR_PlayerID);
                //if(success)
                //{ success=SendEmail_VerifyRegistrationCode(CR_MykadNo, CR_Email); }
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
        public JsonResult CRMobileUserGetVerifyString(string CR_MykadNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_GetVerifyString(CR_MykadNo);
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
        public JsonResult CRMobileUserVerifiedUser(int ID,string CR_MykadNo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                success = CloudReceiptsMobileUserModel.CR_MobileUser_VerifiedUser(ID,CR_MykadNo);
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
        public JsonResult CRMobileUserLoadUser(string UN,string PWD,  string LoginIP, string PhoneModel, string PhoneUniqueID, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
            string PhoneSerialNo, string PhoneRawInfo, string CRPlayerID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_LoadUser(UN, PWD, LoginIP,  PhoneModel,  PhoneUniqueID,  PhonePlatform,  PhonePlatformVersion,  PhoneManufacturer,
             PhoneSerialNo,  PhoneRawInfo,  CRPlayerID);
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
        public JsonResult CRMobileUserLoadMyKad(string CR_PlayerID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_LoadMyKad(CR_PlayerID);
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

        public JsonResult CRMobileUserRegeneratePassword(string Email, string GenID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                data = CloudReceiptsMobileUserModel.CR_MobileUser_RegeneratePassword(Email, GenID);
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
        public JsonResult CRMobileUserSenSMS(string CR_VerifyCode, string CR_PhoneNumber)
        {

          
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {


                String message = HttpUtility.UrlEncode("Cloud Receipts.com verification code:" + CR_VerifyCode + "" + Environment.NewLine + "Thank you" + Environment.NewLine + "ianMizi Technology Solution");
                //SendSMSToURL("http://www.isms.com.my/isms_send.php?un=username&pwd=password&dstno=60123456789&msg=" + message + "&type=1&sendid=12345");

                SendSMSToURL("https://www.isms.com.my/isms_send.php?un=ianMizi&pwd=P@55w0rd&dstno=" + CR_PhoneNumber + "&msg=" + message + "&type=1&sendid=" + CR_PhoneNumber + '-' + CR_VerifyCode + "");
                //success = CloudReceiptsMobileUserModel.CR_MobileUser_InsertUser(CR_MykadNo, CR_UseName, CR_Password, CR_Email, CR_PhoneNumber);
                //if(success)
                //{ success=SendEmail_VerifyRegistrationCode(CR_MykadNo, CR_Email); }
            }
            catch (Exception ex)
            {
                _Message = ex.Message;
                success = false;
            }

            return Json(new { success = success, message = _Message, total = data.Count, results = data }, JsonRequestBehavior.AllowGet);
        }




        private static string SendSMSToURL(string getUri)
        {
            string SentResult = String.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUri);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader responseReader = new StreamReader(response.GetResponseStream());

            String resultmsg = responseReader.ReadToEnd();
            responseReader.Close();

            int StartIndex = 0;
            int LastIndex = resultmsg.Length;

            if (LastIndex > 0)
                SentResult = resultmsg.Substring(StartIndex, LastIndex);

            responseReader.Dispose();

            return SentResult;
        }


        public static bool SendEmail_VerifyRegistrationCode(string CR_MykadNo, string Email)
        {


            string CR_VerifyString = "";
            string ID;
            bool sendEmail = false;
            bool _value = false;
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            using (SqlConnection _DBConnection = _SQLConnection)
            {

                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                using (_SQLCommand)
                {
                    try
                    {
                        _SQLCommand.Connection = _DBConnection;
                        _SQLCommand.CommandText = "CR_MobileUser_GetVerifyString";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", @CR_MykadNo);

                        //  _SQLCommand.Parameters.AddWithValue("@count", count);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        while (_SQLDataReader.Read())
                        {
                            ID = _SQLDataReader["ID"].ToString();
                            CR_VerifyString = _SQLDataReader["CR_VerifyString"].ToString();





                        }
                        _value = true;
                    }
                    catch (Exception ex)
                    {
                        _value = false;
                        throw new Exception(ex.Message);


                    }

                    finally
                    {
                        _DBConnection.Close();


                        sendEmail = mail_SendMailVerifyCode(Email, CR_VerifyString);
                        _value = sendEmail;
                        //_result = new Emails();
                        //if (sendEmail == true)
                        //{
                        //    _result.Password = "true";
                        //    _Value.Add(_result);
                        //}
                        //else
                        //{
                        //    _result.Password = "false";
                        //    _Value.Add(_result);
                        //}



                    }

                }

            }
            return _value;
        }
        public static bool mail_SendMailVerifyCode(string EmailsAdd, string VerifyCode)
        {

            bool _value = false;

            try
            {
                MailMessage o = new MailMessage("Admin@cloud-receipts.com", EmailsAdd, "Cloud-Receipts.com-Verify Account Registration", "Dear Cloud-Receipts User, " +
                    //Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for ATTract Application re-generate Password." +
                 Environment.NewLine + Environment.NewLine + " your verification code as below:" + Environment.NewLine + VerifyCode + "" +
                 Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Cloud-Receipts" +
                 Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Cloud-Receipts.com Team-ianMizi Technology Solution");
                NetworkCredential netCred = new NetworkCredential("Admin@cloud-receipts.com", "P@55w0rd");
                SmtpClient smtpobj = new SmtpClient("mail.cloud-receipts.com", 25);
                smtpobj.EnableSsl = true;
                smtpobj.Credentials = netCred;
                smtpobj.Send(o);
                _value = true;

            }
            catch (Exception e)
            {
                _value = false;
            }




            return _value;


        }





        [HttpPost]
        [EnableCors(origins: "*", headers: "X-Requested-With", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public JsonResult CRMobileUserUpdateAccountInfo(int ID, string CR_AccountName, string CR_MobilePhone, string CR_Email, string CR_Photo)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                success = CloudReceiptsMobileUserModel.CR_MobileUser_UpdateAccountInfo(ID, CR_AccountName, CR_MobilePhone, CR_Email, CR_Photo);
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
        public JsonResult CRMobileUserUpdateLoginInfo(int ID, string CR_UserName, string CR_Password)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                success = CloudReceiptsMobileUserModel.CR_MobileUser_UpdateLoginInfo(ID, CR_UserName, CR_Password);
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
        public JsonResult CRMobileUserDisableAccount(int ID)
        {
            bool success = true;
            string _Message = string.Empty;
            List<CloudReceiptsMobileUserModel> data = new List<CloudReceiptsMobileUserModel>();
            try
            {
                success = CloudReceiptsMobileUserModel.CR_MobileUser_DisableAccount(ID);
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