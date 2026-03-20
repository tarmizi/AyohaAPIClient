using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class DashboardAyohaRewardSummaryModel
    {

        public string CountsStamp
        {
            get;
            set;
        }

        public string CountsPoint
        {
            get;
            set;
        }
        public string CountCampaignRewardTypeStamp
        {
            get;
            set;
        }
        public string CountCampaignRewardTypePoint
        {
            get;
            set;
        }

        public DashboardAyohaRewardSummaryModel() { }

        public static List<DashboardAyohaRewardSummaryModel> Dashboard_AyohaRewardSummary(string SubscriberAccNo)
        {
            List<DashboardAyohaRewardSummaryModel> _Value = new List<DashboardAyohaRewardSummaryModel>();

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
                        _SQLCommand.CommandText = "Dashboard_AyohaRewardSummary";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DashboardAyohaRewardSummaryModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new DashboardAyohaRewardSummaryModel();
                            _result.CountsStamp = _SQLDataReader["CountsStamp"].ToString();
                            _result.CountsPoint = _SQLDataReader["CountsPoint"].ToString();
                            _result.CountCampaignRewardTypeStamp = _SQLDataReader["CountCampaignRewardTypeStamp"].ToString();
                            _result.CountCampaignRewardTypePoint =_SQLDataReader["CountCampaignRewardTypePoint"].ToString();



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