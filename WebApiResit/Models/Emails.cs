using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace WebApiResit.Models
{
    public class Emails
    {

        public int ID
        {
            get;
            set;
        }


        public string Password
        {
            get;
            set;
        }

        public string sendEmailStatus
        {
            get;
            set;
        }
       
        public Emails() { }


        public static string errorEmailMsg = "";

        public static bool mail_SendMailVerifyCode(string EmailsAdd, string VerifyCode)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            bool _value = false;

            try
            {
                MailMessage o = new MailMessage("Admin@cloud-receipts.com", EmailsAdd, "Cloud-Receipts.com-Verify Account Registration", "Dear Cloud-Receipts User, " +
                 //Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for ATTract Application re-generate Password." +
                 Environment.NewLine + Environment.NewLine + " your verification code as below:" + Environment.NewLine + VerifyCode + "" +
                 Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Cloud-Receipts" +
                 Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Cloud-Receipts.com Team-ianMizi Technology Solution");
                NetworkCredential netCred = new NetworkCredential("Admin@cloud-receipts.com", "P@55w0rd");
                SmtpClient smtpobj = new SmtpClient("mail.cloud-receipts.com",25);
                smtpobj.EnableSsl = true;
                smtpobj.Credentials = netCred;
                smtpobj.Send(o);
                _value = true;

            }catch (Exception e)
            {
                _value = false;
            }
          



            return _value;


        }





        public static string  mail_SendMailForgotPassword(string EmailsAdd, string RegenPassword)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            string  _value = "true";


            //MailMessage o = new MailMessage("attract_msi@outlook.com", EmailsAdd, "ATTract-Forgot Password Re-generate", "Dear ATTract User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for ATTract Application re-generate Password." + Environment.NewLine + Environment.NewLine + " your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using ATTract application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "ATTract-MOSTI Social Innovation (MSI)");
            //NetworkCredential netCred = new NetworkCredential("attract_msi@outlook.com", "P@55w0rd");
            //SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
            //smtpobj.EnableSsl = true;
            //smtpobj.Credentials = netCred;
            //smtpobj.Send(o);

            try
            {
                MailMessage o = new MailMessage("admin@ayoha-reward.com", EmailsAdd, "Ayoha Reward Account - Forgot Password Re-generate", "Dear Ayoha Reward User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for Ayoha Reward Application re-generate Password." + Environment.NewLine + Environment.NewLine + " Your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " This Password valid 24 hours only,Please change accordingly." + Environment.NewLine  + "" + Environment.NewLine +  " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha Reward application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha Reward Team");
                NetworkCredential netCred = new NetworkCredential("admin@ayoha-reward.com", "Dsmaf@51ap");
                SmtpClient smtpobj = new SmtpClient("mail.ayoha-reward.com", 8889);
                smtpobj.EnableSsl = false;
                smtpobj.Credentials = netCred;
                smtpobj.Send(o);
            }
            catch (Exception ex)
            {
                _value = "false";
            }

           

            return _value;


        }




        public static string mail_SendMailForgotPassword_AyohaeWallet(string EmailsAdd, string RegenPassword)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string _value = "true";


            //MailMessage o = new MailMessage("attract_msi@outlook.com", EmailsAdd, "ATTract-Forgot Password Re-generate", "Dear ATTract User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for ATTract Application re-generate Password." + Environment.NewLine + Environment.NewLine + " your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using ATTract application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "ATTract-MOSTI Social Innovation (MSI)");
            //NetworkCredential netCred = new NetworkCredential("attract_msi@outlook.com", "P@55w0rd");
            //SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
            //smtpobj.EnableSsl = true;
            //smtpobj.Credentials = netCred;
            //smtpobj.Send(o);

            try
            {
               // MailMessage o = new MailMessage("admin@ayoha-reward.com", EmailsAdd, "Ayoha eWallet Account - Forgot Password Re-generate", "Dear Ayoha Reward User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for Ayoha Reward Application re-generate Password." + Environment.NewLine + Environment.NewLine + " your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha Reward application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha Reward Team");
                MailMessage o = new MailMessage("admin@ayoha-reward.com", EmailsAdd, "Ayoha eWallet Account - Forgot Password Re-generate", "Dear Ayoha eWallet User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for Ayoha eWallet Application re-generate Password." + Environment.NewLine + Environment.NewLine + " Your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " This Password valid 24 hours only,Please change accordingly." + Environment.NewLine + "" + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha eWallet application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha eWallet Team");
                NetworkCredential netCred = new NetworkCredential("admin@ayoha-reward.com", "Dsmaf@51ap");
                SmtpClient smtpobj = new SmtpClient("mail.ayoha-reward.com", 8889);
                smtpobj.EnableSsl = false;
                smtpobj.Credentials = netCred;
                smtpobj.Send(o);
            }
            catch (Exception ex)
            {
                _value = "false";
            }



            return _value;


        }





        public static string mail_SendMailTransferEwallet(string EmailsAdd, string TransferAmount)
        {

            string _value = "true";


            //MailMessage o = new MailMessage("attract_msi@outlook.com", EmailsAdd, "ATTract-Forgot Password Re-generate", "Dear ATTract User, " + Environment.NewLine + Environment.NewLine + "This is an automated email sent to you for ATTract Application re-generate Password." + Environment.NewLine + Environment.NewLine + " your new re-generate password as below:" + Environment.NewLine + RegenPassword + "" + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using ATTract application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "ATTract-MOSTI Social Innovation (MSI)");
            //NetworkCredential netCred = new NetworkCredential("attract_msi@outlook.com", "P@55w0rd");
            //SmtpClient smtpobj = new SmtpClient("smtp.live.com", 587);
            //smtpobj.EnableSsl = true;
            //smtpobj.Credentials = netCred;
            //smtpobj.Send(o);

            try
            {
                //MailMessage o = new MailMessage("admin@ayoha-reward.com", EmailsAdd, "Ayoha Reward - Transfer eWallet", "Dear Ayoha Reward User, " + Environment.NewLine + Environment.NewLine + "RM <strong> " + TransferAmount + "</strong> has been transfered to your eWallet Account." + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha Reward application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha Reward Team");
                //NetworkCredential netCred = new NetworkCredential("admin@ayoha-reward.com", "Dsmaf@51ap");

                //SmtpClient smtpobj = new SmtpClient("mail.ayoha-reward.com", 8889);               
                //smtpobj.UseDefaultCredentials = false;               
                //smtpobj.Credentials = netCred;
                //smtpobj.EnableSsl = false;
                //smtpobj.Send(o);





               System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                //       | SecurityProtocolType.Tls11
                //       | SecurityProtocolType.Tls12
                //       | SecurityProtocolType.Ssl3;




                //create the mail message 
                MailMessage mail = new MailMessage();

                //set the addresses 
                mail.From = new MailAddress("admin@ayoha-reward.com"); //IMPORTANT: This must be same as your smtp authentication address.
                mail.To.Add(EmailsAdd);

                //set the content 
                mail.Subject = "Ayoha Reward - Transfer eWallet";
                mail.Body = "Dear Ayoha Reward User, " + Environment.NewLine + Environment.NewLine + "RM <b> " + TransferAmount + "</b> has been transfered to your eWallet Account." + Environment.NewLine + Environment.NewLine + " Do not reply this email," + Environment.NewLine + "Thanks You for using Ayoha Reward application" + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Ayoha Reward Team";
                mail.IsBodyHtml = true;
                //send the message 
                SmtpClient smtp = new SmtpClient("mail.ayoha-reward.com");

                //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
                NetworkCredential Credentials = new NetworkCredential("admin@ayoha-reward.com", "Dsmaf@51ap");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = Credentials;
                smtp.Port = 8889;    //alternative port number is 8889
                smtp.EnableSsl = false;
                smtp.Send(mail); 
            }
            catch (Exception ex)
            {
                _value = "false-Email";
               
            }



            return _value;


        }



        public static List<Emails> SendEmail_CheckUserExist(string US, string Email)
        {



            List<Emails> _Value = new List<Emails>();

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
                        _SQLCommand.CommandText = "GPSUser_CheckUserExist";
                        _SQLCommand.Parameters.AddWithValue("@UserName", US);
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        //  _SQLCommand.Parameters.AddWithValue("@count", count);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        Emails _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new Emails();
                            _result.Password = _SQLDataReader["Password"].ToString();
                            _Value.Add(_result);



                        }
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                    finally
                    {
                        _DBConnection.Close();



                    }

                }

            }
            return _Value;
        }


        public static List<Emails> SendEmail_ForgotPassword(string US, string Email)
        {

            List<Emails> _Value = new List<Emails>();
            string regeneratePassword = "";
            bool sendEmail = false;
            Emails _result;
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
                        _SQLCommand.CommandText = "GPSUser_ForgotPassword";
                        _SQLCommand.Parameters.AddWithValue("@UserName", US);
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        //  _SQLCommand.Parameters.AddWithValue("@count", count);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        while (_SQLDataReader.Read())
                        {

                            regeneratePassword = _SQLDataReader["Password"].ToString();





                        }
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                    finally
                    {
                        _DBConnection.Close();


                        //sendEmail = mail_SendMailForgotPassword(Email, regeneratePassword);
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
            return _Value;
        }



        //public static List<Emails> SendEmail_VerifyRegistrationCode(string CR_MykadNo, string Email)
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



    }
}