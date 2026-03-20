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
    public class SMSModel
    {
        public string AccountNo
        {
            get;
            set;
        }
        public string VerifyString
        {
            get;
            set;
        }

        public string PhoneNo
        {
            get;
            set;
        }






        public string LoginOS
        {
            get;
            set;
        }
        public string LoginIP
        {
            get;
            set;
        }

        public string PhoneModel
        {
            get;
            set;
        }





        public string PhoneImeiNo
        {
            get;
            set;
        }
        public string PhoneVersion
        {
            get;
            set;
        }

        public string PhonePlatform
        {
            get;
            set;
        }







        public string PhonePlatformVersion
        {
            get;
            set;
        }
        public string PhoneManufacturer
        {
            get;
            set;
        }

        public string PhoneSerial
        {
            get;
            set;
        }



        public string RawPhoneInfo
        {
            get;
            set;
        }

        public string PlayerID 
        {
            get;
            set;
        }

        public string isAllowedSendSMS 
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public string StringVerify
        {
            get;
            set;
        }

        public string IsSendSMSAllowed
        {
            get;
            set;
        }

       // public string PhoneNo { get; set; }
    public string Message { get; set; }
    public string Status { get; set; } // "Success", "Failed", "Error", etc.
    public string ApiResponse { get; set; } // Raw API response for logging
        public SMSModel() { }






        public static List<SMSModel> AyohaUserProfile_GetVerifyString(string AccountNo, string PhoneNo, string LoginOS, string LoginIP, string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform
            , string PhonePlatformVersion, string PhoneManufacturer, string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<SMSModel> _Value = new List<SMSModel>();
            string _value = "true";
           
            SMSModel _resulted = new SMSModel();
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
                        _SQLCommand.CommandText = "AyohaUserProfile_GetVerifyString";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@LoginOS", LoginOS);
                        _SQLCommand.Parameters.AddWithValue("@LoginIP", LoginIP);
                        _SQLCommand.Parameters.AddWithValue("@PhoneModel", PhoneModel);
                        _SQLCommand.Parameters.AddWithValue("@PhoneImeiNo", PhoneImeiNo);
                        _SQLCommand.Parameters.AddWithValue("@PhoneVersion", PhoneVersion);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatform", PhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatformVersion", PhonePlatformVersion);
                        _SQLCommand.Parameters.AddWithValue("@PhoneManufacturer", PhoneManufacturer);
                        _SQLCommand.Parameters.AddWithValue("@PhoneSerial", PhoneSerial);
                        _SQLCommand.Parameters.AddWithValue("@RawPhoneInfo", RawPhoneInfo);
                        _SQLCommand.Parameters.AddWithValue("@PlayerID", PlayerID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                         SMSModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _resulted.StringVerify = _SQLDataReader["VerifyString"].ToString();
                            _resulted.PhoneNumber = _SQLDataReader["PhoneNo"].ToString();
                            _resulted.IsSendSMSAllowed = isAllowedToSendSMS(Convert.ToInt32(_SQLDataReader["CountSendSMS"].ToString()));

                             _result = new SMSModel();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                       
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                          
                            _result.isAllowedSendSMS = isAllowedToSendSMS(Convert.ToInt32(_SQLDataReader["CountSendSMS"].ToString()));
                           _Value.Add(_result);


                          
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new Exception(ex.Message);
                        _value = "false," + ex.ToString(); ;
                    }

                    finally
                    {
                        _DBConnection.Close();

                        if (_resulted.IsSendSMSAllowed == "Allowed")
                        {
                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                | SecurityProtocolType.Tls11
                                | SecurityProtocolType.Tls12;

                          
                            SMSModel resultModel = new SMSModel();

                            try
                            {
                                string msg = "Ayoha Reward: Your verification Code is:" + _resulted.StringVerify;
                                String _message = HttpUtility.UrlEncode(msg);
                               
                                // Pastikan nombor bermula dengan 60 dan tiada +
                                string formattedPhone = PhoneNo.StartsWith("6") ? PhoneNo : "6" + PhoneNo;

                                // string uri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination={formattedPhone}&sender=IanMizi&body={encodedMsg}";
                               // string uri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination=6" + PhoneNo + "&sender=IanMizi&body=" + encodedMsg;
                                string uri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination=" + formattedPhone + "&sender=IanMizi&body=" + _message;

                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                                request.Method = "GET";

                                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                                {
                                    string apiResponse = reader.ReadToEnd();

                                    resultModel.PhoneNo = formattedPhone;
                                    resultModel.Message = msg;
                                    resultModel.ApiResponse = apiResponse;

                                    // Contoh: check kalau response mengandungi "OK"
                                    resultModel.Status = apiResponse.Contains("OK") ? "Success" : "Failed";
                                }
                            }
                            catch (WebException ex)
                            {
                                resultModel.Status = "Error";
                                resultModel.ApiResponse = ex.Message;
                            }
                            catch (Exception ex)
                            {
                                resultModel.Status = "Exception";
                                resultModel.ApiResponse = ex.Message;
                            }

                            _Value.Add(resultModel);
                            
                        }
                       
                        



                        


                    }

                }

            }
            return _Value;
        }


        public static List<SMSModel> AyohaUserProfile_GetVerifyStringORI(string AccountNo, string PhoneNo, string LoginOS, string LoginIP, string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform
          , string PhonePlatformVersion, string PhoneManufacturer, string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<SMSModel> _Value = new List<SMSModel>();
            string _value = "true";

            SMSModel _resulted = new SMSModel();
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
                        _SQLCommand.CommandText = "AyohaUserProfile_GetVerifyString";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@LoginOS", LoginOS);
                        _SQLCommand.Parameters.AddWithValue("@LoginIP", LoginIP);
                        _SQLCommand.Parameters.AddWithValue("@PhoneModel", PhoneModel);
                        _SQLCommand.Parameters.AddWithValue("@PhoneImeiNo", PhoneImeiNo);
                        _SQLCommand.Parameters.AddWithValue("@PhoneVersion", PhoneVersion);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatform", PhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatformVersion", PhonePlatformVersion);
                        _SQLCommand.Parameters.AddWithValue("@PhoneManufacturer", PhoneManufacturer);
                        _SQLCommand.Parameters.AddWithValue("@PhoneSerial", PhoneSerial);
                        _SQLCommand.Parameters.AddWithValue("@RawPhoneInfo", RawPhoneInfo);
                        _SQLCommand.Parameters.AddWithValue("@PlayerID", PlayerID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        SMSModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _resulted.StringVerify = _SQLDataReader["VerifyString"].ToString();
                            _resulted.PhoneNumber = _SQLDataReader["PhoneNo"].ToString();
                            _resulted.IsSendSMSAllowed = isAllowedToSendSMS(Convert.ToInt32(_SQLDataReader["CountSendSMS"].ToString()));

                            _result = new SMSModel();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();

                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();

                            _result.isAllowedSendSMS = isAllowedToSendSMS(Convert.ToInt32(_SQLDataReader["CountSendSMS"].ToString()));
                            _Value.Add(_result);




                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new Exception(ex.Message);
                        _value = "false," + ex.ToString(); ;
                    }

                    finally
                    {
                        _DBConnection.Close();

                        if (_resulted.IsSendSMSAllowed == "Allowed")
                        {
                            try
                            {
                                string msg = "Ayoha Reward: Your verification Code is:" + _resulted.StringVerify;
                                String _message = HttpUtility.UrlEncode(msg);
                                string getUri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination=6" + _resulted.PhoneNumber + "&sender=IanMizi&body=" + _message;
                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUri);
                                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                StreamReader responseReader = new StreamReader(response.GetResponseStream());
                                String resultmsg = responseReader.ReadToEnd();
                                responseReader.Close();
                                int StartIndex = 0;
                                int LastIndex = resultmsg.Length;
                                if (LastIndex > 0)
                                    _value = resultmsg.Substring(StartIndex, LastIndex);
                                responseReader.Dispose();
                                _value = "true";
                            }
                            catch (Exception x)
                            {
                                _value = "false";

                            }
                        }








                    }

                }

            }
            return _Value;
        }


        public static List<SMSModel> DisasterNow_VerifyTACORI( string PhoneNo, string PlayerID)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;


            List<SMSModel> _Value = new List<SMSModel>();
            string _value = "true";

            try
            {
                string msg = "Disaster Now: Your TAC Code is:" + PlayerID;
                String _message = HttpUtility.UrlEncode(msg);
                string getUri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination=6" + PhoneNo + "&sender=IanMizi&body=" + _message;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader responseReader = new StreamReader(response.GetResponseStream());
                String resultmsg = responseReader.ReadToEnd();
                responseReader.Close();
                int StartIndex = 0;
                int LastIndex = resultmsg.Length;
                if (LastIndex > 0)
                    _value = resultmsg.Substring(StartIndex, LastIndex);
                responseReader.Dispose();
                _value = "true";
            }
            catch (Exception x)
            {
                _value = "false";

            }










           
            
            return _Value;
        }

        public static List<SMSModel> DisasterNow_VerifyTAC(string PhoneNo, string PlayerID)
{
    ServicePointManager.Expect100Continue = true;
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        | SecurityProtocolType.Tls11
        | SecurityProtocolType.Tls12;

    List<SMSModel> resultList = new List<SMSModel>();
    SMSModel resultModel = new SMSModel();

    try
    {
        string msg = "Disaster Now: Your TAC Code is:"+PlayerID;
        string encodedMsg = HttpUtility.UrlEncode(msg);

        // Pastikan nombor bermula dengan 60 dan tiada +
        string formattedPhone = PhoneNo.StartsWith("6") ? PhoneNo : "6" + PhoneNo;

       // string uri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination={formattedPhone}&sender=IanMizi&body={encodedMsg}";
        string uri = "https://ic1.silverstreet.com/send.php?username=tarmizi&password=Jga2AFx5&destination=" + PhoneNo + "&sender=IanMizi&body=" + encodedMsg;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.Method = "GET";

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        {
            string apiResponse = reader.ReadToEnd();

            resultModel.PhoneNo = formattedPhone;
            resultModel.Message = msg;
            resultModel.ApiResponse = apiResponse;

            // Contoh: check kalau response mengandungi "OK"
            resultModel.Status = apiResponse.Contains("OK") ? "Success" : "Failed";
        }
    }
    catch (WebException ex)
    {
        resultModel.Status = "Error";
        resultModel.ApiResponse = ex.Message;
    }
    catch (Exception ex)
    {
        resultModel.Status = "Exception";
        resultModel.ApiResponse = ex.Message;
    }

    resultList.Add(resultModel);
    return resultList;
}


        public static string isAllowedToSendSMS(int CountSMSSend)
        {
            string val = "";

            if (CountSMSSend <= 2)
            {
                val = "Allowed";
            }
            if (CountSMSSend >= 3)
            {
                val = "NotAllowed";
            }

            return val;
        }

    }
}