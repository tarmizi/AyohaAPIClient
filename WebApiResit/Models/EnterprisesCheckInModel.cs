using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesCheckInModel
    {
        public int ID
        {
            get;
            set;
        }



        public string EnterpriseHQAccNo
        {
            get;
            set;
        }
        public string EnterpriseAccNo
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
        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string CheckInDateTime
        {
            get;
            set;
        }
        public string CoordinateX
        {
            get;
            set;
        }
        public string CoordinateY
        {
            get;
            set;
        }

        public string CoordinateZ
        {
            get;
            set;
        }

        public string CheckInAddress
        {
            get;
            set;
        }






        public string CheckInCode
        {
            get;
            set;
        }
        public string RadiusCheckIn
        {
            get;
            set;
        }
        public string CheckInMethod
        {
            get;
            set;
        }
        public string CheckInPage
        {
            get;
            set;
        }
        public string CanCheckIn
        {
            get;
            set;
        }

        public string CheckInCount
        {
            get;
            set;
        }








        public string AccumulateAyohaRewardPointCheckIn
        {
            get;
            set;
        }
        public string AccumulateTotalCheckIn
        {
            get;
            set;
        }

        public string RelativeCheckInTime
        {
            get;
            set;
        }
        
        public EnterprisesCheckInModel() { }









        public static string EnterprisesCheckIn_Insert(string EnterpriseHQAccNo, string EnterpriseAccNo,
           string SubscriberAccNo, string CheckInCode, string CheckInMethod,
            string CheckInPage)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "EnterprisesCheckIn_Insert";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@CheckInCode", CheckInCode);
                _SQLCommand.Parameters.AddWithValue("@CheckInMethod", CheckInMethod);
                _SQLCommand.Parameters.AddWithValue("@CheckInPage", CheckInPage);
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Check for the 'API Key does not exist' error
                    if (ex.Message.Contains("Exceed Limit CheckIn, Please check in next day"))
                    {
                        //_value = "false, API Key does not exist";
                        _value = "false";
                    }
                    else
                    {
                        _value = "false," + ex.ToString();
                    }
                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }



        public static string EnterprisesCheckIn_InsertCheckOut(string EnterpriseHQAccNo, string EnterpriseAccNo,
         string SubscriberAccNo, string CheckInCode, string CheckInMethod,
          string CheckInPage)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "EnterprisesCheckIn_InsertCheckOut";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@CheckInCode", CheckInCode);
                _SQLCommand.Parameters.AddWithValue("@CheckInMethod", CheckInMethod);
                _SQLCommand.Parameters.AddWithValue("@CheckInPage", CheckInPage);
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Check for the 'API Key does not exist' error
                    if (ex.Message.Contains("Error Check Out"))
                    {
                        //_value = "false, API Key does not exist";
                        _value = "false";
                    }
                    else
                    {
                        _value = "false," + ex.ToString();
                    }
                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }

        public static List<EnterprisesCheckInModel> EnterprisesCheckIn_CanCheckIn(string EnterpriseAccNo,
           string SubscriberAccNo)
        {
            List<EnterprisesCheckInModel> _Value = new List<EnterprisesCheckInModel>();
           // string _value = "true";
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
                        _SQLCommand.CommandText = "EnterprisesCheckIn_CanCheckIn";  // Call your stored procedure
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesCheckInModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesCheckInModel();
                            _result.CanCheckIn = _SQLDataReader["CanCheckIn"].ToString();
                            _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();
                            _result.RelativeCheckInTime = _SQLDataReader["RelativeCheckInTime"].ToString();
                             _result.AccumulateAyohaRewardPointCheckIn = _SQLDataReader["AccumulateAyohaRewardPointCheckIn"].ToString();
                             _result.AccumulateTotalCheckIn = _SQLDataReader["AccumulateTotalCheckIn"].ToString();
                            
                            
                            
                            
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










        //public static string EnterprisesCheckIn_CanCheckIn(string EnterpriseAccNo,
        //   string SubscriberAccNo)
        //{
        //    SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
        //    string _value = "true";

        //    using (SqlConnection _DBConnection = _SQLConnection)
        //    {
        //        SqlCommand _SQLCommand = new SqlCommand();
        //        _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        _SQLCommand.CommandTimeout = 0;
        //        _SQLCommand.CommandText = "EnterprisesCheckIn_CanCheckIn";  // Call your stored procedure
        //        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
        //        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
        //        try
        //        {
        //            _SQLCommand.Connection = _DBConnection;
        //            _DBConnection.Open();
        //            _SQLCommand.ExecuteNonQuery();
        //        }
        //        catch (SqlException ex)
        //        {
        //            _value = "false," + ex.ToString();
        //            // Check for the 'API Key does not exist' error
        //            //if (ex.Message.Contains("Exceed Limit CheckIn, Please check in next day"))
        //            //{
        //            //    //_value = "false, API Key does not exist";
        //            //    _value = "false";
        //            //}
        //            //else
        //            //{
        //            //    _value = "false," + ex.ToString();
        //            //}
        //        }
        //        finally
        //        {
        //            _DBConnection.Close();
        //        }
        //    }

        //    return _value;
        //}









        



    }
}