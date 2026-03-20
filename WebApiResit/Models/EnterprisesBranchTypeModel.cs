using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class EnterprisesBranchTypeModel
    {

         public int ID
        {
            get;
            set;
        }

        public string BranchType
        {
            get;
            set;
        }
        public string BranchCode
        {
            get;
            set;
        }

        public EnterprisesBranchTypeModel() { }

        public static List<EnterprisesBranchTypeModel> EnterprisesBranchType_load()
        {
            List<EnterprisesBranchTypeModel> _Value = new List<EnterprisesBranchTypeModel>();

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
                        _SQLCommand.CommandText = "EnterprisesBranchType_load";



                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesBranchTypeModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesBranchTypeModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.BranchType = _SQLDataReader["BranchType"].ToString();
                            _result.BranchCode = _SQLDataReader["BranchCode"].ToString();
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