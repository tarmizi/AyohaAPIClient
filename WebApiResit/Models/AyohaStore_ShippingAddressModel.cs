using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaStore_ShippingAddressModel
    {
        public int ID
        {
            get;
            set;
        }

        public string StreetName
        {
            get;
            set;
        }
        public string Town
        {
            get;
            set;
        }
        public string PostCode
        {
            get;
            set;
        }
        public string StateCode
        {
            get;
            set;
        }


        public string CountryCode
        {
            get;
            set;
        }
        public string ContactPersonName
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }
        public string ItemCartCode
        {
            get;
            set;
        }
        public string OrderCode
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
        public AyohaStore_ShippingAddressModel() { }



        public static string AyohaStore_ShippingAddress_InsertUpdate(int ID, string StreetName, string Town, string PostCode, string StateCode, string CountryCode, string ContactPersonName, string PhoneNo, string ItemCartCode
        , string OrderCode, string SubscriberAccNo, string EnterpriseAccNo)
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
                        _SQLCommand.CommandText = "AyohaStore_ShippingAddress_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StreetName", StreetName);
                        _SQLCommand.Parameters.AddWithValue("@Town", Town);
                        _SQLCommand.Parameters.AddWithValue("@PostCode", PostCode);
                        _SQLCommand.Parameters.AddWithValue("@StateCode", StateCode);
                        _SQLCommand.Parameters.AddWithValue("@CountryCode", CountryCode);
                        _SQLCommand.Parameters.AddWithValue("@ContactPersonName", ContactPersonName);
                        _SQLCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@OrderCode", OrderCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
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







        public static List<AyohaStore_ShippingAddressModel> AyohaStore_ShippingAddress_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaStore_ShippingAddressModel> _Value = new List<AyohaStore_ShippingAddressModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_ShippingAddress_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_ShippingAddressModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_ShippingAddressModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StreetName = _SQLDataReader["StreetName"].ToString();
                            _result.Town = _SQLDataReader["Town"].ToString();
                            _result.PostCode = _SQLDataReader["PostCode"].ToString();
                            _result.StateCode = _SQLDataReader["StateCode"].ToString();
                            _result.CountryCode = _SQLDataReader["CountryCode"].ToString();
                            _result.ContactPersonName = _SQLDataReader["ContactPersonName"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.OrderCode = _SQLDataReader["OrderCode"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();

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