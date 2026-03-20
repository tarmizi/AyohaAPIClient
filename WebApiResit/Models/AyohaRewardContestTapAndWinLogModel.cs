using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardContestTapAndWinLogModel
    {
        
       
        public string ContestCode
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string TapCount
        {
            get;
            set;
        }
        public string TapStatus
        {
            get;
            set;
        }


        public string TapNo
        {
            get;
            set;
        }



           public string TapNoSecret
        {
            get;
            set;
        }
        public string TapWinAmount
        {
            get;
            set;
        }


        public string MembershipGroupCode
        {
            get;
            set;
        }

        public AyohaRewardContestTapAndWinLogModel() { }



        public static string AyohaRewardContestTapAndWinLog_Insert(string ContestCode, string SubscriberAccNo, string TapCount, string TapStatus, string TapNo, string TapNoSecret,
          string TapWinAmount, string MembershipGroupCode)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaRewardContestTapAndWinLog_Insert";
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TapCount", TapCount);
                        _SQLCommand.Parameters.AddWithValue("@TapStatus", TapStatus);
                        _SQLCommand.Parameters.AddWithValue("@TapNo", TapNo);
                        _SQLCommand.Parameters.AddWithValue("@TapNoSecret", TapNoSecret);
                        _SQLCommand.Parameters.AddWithValue("@TapWinAmount", TapWinAmount);
                        _SQLCommand.Parameters.AddWithValue("@MembershipGroupCode", MembershipGroupCode);
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







        public static string AyohaRewardContestTapAndWinTapNoSec_Insert(string TapNo, string SubscriberAccNo,
        string ContestCode)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaRewardContestTapAndWinTapNoSec_Insert";   
                        _SQLCommand.Parameters.AddWithValue("@TapNo", TapNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
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
    }
}