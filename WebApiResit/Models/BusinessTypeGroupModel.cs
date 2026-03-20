using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class BusinessTypeGroupModel
    {

        public int ID
        {
            get;
            set;
        }

        public string BusinessTypeGroupCode
        {
            get;
            set;
        }
        public string BusinessTypeGroups
        {
            get;
            set;
        }
        public string BusinessTypeGroupsIconPath
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }

        public int Counted
        {
            get;
            set;
        }
        
        public BusinessTypeGroupModel() { }


        public static List<BusinessTypeGroupModel> BusinessTypeGroup_load()
        {
            List<BusinessTypeGroupModel> _Value = new List<BusinessTypeGroupModel>();

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
                        _SQLCommand.CommandText = "BusinessTypeGroup_load";



                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        BusinessTypeGroupModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new BusinessTypeGroupModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeGroups = _SQLDataReader["BusinessTypeGroups"].ToString();
                            _result.BusinessTypeGroupsIconPath = _SQLDataReader["BusinessTypeGroupsIconPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();  
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





        public static List<BusinessTypeGroupModel> BusinessTypeGroup_MerchantCategory()
        {
            List<BusinessTypeGroupModel> _Value = new List<BusinessTypeGroupModel>();

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
                        _SQLCommand.CommandText = "BusinessTypeGroup_MerchantCategory";



                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        BusinessTypeGroupModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new BusinessTypeGroupModel();
                            _result.BusinessTypeGroups = _SQLDataReader["BusinessTypeGroups"].ToString();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.Counted = Convert.ToInt32(_SQLDataReader["Counted"].ToString());
                            _result.BusinessTypeGroupsIconPath = _SQLDataReader["BusinessTypeGroupsIconPath"].ToString();
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