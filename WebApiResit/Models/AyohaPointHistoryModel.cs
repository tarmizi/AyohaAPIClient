using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaPointHistoryModel
    {
        public string CountsStamp
        {
            get;
            set;
        }



        public string Batch
        {
            get;
            set;
        }
        public string StampClaimStatus
        {
            get;
            set;
        }



        public string StampedByDate
        {
            get;
            set;
        }
        public string StampedBy
        {
            get;
            set;
        }



        public string CampaignName
        {
            get;
            set;
        }


        public string EnterpriseName
        {
            get;
            set;
        }


        public string PointType
        {
            get;
            set;
        }

        public string StampedByDate_DateOnly
        {
            get;
            set;
        }

        public string StampedByDate_TimeOnly
        {
            get;
            set;
        }

        public string StampedByDate_MonthYear
        {
            get;
            set;
        }

       
        public AyohaPointHistoryModel() { }

        public static List<AyohaPointHistoryModel> AyohaPointHistory_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaPointHistoryModel> _Value = new List<AyohaPointHistoryModel>();

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
                        _SQLCommand.CommandText = "AyohaPointHistory_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaPointHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaPointHistoryModel();
                            _result.CountsStamp = _SQLDataReader["CountsStamp"].ToString();
                            _result.Batch = _SQLDataReader["Batch"].ToString();
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.PointType = _SQLDataReader["PointType"].ToString();
                            _result.StampedByDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedByDate"]);
                            _result.StampedByDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["StampedByDate"]);
                            _result.StampedByDate_MonthYear = ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["StampedByDate"]),String.Format("{0:yyyy}", _SQLDataReader["StampedByDate"]));



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



        public static string ModifiedMonthYear(string val,string val0)
        {
            string result = "";

            if (val.StartsWith("1"))
            {
                result = "JANUARY "+val0;
            }
            if (val.StartsWith("2"))
            {
                result = "FEBRUARY " + val0;
            } if (val.StartsWith("3"))
            {
                result = "MARCH " + val0;
            } if (val.StartsWith("4"))
            {
                result = "APRIL " + val0;
            } if (val.StartsWith("5"))
            {
                result = "MAY " + val0;
            } if (val.StartsWith("6"))
            {
                result = "JUNE " + val0;
            } if (val.StartsWith("7"))
            {
                result = "JULY " + val0;
            } if (val.StartsWith("8"))
            {
                result = "AUGUST " + val0;
            } if (val.StartsWith("9"))
            {
                result = "SEPTEMBER " + val0;
            } if (val.StartsWith("10"))
            {
                result = "OCTOBER " + val0;
            } if (val.StartsWith("11"))
            {
                result = "NOVEMBER " + val0;
            } if (val.StartsWith("12"))
            {
                result = "DECEMBER " + val0;
            } 


            return result;


        }


    }
}