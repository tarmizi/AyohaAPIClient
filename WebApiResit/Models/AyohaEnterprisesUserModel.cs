using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaEnterprisesUserModel : EnterprisesModel
    {


        public int AyohaEnterpriseUserID
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
        public string UseName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
       
        public string Photo
        {
            get;
            set;
        }
        public string RegisterDate
        {
            get;
            set;
        }
        public string IsUserVerified
        {
            get;
            set;
        }
        public string VerifyString
        {
            get;
            set;
        }
        



          public string VeriyDate
        {
            get;
            set;
        }
          public string ModifiedBy
          {
              get;
              set;
          }
          public string ModifiedDate
          {
              get;
              set;
          }
        public string RowActive
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        

         public string UserType
        {
            get;
            set;
        }
        public string UserStatus
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

        public string DOB
        {
            get;
            set;
        }
        public string PicProfilePhoto64
        {
            get;
            set;
        }

        public string SerialPhoneNo
        {
            get;
            set;
        }
        public string EnterpriseHQAccNo
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }
        
        
        public AyohaEnterprisesUserModel() { }


        public static List<AyohaEnterprisesUserModel> AyohaEnterprisesUser_Login(string UseName, string Password, string LoginOS, string LoginIP,
           string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
           string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<AyohaEnterprisesUserModel> _Value = new List<AyohaEnterprisesUserModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_Login";
                        _SQLCommand.Parameters.AddWithValue("@UseName", UseName);
                        _SQLCommand.Parameters.AddWithValue("@Password", Password);
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
                        AyohaEnterprisesUserModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserModel();
                            _result.AyohaEnterpriseUserID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.UseName = _SQLDataReader["UseName"].ToString();
                            _result.Password = _SQLDataReader["Password"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.RegisterDate = _SQLDataReader["RegisterDate"].ToString();
                            _result.IsUserVerified = _SQLDataReader["IsUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.VeriyDate = _SQLDataReader["VeriyDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowActive = _SQLDataReader["RowActive"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.UserType = _SQLDataReader["UserType"].ToString();
                            _result.UserStatus = _SQLDataReader["UserStatus"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.SerialPhoneNo = _SQLDataReader["SerialPhoneNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                           // ((EnterprisesModel)_result).ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                           // ((EnterprisesModel)_result).EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            ((EnterprisesModel)_result).EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            ((EnterprisesModel)_result).EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                           //// ((EnterpriseModel)_result).EnterpriseGSTNo = _SQLDataReader["EnterpriseGSTNo"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                           // ((EnterprisesModel)_result).EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            ((EnterprisesModel)_result).EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();                           
                           // ((EnterprisesModel)_result).RowStatus = _SQLDataReader["RowStatus"].ToString();
                           // ((EnterprisesModel)_result).CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                           // ((EnterprisesModel)_result).CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                           // ((EnterprisesModel)_result).ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                           // ((EnterprisesModel)_result).ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                           // ((EnterprisesModel)_result).PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                           // ((EnterprisesModel)_result).PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                           // ((EnterprisesModel)_result).LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                           // ((EnterprisesModel)_result).EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            ((EnterprisesModel)_result).AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();

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



        public static List<AyohaEnterprisesUserModel> AyohaEnterprisesUser_LoadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            List<AyohaEnterprisesUserModel> _Value = new List<AyohaEnterprisesUserModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_LoadByEnterpriseHQAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaEnterprisesUserModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserModel();
                            _result.AyohaEnterpriseUserID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.UseName = _SQLDataReader["UseName"].ToString();
                            _result.Password = _SQLDataReader["Password"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.RegisterDate = _SQLDataReader["RegisterDate"].ToString();
                            _result.IsUserVerified = _SQLDataReader["IsUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.VeriyDate = _SQLDataReader["VeriyDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowActive = _SQLDataReader["RowActive"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.UserType = _SQLDataReader["UserType"].ToString();
                            _result.UserStatus = _SQLDataReader["UserStatus"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.SerialPhoneNo = _SQLDataReader["SerialPhoneNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
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



        public static List<AyohaEnterprisesUserModel> AyohaEnterprisesUser_LoadByAccountNo(string AccountNo)
        {
            List<AyohaEnterprisesUserModel> _Value = new List<AyohaEnterprisesUserModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_LoadByAccountNo";
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaEnterprisesUserModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserModel();
                            _result.AyohaEnterpriseUserID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.UseName = _SQLDataReader["UseName"].ToString();
                            _result.Password = _SQLDataReader["Password"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.RegisterDate = _SQLDataReader["RegisterDate"].ToString();
                            _result.IsUserVerified = _SQLDataReader["IsUserVerified"].ToString();
                            _result.VerifyString = _SQLDataReader["VerifyString"].ToString();
                            _result.VeriyDate = _SQLDataReader["VeriyDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowActive = _SQLDataReader["RowActive"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.UserType = _SQLDataReader["UserType"].ToString();
                            _result.UserStatus = _SQLDataReader["UserStatus"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.PhotoName = _SQLDataReader["PhotoName"].ToString();
                            _result.DOB = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["DOB"]);
                            _result.SerialPhoneNo = _SQLDataReader["SerialPhoneNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
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





        public static List<AyohaEnterprisesUserModel> AyohaEnterprisesUser_CheckUserName(string UseName, string SerialPhoneNo)
        {
            List<AyohaEnterprisesUserModel> _Value = new List<AyohaEnterprisesUserModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_CheckUserName";
                        _SQLCommand.Parameters.AddWithValue("@UseName", UseName);
                        _SQLCommand.Parameters.AddWithValue("@SerialPhoneNo", SerialPhoneNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaEnterprisesUserModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserModel();                        
                            _result.UseName = _SQLDataReader["UseName"].ToString();
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




        public static string AyohaEnterprisesUser_InsertUpdate(int AyohaEnterpriseUserID, string AccountNo, string AccountName, string UseName, string Password
      , string Email, string PhoneNumber, string PicProfilePhoto64, string ModifiedBy, string EnterpriseAccNo, string UserType
      , string UserStatus, string PhotoName, string DOB, string SerialPhoneNo, string RowActive, string PlayerID)
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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", AyohaEnterpriseUserID);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@AccountName", AccountName);
                        _SQLCommand.Parameters.AddWithValue("@UseName", UseName);
                        _SQLCommand.Parameters.AddWithValue("@Password", Password);
                        _SQLCommand.Parameters.AddWithValue("@Email", Email);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        _SQLCommand.Parameters.AddWithValue("@Photo", "https://setkita.com/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + PhotoName);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@UserType", UserType);
                        _SQLCommand.Parameters.AddWithValue("@UserStatus", UserStatus);
                        _SQLCommand.Parameters.AddWithValue("@PhotoName", PhotoName);
                        _SQLCommand.Parameters.AddWithValue("@DOB", DOB);
                        _SQLCommand.Parameters.AddWithValue("@SerialPhoneNo", SerialPhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@RowActive", RowActive);
                        _SQLCommand.Parameters.AddWithValue("@PlayerID", PlayerID);
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
                        if (PicProfilePhoto64 != "ExistingImage")
                        {
                            AyohaEnterprisesUser_CreateImg(PicProfilePhoto64, AccountNo, PhotoName);
                        }


                    }

                }

            }



            return _value;
        }



        public static string AyohaEnterprisesUser_UpdatePassword(int AyohaEnterpriseUserID, string AccountNo, string ModifiedBy, string Password)
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
                        _SQLCommand.CommandText = "AyohaEnterprisesUser_UpdatePassword";
                        _SQLCommand.Parameters.AddWithValue("@ID", AyohaEnterpriseUserID);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@Password", Password);
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





        public static void AyohaEnterprisesUser_CreateImg(string ImgStr, string AccountNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AyohaUserEnterprisePicProfile\\" + AccountNo + "\\";//Path
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
                ImgPath = "https://setkita.com/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }

    }
}