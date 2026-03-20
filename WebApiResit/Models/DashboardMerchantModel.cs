using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApiResit.Models
{
    public class DashboardMerchantModel
    {
        public string ThisWeekCountsStamp
        {
            get;
            set;
        }

        public string ThisWeekCountsPoint
        {
            get;
            set;
        }
        public string TotalCountStamp
        {
            get;
            set;
        }

        public string TotalCountPoint
        {
            get;
            set;
        }
        public string TotalMembershipCard
        {
            get;
            set;
        }

        public string AyohaPoint
        {
            get;
            set;
        }

        public string TotalMembers
        {
            get;
            set;
        }

        public DashboardMerchantModel() { }






        public static List<DashboardMerchantModel> DashboardMerchant_Main(string EnterpriseHQAccNo)
        {
            List<DashboardMerchantModel> _Value = new List<DashboardMerchantModel>();

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
                        _SQLCommand.CommandText = "DashboardMerchant_Main";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DashboardMerchantModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DashboardMerchantModel();

                            _result.ThisWeekCountsStamp = _SQLDataReader["ThisWeekCountsStamp"].ToString();
                            _result.ThisWeekCountsPoint = _SQLDataReader["ThisWeekCountsPoint"].ToString();
                            _result.TotalCountStamp = _SQLDataReader["TotalCountStamp"].ToString();
                            _result.TotalCountPoint = _SQLDataReader["TotalCountPoint"].ToString();
                            _result.TotalMembershipCard =_SQLDataReader["TotalMembershipCard"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.TotalMembers = _SQLDataReader["TotalMembers"].ToString();    
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