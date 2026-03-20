using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class CloudReceiptsMobileUserModel
    {
        public int ID
        {
            get;
            set;
        }
        public string CR_AccountNo
        {
            get;
            set;
        }
        public string CR_MykadNo
        {
            get;
            set;
        }
        public string CR_AccountName
        {
            get;
            set;
        }
        public string CR_UseName
        {
            get;
            set;
        }
        public string CR_Password
        {
            get;
            set;
        }
        public string CR_Email
        {
            get;
            set;
        }
        public string CR_PhoneNumber
        {
            get;
            set;
        }
        public string CR_Photo
        {
            get;
            set;
        }
        public string CR_RegisterDate
        {
            get;
            set;
        }
        public string CR_Status
        {
            get;
            set;
        }
        public string CR_LastLoginDate
        {
            get;
            set;
        }
        public string CR_LoginOS
        {
            get;
            set;
        }
        public string CR_LoginIP
        {
            get;
            set;
        }
        public string CR_IsLogOut
        {
            get;
            set;
        }
        public string CR_PhoneModel
        {
            get;
            set;
        }


        public string CR_PhoneImeiNo
        {
            get;
            set;
        }
        public int CR_LoginCount
        {
            get;
            set;
        }
        public string CR_IsAutoLogin
        {
            get;
            set;
        }
        public string CR_IsRememberPwd
        {
            get;
            set;
        }
        public string CR_PhoneUniqueID
        {
            get;
            set;
        }
        public string CR_IsUserVerified
        {
            get;
            set;
        }
        public string CR_VerifyString
        {
            get;
            set;
        }







        public string CR_VeriyDate
        {
            get;
            set;
        }
        public string CR_PhonePlatform
        {
            get;
            set;
        }
        public string CR_PhoneVersion
        {
            get;
            set;
        }
        public string CR_PhoneManufacturer
        {
            get;
            set;
        }





        public string CR_PhoneIsVirtual
        {
            get;
            set;
        }
        public string CR_PhoneSerial
        {
            get;
            set;
        }
        public string CR_RawPhoneInfo
        {
            get;
            set;
        }
        public string CR_PlayerID
        {
            get;
            set;
        }

        public string CR_InitalRegisterPhoneInfo
        {
            get;
            set;
        }


        public string CR_ModifiedDate
        {
            get;
            set;
        }

        public string CR_RowActive
        {
            get;
            set;
        }
        public string CR_Version
        {
            get;
            set;
        }

        public int DayUsed
        {
            get;
            set;
        }
        public int CR_EndDateDay
        {
            get;
            set;
        }

        public int DayLeft
        {
            get;
            set;
        }
        
        public CloudReceiptsMobileUserModel() { }



        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_GetVerifyString(string CR_MykadNo)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CR_VerifyString = _SQLDataReader["CR_VerifyString"].ToString();

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
        public static bool CR_MobileUser_InsertUser(string CR_MykadNo, string CR_UseName, string CR_Password, string CR_Email, string CR_PhoneNumber
            , string CR_LoginIP, string CR_PhoneModel, string CR_PhoneUniqueID, string CR_PhonePlatform, string CR_PhoneVersion
            , string CR_PhoneManufacturer, string CR_PhoneIsVirtual, string CR_PhoneSerial, string CR_RawPhoneInfo, string CR_PlayerID)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
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
                        _SQLCommand.CommandText = "CR_MobileUser_InsertUser";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_UseName", CR_UseName);
                        _SQLCommand.Parameters.AddWithValue("@CR_Password", CR_Password);
                        _SQLCommand.Parameters.AddWithValue("@CR_Email", CR_Email);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneNumber", CR_PhoneNumber);




                        _SQLCommand.Parameters.AddWithValue("@CR_LoginIP", CR_LoginIP);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneModel", CR_PhoneModel);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneUniqueID", CR_PhoneUniqueID);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhonePlatform", CR_PhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneVersion", CR_PhoneVersion);



                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneManufacturer", CR_PhoneManufacturer);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneIsVirtual", CR_PhoneIsVirtual);
                        _SQLCommand.Parameters.AddWithValue("@CR_PhoneSerial", CR_PhoneSerial);
                        _SQLCommand.Parameters.AddWithValue("@CR_RawPhoneInfo", CR_RawPhoneInfo);
                        _SQLCommand.Parameters.AddWithValue("@CR_PlayerID", CR_PlayerID);

                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
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



            return _value;
        }

        public static bool CR_MobileUser_VerifiedUser(int ID,string CR_MykadNo)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
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
                        _SQLCommand.CommandText = "CR_MobileUser_VerifiedUser";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
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



            return _value;
        }

        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_VerifyRegistrationEmailID(string EmailID)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_VerifyRegistrationEmailID";
                        _SQLCommand.Parameters.AddWithValue("@EmailID", EmailID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CR_Email = _SQLDataReader["CR_Email"].ToString();

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
        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_VerifyRegistrationMyKadNo(string MyKadNo)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_VerifyRegistrationMyKadNo";
                        _SQLCommand.Parameters.AddWithValue("@MyKadNo", MyKadNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CR_MykadNo = _SQLDataReader["CR_MykadNo"].ToString();
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
        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_VerifyRegistrationUserName(string UserName)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_VerifyRegistrationUserName";
                        _SQLCommand.Parameters.AddWithValue("@UserName", UserName);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                           _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CR_UseName = _SQLDataReader["CR_UseName"].ToString();

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


        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_LoadUser(string UserName, string Password, string LoginIP, string PhoneModel, string PhoneUniqueID, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
            string PhoneSerialNo, string PhoneRawInfo, string CRPlayerID)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_LoadUser";
                        _SQLCommand.Parameters.AddWithValue("@UserName", UserName);
                        _SQLCommand.Parameters.AddWithValue("@Password", Password);

                        _SQLCommand.Parameters.AddWithValue("@LoginIP", LoginIP);
                        _SQLCommand.Parameters.AddWithValue("@PhoneModel", PhoneModel);
                        _SQLCommand.Parameters.AddWithValue("@PhoneUniqueID", PhoneUniqueID);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatform", PhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@PhonePlatformVersion", PhonePlatformVersion);
                        _SQLCommand.Parameters.AddWithValue("@PhoneManufacturer", PhoneManufacturer);
                        _SQLCommand.Parameters.AddWithValue("@PhoneSerialNo", PhoneSerialNo);
                        _SQLCommand.Parameters.AddWithValue("@PhoneRawInfo", PhoneRawInfo);
                        _SQLCommand.Parameters.AddWithValue("@CRPlayerID", CRPlayerID);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CR_MykadNo = _SQLDataReader["CR_MykadNo"].ToString();                                                  
                            _result.CR_AccountNo = _SQLDataReader["CR_AccountNo"].ToString();
                            _result.CR_AccountName = _SQLDataReader["CR_AccountName"].ToString();   
                            _result.CR_UseName = _SQLDataReader["CR_UseName"].ToString();
                            _result.CR_Password = _SQLDataReader["CR_Password"].ToString();
                            _result.CR_Email = _SQLDataReader["CR_Email"].ToString();
                            _result.CR_PhoneNumber = _SQLDataReader["CR_PhoneNumber"].ToString();
                            _result.CR_RegisterDate = _SQLDataReader["CR_RegisterDate"].ToString();
                            _result.CR_Status = _SQLDataReader["CR_Status"].ToString();
                            _result.CR_LastLoginDate = _SQLDataReader["CR_LastLoginDate"].ToString();
                            _result.CR_LoginIP = _SQLDataReader["CR_LoginIP"].ToString();
                            _result.CR_VeriyDate = _SQLDataReader["CR_VeriyDate"].ToString();
                            _result.CR_ModifiedDate = _SQLDataReader["CR_ModifiedDate"].ToString();
                            _result.CR_Version = _SQLDataReader["CR_Version"].ToString();
                            _result.CR_Photo = _SQLDataReader["CR_Photo"].ToString();
                            _result.DayLeft = Convert.ToInt32(_SQLDataReader["CR_EndDateDay"].ToString()) - Convert.ToInt32(_SQLDataReader["DayUsed"].ToString().Replace("-"," "));
                            
                            
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


        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_LoadMyKad(string CR_PlayerID)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_LoadMyKad";
                        _SQLCommand.Parameters.AddWithValue("@PlayerID", CR_PlayerID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();                         
                            _result.CR_MykadNo = _SQLDataReader["CR_MykadNo"].ToString();
                            _result.CR_AccountNo = _SQLDataReader["CR_AccountNo"].ToString();
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



        public static List<CloudReceiptsMobileUserModel> CR_MobileUser_RegeneratePassword(string Email,string GenID)
        {
            List<CloudReceiptsMobileUserModel> _Value = new List<CloudReceiptsMobileUserModel>();
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
                        _SQLCommand.CommandText = "CR_MobileUser_RegeneratePassword";
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        _SQLCommand.Parameters.AddWithValue("@GenID", GenID);
                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CloudReceiptsMobileUserModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CloudReceiptsMobileUserModel();
                            _result.CR_Password = _SQLDataReader["CR_Password"].ToString();
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

        public static bool CR_MobileUser_UpdateAccountInfo(int ID, string CR_AccountName, string CR_MobilePhone, string CR_Email, string CR_Photo)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
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
                        _SQLCommand.CommandText = "CR_MobileUser_UpdateAccountInfo";
              
                        _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CR_AccountName", CR_AccountName);
                        _SQLCommand.Parameters.AddWithValue("@CR_MobilePhone", CR_MobilePhone);
                        _SQLCommand.Parameters.AddWithValue("@CR_Email", CR_Email);
                        _SQLCommand.Parameters.AddWithValue("@CR_Photo", CR_Photo);
                        
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
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



            return _value;
        }






        public static bool CR_MobileUser_UpdateLoginInfo(int ID, string CR_UserName, string CR_Password)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
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
                        _SQLCommand.CommandText = "CR_MobileUser_UpdateLoginInfo";

                        _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CR_UserName", CR_UserName);
                        _SQLCommand.Parameters.AddWithValue("@CR_Password", CR_Password);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
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



            return _value;
        }






        public static bool CR_MobileUser_DisableAccount(int ID)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
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
                        _SQLCommand.CommandText = "CR_MobileUser_DisableAccount";

                        _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
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



            return _value;
        }
    }
}