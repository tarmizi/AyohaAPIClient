using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaEnterpriseUserModel : EnterpriseModel
    {
      
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
        public string LastLoginDate
        {
            get;
            set;
        }
        public string AccountName
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
        public string Email
        {
            get;
            set;
        }
        public string MyKadNo
        {
            get;
            set;
        }
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
        public string RegisterDate
        {
            get;
            set;
        }
        


        public AyohaEnterpriseUserModel() { }

        public static List<AyohaEnterpriseUserModel> AyohaEnterpriseUser_Login(string UseName, string Password, string LoginOS, string LoginIP,
            string PhoneModel, string PhoneImeiNo, string PhoneVersion, string PhonePlatform, string PhonePlatformVersion, string PhoneManufacturer,
            string PhoneSerial, string RawPhoneInfo, string PlayerID)
        {
            List<AyohaEnterpriseUserModel> _Value = new List<AyohaEnterpriseUserModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterpriseUser_Login";
                        _SQLCommand.Parameters.AddWithValue("@UseName", UseName);
                        _SQLCommand.Parameters.AddWithValue("@Password", Password);
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
                        AyohaEnterpriseUserModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterpriseUserModel();
                            _result.UseName = _SQLDataReader["UseName"].ToString();
                            _result.Password = _SQLDataReader["Password"].ToString();
                            _result.LastLoginDate = _SQLDataReader["LastLoginDate"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.MyKadNo = _SQLDataReader["MyKadNo"].ToString();
                            _result.AyohaEnterpriseUserID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.RegisterDate = _SQLDataReader["RegisterDate"].ToString();
                            ((EnterpriseModel)_result).ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            ((EnterpriseModel)_result).EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            ((EnterpriseModel)_result).EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            ((EnterpriseModel)_result).EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseGSTNo = _SQLDataReader["EnterpriseGSTNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            ((EnterpriseModel)_result).EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            ((EnterpriseModel)_result).EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseFaxNo = _SQLDataReader["EnterpriseFaxNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogo64 = _SQLDataReader["EnterpriseLogo64"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            ((EnterpriseModel)_result).RowStatus = _SQLDataReader["RowStatus"].ToString();
                            ((EnterpriseModel)_result).CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            ((EnterpriseModel)_result).CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            ((EnterpriseModel)_result).ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            ((EnterpriseModel)_result).ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            ((EnterpriseModel)_result).Status = _SQLDataReader["Status"].ToString();
                            ((EnterpriseModel)_result).EnterpriseTaxNo = _SQLDataReader["EnterpriseTaxNo"].ToString();
                            ((EnterpriseModel)_result).isTaxApplied = _SQLDataReader["isTaxApplied"].ToString();
                            ((EnterpriseModel)_result).TaxRate = _SQLDataReader["TaxRate"].ToString();
                            ((EnterpriseModel)_result).EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            ((EnterpriseModel)_result).EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            ((EnterpriseModel)_result).EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            ((EnterpriseModel)_result).EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            ((EnterpriseModel)_result).EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            ((EnterpriseModel)_result).LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();

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

    }
}