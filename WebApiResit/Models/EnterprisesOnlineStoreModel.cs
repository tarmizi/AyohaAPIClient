using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesOnlineStoreModel
    {
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string OnlineStoreCode
        {
            get;
            set;
        }
        public string OnlineStoreURL
        {
            get;
            set;
        }
        public string OnlineStoreName
        {
            get;
            set;
        }
        public string OnlineStoreIconPath
        {
            get;
            set;
        }
       

        public EnterprisesOnlineStoreModel() { }


        public static List<EnterprisesOnlineStoreModel>Enterprises_OnlineStore_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<EnterprisesOnlineStoreModel> _Value = new List<EnterprisesOnlineStoreModel>();

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
                        _SQLCommand.CommandText = "Enterprises_OnlineStore_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesOnlineStoreModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesOnlineStoreModel();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.OnlineStoreCode = _SQLDataReader["OnlineStoreCode"].ToString();
                            _result.OnlineStoreURL = _SQLDataReader["OnlineStoreURL"].ToString();
                            _result.OnlineStoreName = _SQLDataReader["OnlineStoreName"].ToString();
                            _result.OnlineStoreIconPath = _SQLDataReader["OnlineStoreIconPath"].ToString();
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