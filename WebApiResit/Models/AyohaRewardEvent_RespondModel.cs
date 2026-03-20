using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaRewardEvent_RespondModel
    {
        public int ID
        {
            get;
            set;
        }

        public string EventCode
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string RespondStatus
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

        public string RowStatus
        {
            get;
            set;
        }
        public string Noted
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public AyohaRewardEvent_RespondModel() { }

        public static string AyohaRewardEvent_Respond_InsertUpdate(int ID, string EventCode, string SubscriberAccNo, string RespondStatus, string CreatedBy, string Noted, string EnterpriseAccNo)
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
                        _SQLCommand.CommandText = "AyohaRewardEvent_Respond_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EventCode", EventCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);                        
                        _SQLCommand.Parameters.AddWithValue("@RespondStatus", RespondStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@Noted", Noted);
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