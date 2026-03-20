using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class BusinessTypeModel
    {
        public int ID
        {
            get;
            set;
        }

        public string BusinessType
        {
            get;
            set;
        }
        public string BusinessTypeCode
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string BusinessTypeGroup
        {
            get;
            set;
        }

        public string BusinessTypeIconPath
        {
            get;
            set;
        }

        public string BusinessTypeGroupCode
        {
            get;
            set;
        }

        
        
        public BusinessTypeModel() { }



        public static List<BusinessTypeModel> BusinessType_load()
        {
            List<BusinessTypeModel> _Value = new List<BusinessTypeModel>();

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
                        _SQLCommand.CommandText = "BusinessType_load";
                       


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        BusinessTypeModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new BusinessTypeModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.BusinessType = _SQLDataReader["BusinessType"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            
                            
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