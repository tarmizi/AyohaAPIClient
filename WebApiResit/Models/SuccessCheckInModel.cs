using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    
    public class SuccessCheckInModel
    {
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }



        public string CurrentStampCount
        {
            get;
            set;
        }
        public string TotalStampCount
        {
            get;
            set;
        }



        public string StampProgressDisplay
        {
            get;
            set;
        }
        public string StampPerksCount
        {
            get;
            set;
        }


        public string PointPerksCount
        {
            get;
            set;
        }



        public string CurrentPointsBalance
        {
            get;
            set;
        }
        public string VoucherUsed
        {
            get;
            set;
        }
        public string VoucherEntitle
        {
            get;
            set;
        }



        public string SubmittedContest
        {
            get;
            set;
        }






        public string AvailableContest
        {
            get;
            set;
        }



        public string JoinedEvent
        {
            get;
            set;
        }
        public string AvailableEvent
        {
            get;
            set;
        }
        public string AvailableDiscount
        {
            get;
            set;
        }



        public string DiscountUsage
        {
            get;
            set;
        }







        public SuccessCheckInModel() { }


        public static List<SuccessCheckInModel> Dashboard_SuccessCheckIn_LoadPerkCanEnjoyInfo(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<SuccessCheckInModel> _Value = new List<SuccessCheckInModel>();

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
                        _SQLCommand.CommandText = "Dashboard_SuccessCheckIn_LoadPerkCanEnjoyInfo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        SuccessCheckInModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new SuccessCheckInModel();


                            _result.CurrentStampCount = _SQLDataReader["CurrentStampCount"].ToString();
                            _result.TotalStampCount = _SQLDataReader["TotalStampCount"].ToString();
                            _result.StampProgressDisplay = _SQLDataReader["StampProgressDisplay"].ToString();
                            _result.StampPerksCount = _SQLDataReader["StampPerksCount"].ToString();
                            _result.PointPerksCount = _SQLDataReader["PointPerksCount"].ToString();
                            _result.CurrentPointsBalance = _SQLDataReader["CurrentPointsBalance"].ToString();
                            _result.VoucherUsed = _SQLDataReader["VoucherUsed"].ToString();
                            _result.VoucherEntitle = _SQLDataReader["VoucherEntitle"].ToString();
                            _result.SubmittedContest = _SQLDataReader["SubmittedContest"].ToString();
                            _result.AvailableContest = _SQLDataReader["AvailableContest"].ToString();
                            _result.JoinedEvent = _SQLDataReader["JoinedEvent"].ToString();
                            _result.AvailableEvent = _SQLDataReader["AvailableEvent"].ToString();
                            _result.AvailableDiscount = _SQLDataReader["AvailableDiscount"].ToString();
                            _result.DiscountUsage = _SQLDataReader["DiscountUsage"].ToString();
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