using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
namespace WebApiResit.Models
{
    public class OneSignalModel
    {
    //    static string PlayerID;
    //    static string PremisName;
    //    static string FinalAmout;
    //    static string PaymentType;
    //    static int ID;

        public int ID
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }
        public string PremisName
        {
            get;
            set;
        }
        public string FinalAmout
        {
            get;
            set;
        }
        public string PaymentType
        {
            get;
            set;
        }

        public string AccountName
        {
            get;
            set;
        }
        public string OneSignalAPIRespond
        {
            get;
            set;
        }
        public OneSignalModel() { }


        public static bool OneSignalSendBy_PlayerID(int ID)
        {

            //SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
            //using (SqlConnection _DBConnection = _SQLConnection)
            //{
            //    SqlCommand _SQLCommand = new SqlCommand();
            //    _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //    _SQLCommand.CommandTimeout = 0;
            //    using (_SQLCommand)
            //    {
            //        try
            //        {
            //            _SQLCommand.Connection = _DBConnection;
            //            _SQLCommand.CommandText = "CR_MobileUser_VerifiedUser";
            //            _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
            //            _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
            //            _DBConnection.Open();
            //            _SQLCommand.ExecuteNonQuery();
            //        }

            //        catch (Exception ex)
            //        {
            //            _value = false;
            //        }

            //        finally
            //        {

            //            _DBConnection.Close();

            //        }

            //    }

            //}






            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic NWEyYjJlZmItODA5Ny00MjE1LTgwM2EtOTFhYjJmNmNmZGU4");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "eb840aed-ded6-4a47-96d0-e3276962852b",
                contents = new { en = "English Message-TEST" },
                include_player_ids = new string[] { "33da98d8-5087-4514-b362-d90ab32bcb81", "8db218cc-a35b-400b-9b67-c933b2a6942f" }
            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                _value = false;
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);

            return _value;
        }



        public static bool OneSignalSend_PushNotification(string MyKad)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            List<string> SendItems = new List<string>();
            bool _value = true;




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
                        _SQLCommand.CommandText = "OneSignal_SendPushNotification";
                        _SQLCommand.Parameters.AddWithValue("@MyKad", MyKad);

                        _DBConnection.Open();


                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        //   OneSignalModel _result;
                        while (_SQLDataReader.Read())
                        {
                            //_result = new OneSignalModel();
                            //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            //_result.PlayerID = _SQLDataReader["CR_PlayerID"].ToString();
                            //_result.PremisName = _SQLDataReader["FlatBillWorkshop"].ToString();
                            //_result.FinalAmout = _SQLDataReader["FlatBillFinalAmount"].ToString();
                            //_result.PaymentType = _SQLDataReader["FlatBillPaymentType"].ToString();
                            //SendItems.Add(_result);

                            _value = onesignalAPI(_SQLDataReader["FlatBillWorkshop"].ToString(), _SQLDataReader["FlatBillFinalAmount"].ToString(), _SQLDataReader["FlatBillCurrentPaid"].ToString(), _SQLDataReader["FlatBillPaymentType"].ToString(), _SQLDataReader["CR_PlayerID"].ToString(), _SQLDataReader["FlatBillShotDesc"].ToString());

                        }
                        //   _value = onesignalAPI(_result.PremisName, _result.FinalAmout, _result.PaymentType, _result.PlayerID);

                        //   _value = onesignalAPI(PremisName, FinalAmout, PaymentType, PlayerID);
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();


                    }

                }

            }


            //_value = onesignalAPI(_r, FinalAmout, PaymentType, PlayerID);




            return _value;
        }



        public static void onesignalAPI_AyohaNotification_Notification(string Merchant, string Title,string PlayerID)
        {



            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = Merchant },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Notification" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Title:" + Title },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
               // return false;
            }

          //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }









        //public static string onesignalAPI_AyohaNotification_UserProfileCreated(string AccountName,  string PlayerID)
        public static List<OneSignalModel> onesignalAPI_AyohaNotification_UserProfileCreated(string AccountName, string PlayerID)
            
        {

            List<OneSignalModel> _Value = new List<OneSignalModel>();

            //var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            //request.KeepAlive = true;
            //request.Method = "POST";
            //request.ContentType = "application/json; charset=utf-8";

            //request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            //var serializer = new JavaScriptSerializer();
            //var obj = new
            //{
            //    app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
            //    // collapse_id="collapse"+PlayerID,
            //    headings = new { en = "Welcome to Ayoha Reward!" },
            //    android_group = "AyohaReward",
            //    android_group_message = new { en = "You have $[notif_count] New Notification" },
            //    //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
            //    //include_player_ids = new string[] { PlayerID }
            //    contents = new { en = "Title:Dear (Mr/Ms)" + AccountName +",Thank you for joining Ayoha reward."+ Environment.NewLine +"100 Ayoha Points has been credited into your account.!"},
            //    include_player_ids = new string[] { PlayerID }



            //};



            //var param = serializer.Serialize(obj);
            //byte[] byteArray = Encoding.UTF8.GetBytes(param);

            //string responseContent = null;

            //try
            //{
            //    using (var writer = request.GetRequestStream())
            //    {
            //        writer.Write(byteArray, 0, byteArray.Length);
            //    }

            //    using (var response = request.GetResponse() as HttpWebResponse)
            //    {
            //        using (var reader = new StreamReader(response.GetResponseStream()))
            //        {
            //            responseContent = reader.ReadToEnd();
            //        }
            //    }
            //}
            //catch (WebException ex)
            //{

            //    System.Diagnostics.Debug.WriteLine(ex.Message);
            //    System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            //    // return false;
            //}




            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = "Welcome to Ayoha Reward!" },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Notification" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Title:Dear (Mr/Ms)" + AccountName + ",Thank you for joining Ayoha reward." + Environment.NewLine + "100 Ayoha Points has been credited into your Ayoha Points Account.!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;
            OneSignalModel _result;
            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        _result = new OneSignalModel();
                        responseContent = reader.ReadToEnd();
                        _result.OneSignalAPIRespond = reader.ReadToEnd();
                        _Value.Add(_result);
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }


            return _Value;

        }








        public static void onesignalAPI_AyohaNotification_SendPointNotification_OLD(string PlayerID,string EnterpriseName,string Points)
        {



            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = EnterpriseName },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Point" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Congratulation!:" + Points + "- Points has been credited to your Ayoha Point (AP) and "+ EnterpriseName +" Merchant Point (MP).!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }

        public static void onesignalAPI_AyohaNotification_SendPointNotification_Stamp(string PlayerID, string EnterpriseName, string Points)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = EnterpriseName },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Point" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Congratulation!:" + Points + "- Points has been credited to your Ayoha Point (AP).!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }

        public static void onesignalAPI_AyohaNotification_SendPointNotification_Point(string PlayerID, string EnterpriseName, string Points)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = EnterpriseName },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Point" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Congratulation!:" + Points + "- Points has been credited to your Ayoha Point (AP) and " + EnterpriseName + " Merchant Point (MP).!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }




        public static void onesignalAPI_AyohaNotification_SendPointNotification_AyohaStoreMakePayment(string PlayerID, string EnterpriseName, string MerchantPoint,string AyohaPoint)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = EnterpriseName },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] New Point" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Congratulation!:" + AyohaPoint + "- Points has been credited to your Ayoha Point (AP) and " + MerchantPoint + "- Points has been credited to your " + EnterpriseName + " Merchant Point (MP).!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }




        public static void onesignalAPI_AyohaNotification_SendPointNotification_AyohaeWalletSuccesTopUp(string PlayerID, string Amount)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = "Ayoha-Reward.Com" },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] Ayoha eWallet TopUp" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Ayoha eWallet TopUp!:RM" + Amount + "-  has been successfully credited into your Ayoha eWallet account,Thank You!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }



        public static void onesignalAPI_AyohaNotification_SendPointNotification_AyohaeWalletTransfer(string PlayerID, string Amount)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ODZkNzcxNWQtZGFjMi00ODg4LTk5NWEtMTZhMTU3YWMyNjdi");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "f8370607-3c1b-417b-b819-77e839ae50b1",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = "Ayoha-Reward.Com" },
                android_group = "AyohaReward",
                android_group_message = new { en = "You have $[notif_count] Ayoha eWallet Transferred" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "Ayoha eWallet:RM" + Amount + "-  has been  successfully transferred into your Ayoha eWallet account,Thank You!" },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                // return false;
            }

            //  return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }

        public static bool onesignalAPI(string PremisName, string FinalAmout,string FlatBillCurrentPaid, string PaymentType, string PlayerID, string FlatBillShotDesc)
        {



            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic NWEyYjJlZmItODA5Ny00MjE1LTgwM2EtOTFhYjJmNmNmZGU4");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "eb840aed-ded6-4a47-96d0-e3276962852b",
                // collapse_id="collapse"+PlayerID,
                headings = new { en = "Cloud-Receipts.Com" },
                android_group = "CReceipts",
                android_group_message = new { en = "You have $[notif_count] new receipts" },
                //contents = new { en = "New Receipts:" + PremisName + Environment.NewLine + "Total Paid:" + FinalAmout + Environment.NewLine + "Payment Type:" + PaymentType },
                //include_player_ids = new string[] { PlayerID }
                contents = new { en = "New Receipts:" + PremisName + ". Desc:" + FlatBillShotDesc + ". Total Paid:" + FinalAmout + "" + FlatBillCurrentPaid + ". Payment Type:" + PaymentType },
                include_player_ids = new string[] { PlayerID }



            };



            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
                return false;
            }

            return true;
            //  System.Diagnostics.Debug.WriteLine(responseContent);






        }
    }
}