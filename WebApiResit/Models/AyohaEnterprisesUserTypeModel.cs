using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaEnterprisesUserTypeModel
    {
        public int ID
        {
            get;
            set;
        }

        public string UserType
        {
            get;
            set;
        }

        public AyohaEnterprisesUserTypeModel() { }



        public static List<AyohaEnterprisesUserTypeModel> AyohaEnterprisesUserType_Load()
        {
            List<AyohaEnterprisesUserTypeModel> _Value = new List<AyohaEnterprisesUserTypeModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUserType_Load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaEnterprisesUserTypeModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserTypeModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.UserType = _SQLDataReader["UserType"].ToString();
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