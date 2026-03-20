using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaeWalletModel
    {
        public int ID
        {
            get;
            set;
        }

        public string eWalletAccNo
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }
        public string eWalletType
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }


        public string eWalletStatus
        {
            get;
            set;
        }
        public string CreditLimitPerDay
        {
            get;
            set;
        }
        public string DebitLimitPerDay
        {
            get;
            set;
        }
        public string eWalletCurrentBalance
        {
            get;
            set;
        }



        public string PassCode
        {
            get;
            set;
        }
        public string DeviceID
        {
            get;
            set;
        }


        public string isUsedDeviceID_Detection
        {
            get;
            set;
        }
        public string isUsedTAC_Code
        {
            get;
            set;
        }

        public AyohaeWalletModel() { }



        public static List<AyohaeWalletModel> AyohaeWallet_LoadeWallet(string eWalletAccNo)
        {
            List<AyohaeWalletModel> _Value = new List<AyohaeWalletModel>();

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
                        _SQLCommand.CommandText = "AyohaeWallet_LoadeWallet";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaeWalletModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.eWalletType = _SQLDataReader["eWalletType"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.eWalletStatus = _SQLDataReader["eWalletStatus"].ToString();
                            _result.CreditLimitPerDay = _SQLDataReader["CreditLimitPerDay"].ToString();
                            _result.DebitLimitPerDay = _SQLDataReader["DebitLimitPerDay"].ToString();
                            _result.eWalletCurrentBalance = _SQLDataReader["eWalletCurrentBalance"].ToString();
                            _result.PassCode = _SQLDataReader["PassCode"].ToString();
                            _result.DeviceID = _SQLDataReader["DeviceID"].ToString();
                            _result.isUsedDeviceID_Detection = _SQLDataReader["isUsedDeviceID_Detection"].ToString();
                            _result.isUsedTAC_Code = _SQLDataReader["isUsedTAC_Code"].ToString();

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




        public static string AyohaeWallet_Insert(string eWalletAccNo, string eWalletType, string DebitLimitPerDay, string PassCode,  string isUsedDeviceID_Detection, string isUsedTAC_Code)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaeWallet_Insert";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@eWalletType", eWalletType);
                        _SQLCommand.Parameters.AddWithValue("@DebitLimitPerDay", DebitLimitPerDay);
                        _SQLCommand.Parameters.AddWithValue("@PassCode", PassCode);
                      //  _SQLCommand.Parameters.AddWithValue("@DeviceID", DeviceID);
                        _SQLCommand.Parameters.AddWithValue("@isUsedDeviceID_Detection", isUsedDeviceID_Detection);
                        _SQLCommand.Parameters.AddWithValue("@isUsedTAC_Code", isUsedTAC_Code);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                        // _value = ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();



                    }

                }

            }





            return _value;



        }





        public static string AyohaeWallet_Update(string eWalletAccNo, string PassCode, string isUsedDeviceID_Detection, string isUsedTAC_Code)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaeWallet_Update";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PassCode", PassCode);
                        //  _SQLCommand.Parameters.AddWithValue("@DeviceID", DeviceID);
                        _SQLCommand.Parameters.AddWithValue("@isUsedDeviceID_Detection", isUsedDeviceID_Detection);
                        _SQLCommand.Parameters.AddWithValue("@isUsedTAC_Code", isUsedTAC_Code);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                        // _value = ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();



                    }

                }

            }





            return _value;



        }




        public static string AyohaeWallet_UpdateDebitLimit(string eWalletAccNo, string DebitLimitPerDay)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaeWallet_UpdateDebitLimit";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@DebitLimitPerDay", DebitLimitPerDay);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                        // _value = ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();



                    }

                }

            }





            return _value;



        }




        public static string reGeneratePwdNoWallet()
        {
            string val = "";

            Random rnd = new Random();
            //int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            //int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            //int card = rnd.Next(5555);

            //val = month.ToString() + dice.ToString() + card.ToString();
            val = rnd.Next(0, 1000000).ToString("000000");

            return val;
        }

    // 14787


        public static string AyohaeWallet_ForgotPassword(string Email,string AccountNo, string LoginOS, string LoginIP,
     string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
     string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            AyohaeWalletModel a = new AyohaeWalletModel();

            a.PassCode = reGeneratePwdNoWallet();

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";
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
                        _SQLCommand.CommandText = "AyohaeWallet_ForgotPassword";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@Katalaluan", a.PassCode);
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
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString();
                        // _value = ex.ToString();
                    }

                    finally
                    {
                        _DBConnection.Close();
                        _value = Emails.mail_SendMailForgotPassword_AyohaeWallet(Email, a.PassCode);

                    }

                }

            }



            return _value;
        }

    }
}