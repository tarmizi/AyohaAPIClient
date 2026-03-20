using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class BranchEnterpriseModel
    {
        public int ID
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string BranchEnterpriseAccNo
        {
            get;
            set;
        }
        public string EnterpriseName
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }

        public string EnterprisePhoneNo
        {
            get;
            set;
        }
        public string EnterpriseRegistrationNo
        {
            get;
            set;
        }
        public string EnterpriseEmail
        {
            get;
            set;
        }
        public string EnterpriseWebsite
        {
            get;
            set;
        }
        public string EnterpriseDescriptions
        {
            get;
            set;
        }
        public string EnterpriseFacebook
        {
            get;
            set;
        }
        public string EnterpriseTwiter
        {
            get;
            set;
        }
        public string EnterpriseInstagram
        {
            get;
            set;
        }

        public string EnterpriseCoordinate
        {
            get;
            set;
        }
        public string EnterpriseLogoPath
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
        public string CreatedBy
        {
            get;
            set;
        }
        public string ModifiedDate
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
        public string isFeedBackFormEnabled
        {
            get;
            set;
        }
                

        public string PICContactNo
        {
            get;
            set;
        }
        public string PersonInCharge
        {
            get;
            set;
        }
        public string LoyaltyCardType
        {
            get;
            set;
        }



        public BranchEnterpriseModel() { }


        public static List<BranchEnterpriseModel> BranchEnterprise_LoadByEnterpriseAccNo( string EnterpriseAccNo)
        {
            List<BranchEnterpriseModel> _Value = new List<BranchEnterpriseModel>();

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
                        _SQLCommand.CommandText = "BranchEnterprise_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        BranchEnterpriseModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new BranchEnterpriseModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.isFeedBackFormEnabled = _SQLDataReader["isFeedBackFormEnabled"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
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












        public static List<BranchEnterpriseModel> BranchEnterprise_LoadByBranchEnterpriseAccNo(string BranchEnterpriseAccNo)
        {
            List<BranchEnterpriseModel> _Value = new List<BranchEnterpriseModel>();

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
                        _SQLCommand.CommandText = "BranchEnterprise_LoadByBranchEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@BranchEnterpriseAccNo", BranchEnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        BranchEnterpriseModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new BranchEnterpriseModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.isFeedBackFormEnabled = _SQLDataReader["isFeedBackFormEnabled"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
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






        public static bool BranchEnterprise_InsertUpdate(int ID, string EnterpriseAccNo, string BranchEnterpriseAccNo, string EnterpriseName, string EnterpriseAddress, string EnterprisePhoneNo
            ,string EnterpriseRegistrationNo, string EnterpriseEmail, string EnterpriseWebsite, string EnterpriseFacebook, string EnterpriseTwiter
            ,string EnterpriseInstagram, string EnterpriseCoordinate, string EnterpriseLogoPath, string RowStatus, string CreatedBy
            ,string isFeedBackFormEnabled, string PICContactNo, string PersonInCharge, string LoyaltyCardType)
        {
            List<GPSuserModel> _Value = new List<GPSuserModel>();
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
                        _SQLCommand.CommandText = "BranchEnterprise_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@BranchEnterpriseAccNo", BranchEnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseName", EnterpriseName);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAddress", EnterpriseAddress);
                        _SQLCommand.Parameters.AddWithValue("@EnterprisePhoneNo", EnterprisePhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseRegistrationNo", EnterpriseRegistrationNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseEmail", EnterpriseEmail);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseWebsite", EnterpriseWebsite);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseFacebook", EnterpriseFacebook); 
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseTwiter", EnterpriseTwiter);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseInstagram", EnterpriseInstagram);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseCoordinate", EnterpriseCoordinate);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseLogoPath", EnterpriseLogoPath);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@isFeedBackFormEnabled", isFeedBackFormEnabled);
                        _SQLCommand.Parameters.AddWithValue("@PICContactNo", PICContactNo);
                        _SQLCommand.Parameters.AddWithValue("@PersonInCharge", PersonInCharge);
                        _SQLCommand.Parameters.AddWithValue("@LoyaltyCardType", LoyaltyCardType);
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