using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApiResit.Models
{
    public class VIEW_MerchantDashboard
    {
        public string AccountNo
        {
            get;
            set;
        }
        public string UserPhoto
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }


        public string CampaignCode
        {
            get;
            set;
        }


        public string UpdatedDate
        {
            get;
            set;
        }
        public string enterpriseAccNo
        {
            get;
            set;
        }




        public string TblActivity
        {
            get;
            set;
        }




        public string LoyaltyActivity
        {
            get;
            set;
        }




        public string RelativeActivityTime
        {
            get;
            set;
        }








        public string CheckInCount
        {
            get;
            set;
        }




        public string AyohaRewardPointCheckIn
        {
            get;
            set;
        }

        public string UpdatedTime
        {
            get;
            set;
        }

        

        public VIEW_MerchantDashboard() { }



        public static List<VIEW_MerchantDashboard>VIEW_MerchantDashboard_StoreActivity(string enterpriseAccNo)
        {
            List<VIEW_MerchantDashboard> _Value = new List<VIEW_MerchantDashboard>();

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
                        _SQLCommand.CommandText = "VIEW_MerchantDashboard_StoreActivity";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", enterpriseAccNo);
                        //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_MerchantDashboard _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new VIEW_MerchantDashboard();
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.UserPhoto = _SQLDataReader["UserPhoto"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.UpdatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["UpdatedDate"]);
                            _result.enterpriseAccNo = _SQLDataReader["enterpriseAccNo"].ToString();
                            _result.TblActivity = _SQLDataReader["TblActivity"].ToString();
                            _result.LoyaltyActivity = _SQLDataReader["LoyaltyActivity"].ToString();
                            _result.RelativeActivityTime = _SQLDataReader["RelativeActivityTime"].ToString();
                          


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






        public static List<VIEW_MerchantDashboard> MerchantDashboard_CheckOutActivity(string enterpriseAccNo, string AccountNo)
        {
            List<VIEW_MerchantDashboard> _Value = new List<VIEW_MerchantDashboard>();

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
                        _SQLCommand.CommandText = "MerchantDashboard_CheckOutActivity";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", enterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", AccountNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_MerchantDashboard _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new VIEW_MerchantDashboard();
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.UserPhoto = _SQLDataReader["UserPhoto"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.UpdatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["UpdatedDate"]);
                            _result.UpdatedTime = String.Format("{0:hh:mm:ss tt}", _SQLDataReader["UpdatedDate"]);
                            _result.enterpriseAccNo = _SQLDataReader["enterpriseAccNo"].ToString();
                            _result.TblActivity = _SQLDataReader["TblActivity"].ToString();
                            _result.LoyaltyActivity = _SQLDataReader["LoyaltyActivity"].ToString();
                            _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();
                            _result.AyohaRewardPointCheckIn = "+10 ";
                            _result.RelativeActivityTime = _SQLDataReader["RelativeActivityTime"].ToString();

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