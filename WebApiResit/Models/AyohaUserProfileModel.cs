using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaUserProfileModel
    {
      
  

        public int ID
        {
            get;
            set;
        }

        public string AccountNo
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }
        public string Photo
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }


         public string DOB
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }
        public string ModifiedDate
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }

         public string Katalaluan
        {
            get;
            set;
        }
        public string LastLoginDate
        {
            get;
            set;
        }

        public string PhotoName
        {
            get;
            set;
        }
        


            public string GUID
        {
            get;
            set;
        }
        public string isUserVerified
        {
            get;
            set;
        }

        public string VerifyString
        {
            get;
            set;
        }


        public string AyohaVersion
        {
            get;
            set;
        }



        public int UnClaimedTotalPoint
        {
            get;
            set;
        }
        public int UnClaimedTotalStamp
        {
            get;
            set;
        }


           public int NextRedeemPoint
        {
            get;
            set;
        }
        public int NextRedeemStamp
        {
            get;
            set;
        }
        public string AyohaUserGroupCode
        {
            get;
            set;
        }


         public string PointAmountEquation
        {
            get;
            set;
        }

         public string RequiredReceiptBillNo
        {
            get;
            set;
        }


         public string EnterpriseAccNo
         {
             get;
             set;
         }


         public string PlayerID
         {
             get;
             set;
         }


         public int RowNumber
         {
             get;
             set;
         }
        




        /// <summary>
        /// ///login log model
        /// </summary>
        /// 


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



         public string AllowToSendEmail
         {
             get;
             set;
         }

         public string UserVerifiedDate
         {
             get;
             set;
         }

         public string Email_Debit
         {
             get;
             set;
         }



















         public string StreetAddress
         {
             get;
             set;
         }


         public string Town
         {
             get;
             set;
         }



         public string PostCode
         {
             get;
             set;
         }

         public string Country
         {
             get;
             set;
         }

         public string Profession
         {
             get;
             set;
         }

         public string Hobby
         {
             get;
             set;
         }
         public string States
         {
             get;
             set;
         }

         public string AyohaeWalletTransactionTransactionType
         {
             get;
             set;
         }
        
        
        public AyohaUserProfileModel() { }


      //  public static string AyohaUserProfile_Insert(string AccountNo, string AccountName, string Email, string PhoneNo
      //, string Photo, string Gender, string DOB, string UserName, string Katalaluan,string PhotoName)
        public static string AyohaUserProfile_Insert(string AccountNo, string AccountName, string Email, string PhoneNo
   , string Photo, string UserName, string Katalaluan, string PhotoName, string PlayerID)
        {
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
                        _SQLCommand.CommandText = "AyohaUserProfile_Insert";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@AccountName", AccountName);
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@Photo", "https://setkita.com/AyohaImgCard/AyohaUserPicProfile/" + AccountNo + "/" + PhotoName);
                        //_SQLCommand.Parameters.AddWithValue("@Gender", Gender);
                        //_SQLCommand.Parameters.AddWithValue("@DOB", DOB);
                        _SQLCommand.Parameters.AddWithValue("@UserName", UserName);
                        _SQLCommand.Parameters.AddWithValue("@Katalaluan", Katalaluan);
                        _SQLCommand.Parameters.AddWithValue("@PhotoName", PhotoName);
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
                        if (Photo != "ExistingImage")
                        {
                            AyohaUserProfile_CreateImg(Photo, AccountNo, PhotoName);
                        }

                        AyohaNotificationMasterModel.AyohaNotificationMaster_Insert_AyohaUserCreatedAccount("Welcome Mr/Ms:" + AccountName, PlayerID, AccountNo,AccountName);
                        
                       // OneSignalModel.onesignalAPI_AyohaNotification_UserProfileCreated(AccountName, PlayerID);
                    }

                }

            }



            return _value;
        }

        public static string AyohaUserProfile_Update(int ID,string AccountNo, string AccountName, string Email, string PhoneNo
      , string Photo, string Gender, string DOB, string PhotoName, string StreetAddress, string Town, string PostCode
      , string Country, string Profession, string Hobby, string States)
        {
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
                        _SQLCommand.CommandText = "AyohaUserProfile_Update";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@AccountName", AccountName);
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@Photo", "https://setkita.com/AyohaImgCard/AyohaUserPicProfile/" + AccountNo + "/" + PhotoName);
                        _SQLCommand.Parameters.AddWithValue("@Gender", Gender);
                        _SQLCommand.Parameters.AddWithValue("@DOB", DOB);





                        _SQLCommand.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                        _SQLCommand.Parameters.AddWithValue("@Town", Town);
                        _SQLCommand.Parameters.AddWithValue("@PostCode", PostCode);
                        _SQLCommand.Parameters.AddWithValue("@Country", Country);
                        _SQLCommand.Parameters.AddWithValue("@Profession", Profession);
                        _SQLCommand.Parameters.AddWithValue("@Hobby", Hobby);
                        _SQLCommand.Parameters.AddWithValue("@States", States);
                        
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
                        if (Photo != "ExistingImage")
                        {
                            AyohaUserProfile_CreateImg(Photo, AccountNo, PhotoName);
                        }


                    }

                }

            }



            return _value;
        }




        public static string AyohaUserProfile_UpdateKataLaluan(int ID, string AccountNo, string Katalaluan)
        {
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
                        _SQLCommand.CommandText = "AyohaUserProfile_UpdateKataLaluan";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@Katalaluan", Katalaluan);
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




       

        public static List<AyohaUserProfileModel> AyohaUserProfile_Login(string UserName, string KataLaluan, string LoginOS, string LoginIP,
           string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
           string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_Login";
                        _SQLCommand.Parameters.AddWithValue("@UserName", UserName);
                        _SQLCommand.Parameters.AddWithValue("@KataLaluan", KataLaluan);
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
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.Gender = _SQLDataReader["Gender"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.UserName = _SQLDataReader["UserName"].ToString();
                            _result.Katalaluan = _SQLDataReader["Katalaluan"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.GUID = _SQLDataReader["GUID"].ToString();
                            _result.isUserVerified = _SQLDataReader["isUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.UserVerifiedDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["UserVerifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["UserVerifiedDate"]); ;

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






        public static List<AyohaUserProfileModel> AyohaUserProfile_LoginBody(string UserName, string Katalaluan, string LoginOS, string LoginIP,
       string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
       string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_Login";
                        _SQLCommand.Parameters.AddWithValue("@UserName", UserName);
                        _SQLCommand.Parameters.AddWithValue("@KataLaluan", Katalaluan);
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
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.Gender = _SQLDataReader["Gender"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.UserName = _SQLDataReader["UserName"].ToString();
                            _result.Katalaluan = _SQLDataReader["Katalaluan"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.GUID = _SQLDataReader["GUID"].ToString();
                            _result.isUserVerified = _SQLDataReader["isUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.UserVerifiedDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["UserVerifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["UserVerifiedDate"]); ;
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



        public static string AyohaUserProfile_VerifyString(string AccountNo)
        {
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
                        _SQLCommand.CommandText = "AyohaUserProfile_VerifyString";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
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




        public static List<AyohaUserProfileModel> AyohaUserProfile_LoadForPointCampaign(string AccountNo, string PointCampaignCode)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_LoadForPointCampaign";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();

                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.PointAmountEquation = _SQLDataReader["PointAmountEquation"].ToString();
                             _result.RequiredReceiptBillNo = _SQLDataReader["RequiredReceiptBillNo"].ToString();
                     
                        
                            

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







        public static List<AyohaUserProfileModel> AyohaUserProfile_LoadProfile(string AccountNo)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_LoadProfile";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.Gender = _SQLDataReader["Gender"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                           // _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.UserName = _SQLDataReader["UserName"].ToString();
                            _result.Katalaluan = _SQLDataReader["Katalaluan"].ToString();
                           // _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.LastLoginDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["LastLoginDate"]) + " " + String.Format("{0:T}", _SQLDataReader["LastLoginDate"]);
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.GUID = _SQLDataReader["GUID"].ToString();
                            _result.isUserVerified = _SQLDataReader["isUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.UserVerifiedDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["UserVerifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["UserVerifiedDate"]); 
                            _result.StreetAddress = _SQLDataReader["StreetAddress"].ToString();
                            _result.Town = _SQLDataReader["Town"].ToString();
                            _result.PostCode = _SQLDataReader["PostCode"].ToString();
                            _result.Country = _SQLDataReader["Country"].ToString();
                            _result.Profession = _SQLDataReader["Profession"].ToString();
                            _result.Hobby = _SQLDataReader["Hobby"].ToString();
                            _result.States = _SQLDataReader["States"].ToString();
                            
                            
                            
                            
                            
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





        public static List<AyohaUserProfileModel> AyohaUserProfile_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();                         
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["CampaignEnterpriseAccNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());  
                            
                            
                            

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





        public static List<AyohaUserProfileModel> AyohaUserProfile_UnClaimedTotalStampPoint(string SubscriberAccNo)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_UnClaimedTotalStampPoint";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.UnClaimedTotalPoint = Convert.ToInt32(_SQLDataReader["UnClaimedTotalPoint"].ToString());
                            _result.UnClaimedTotalStamp = Convert.ToInt32(_SQLDataReader["UnClaimedTotalStamp"].ToString());
                            _result.NextRedeemPoint = Convert.ToInt32(_SQLDataReader["NextRedeemPoint"].ToString());
                            _result.NextRedeemStamp = Convert.ToInt32(_SQLDataReader["NextRedeemStamp"].ToString());
                            


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





        public static List<AyohaUserProfileModel> AyohaUserProfile_CheckExistingUser(string UserName,string Email)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_CheckExistingUser";
                        _SQLCommand.Parameters.AddWithValue("UserName", UserName);
                         _SQLCommand.Parameters.AddWithValue("Email", Email);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.UserName = _SQLDataReader["UserName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
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







        public static List<AyohaUserProfileModel> AyohaUserProfile_CheckIsEmailExist(string Email)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_CheckIsEmailExist";
                        _SQLCommand.Parameters.AddWithValue("Email", Email);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.AllowToSendEmail = isAllowedToSendForgotPassWordEmail(Convert.ToInt32(_SQLDataReader["TodayCountRetrivalPassword"].ToString()));
                            
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



        public static List<AyohaUserProfileModel> AyohaUserProfile_CheckIsEmailExist_eWallet(string Email)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_CheckIsEmailExist";
                        _SQLCommand.Parameters.AddWithValue("Email", Email);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.AllowToSendEmail = isAllowedToSendForgotPassWordEmail_eWallet(Convert.ToInt32(_SQLDataReader["TodayCountRetrivalPassword"].ToString()));

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

       

        public static string AyohaUserProfile_ForgotPassword(string Email, string LoginOS, string LoginIP,
       string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
       string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            AyohaUserProfileModel a = new AyohaUserProfileModel();
            a.Katalaluan = reGeneratePwdNo();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_ForgotPassword";
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        _SQLCommand.Parameters.AddWithValue("@Katalaluan", a.Katalaluan);
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
                        _value = Emails.mail_SendMailForgotPassword(Email,a.Katalaluan);

                    }

                }

            }



            return _value;
        }



        public static List<AyohaUserProfileModel> AyohaUserProfile_LoadByPhoneNo(string PhoneNo,string SubscriberAccNo)
        {
            List<AyohaUserProfileModel> _Value = new List<AyohaUserProfileModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_LoadByPhoneNo";
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfileModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfileModel();

                            
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();                          
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.Email_Debit = _SQLDataReader["Email_Debit"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            _result.AyohaeWalletTransactionTransactionType = _SQLDataReader["AyohaeWalletTransactionTransactionType"].ToString();

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




        public static void AyohaUserProfile_CreateImg(string ImgStr, string AccountNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AyohaUserPicProfile\\" + AccountNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ImgPath = "https://setkita.com/AyohaImgCard/AyohaUserPicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }



        public static string reGeneratePwdNo()
        {
            string val = "";

            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int card = rnd.Next(5555);

            val = month.ToString() + dice.ToString() + card.ToString();

            return val;
        }




        public static string isAllowedToSendForgotPassWordEmail(int CountEmailSend)
        {
            string val = "";

            if (CountEmailSend <= 1)
            {
                val = "Allowed";
            } 
            if (CountEmailSend >= 2)
            {
                val = "NotAllowed";
            }

            return val;
        }



        public static string isAllowedToSendForgotPassWordEmail_eWallet(int CountEmailSend)
        {
            string val = "";

            if (CountEmailSend <= 1)
            {
                val = "Allowed";
            }
            if (CountEmailSend >= 2)
            {
                val = "NotAllowed";
            }

            return val;
        }
    }
}