using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesFavoriteModel
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
        public string EnterpriseAccNo
        {
            get;
            set;
        }



        public string CreatedDate
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }



        public string ModifiedDate
        {
            get;
            set;
        }

        public EnterprisesFavoriteModel() { }

        public static string EnterprisesFavorite_AddEnterpriseFavorite(string EnterpriseAccNo,
          string SubscriberAccNo)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "EnterprisesFavorite_AddEnterpriseFavorite";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
               
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    
                    
                        _value = "false," + ex.ToString();
                    
                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }










        public static string EnterprisesFavorite_RemoveEnterpriseFavorite(string EnterpriseAccNo,
         string SubscriberAccNo)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "EnterprisesFavorite_RemoveEnterpriseFavorite";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);

                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {


                    _value = "false," + ex.ToString();

                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }

    }
}