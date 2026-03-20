using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaScanQrCodeActivityModel
    {
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string QrCodeString
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string Activity
        {
            get;
            set;
        }
      
        public AyohaScanQrCodeActivityModel() { }

        public static string AyohaScanQrCodeActivity_InsertUpdate(string SubscriberAccNo, string QrCodeString,
string EnterpriseAccNo, string Activity)
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
                        _SQLCommand.CommandText = "AyohaScanQrCodeActivity_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@QrCodeString", QrCodeString);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Activity", Activity);
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