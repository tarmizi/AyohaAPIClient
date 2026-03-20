using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AdvertisementAnalsysModel
    {
        public int ID
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }
        public string IPAddress
        {
            get;
            set;
        }
        public int ClickCount
        {
            get;
            set;
        }




           public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string AdvertisementCode
        {
            get;
            set;
        }
        public string AccessedPlatform
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }







        
           public string AccountName
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }
        public string Photo
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }

        public AdvertisementAnalsysModel() { }

      

        public static string AdvertisementAnalsys_InsertUpdate(string SubscriberAccNo, string IPAddress,
 string EnterpriseAccNo, string AdvertisementCode, string AccessedPlatform)
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
                        _SQLCommand.CommandText = "AdvertisementAnalsys_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@IPAddress", IPAddress);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@AccessedPlatform", AccessedPlatform);
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