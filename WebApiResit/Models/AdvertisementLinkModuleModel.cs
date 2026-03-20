using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AdvertisementLinkModuleModel
    {
         public int ID
        {
            get;
            set;
        }

        public string AdvertisementCode
        {
            get;
            set;
        }
        public string ModuleCode
        {
            get;
            set;
        }
        public string ModuleName
        {
            get;
            set;
        }
        public string ModuleDesc
        {
            get;
            set;
        }
        
        public string RowStatus
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

        public string CreatedBy
        {
            get;
            set;
        }

        public string CreatedDate
        {
            get;
            set;
        }
        public AdvertisementLinkModuleModel() { }



        public static string AdvertisementLinkModule_InsertUpdate(int ID, string AdvertisementCode, string ModuleCode,
           string ModuleName,string ModuleDesc, string RowStatus, string EnterpriseHQAccNo, string EnterpriseAccNo, string CreatedBy)
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
                        _SQLCommand.CommandText = "AdvertisementLinkModule_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@ModuleCode", ModuleCode);
                        _SQLCommand.Parameters.AddWithValue("@ModuleName", ModuleName);
                        _SQLCommand.Parameters.AddWithValue("@ModuleDesc", ModuleDesc);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo); 
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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




        public static List<AdvertisementLinkModuleModel> AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_AdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            List<AdvertisementLinkModuleModel> _Value = new List<AdvertisementLinkModuleModel>();

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
                        _SQLCommand.CommandText = "AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_AdvertisementCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementLinkModuleModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementLinkModuleModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.ModuleCode = _SQLDataReader["ModuleCode"].ToString();
                            _result.ModuleName = _SQLDataReader["ModuleName"].ToString();
                            _result.ModuleDesc = _SQLDataReader["ModuleDesc"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
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












        public static List<AdvertisementLinkModuleModel> AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_ModuleCode(string EnterpriseHQAccNo, int ModuleCode)
        {
            List<AdvertisementLinkModuleModel> _Value = new List<AdvertisementLinkModuleModel>();

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
                        _SQLCommand.CommandText = "AdvertisementLinkModule_loadBy_EnterpriseHQAccNo_ModuleCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ModuleCode", ModuleCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementLinkModuleModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementLinkModuleModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.ModuleCode = _SQLDataReader["ModuleCode"].ToString();
                            _result.ModuleName = _SQLDataReader["ModuleName"].ToString();
                            _result.ModuleDesc = _SQLDataReader["ModuleDesc"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
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