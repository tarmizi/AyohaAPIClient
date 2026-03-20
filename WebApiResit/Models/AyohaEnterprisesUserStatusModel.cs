using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaEnterprisesUserStatusModel
    {

          public int ID
        {
            get;
            set;
        }

        public string UserStatus
        {
            get;
            set;
        }

        public AyohaEnterprisesUserStatusModel() { }


        public static List<AyohaEnterprisesUserStatusModel> AyohaEnterprisesUserStatus_Load()
        {
            List<AyohaEnterprisesUserStatusModel> _Value = new List<AyohaEnterprisesUserStatusModel>();

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
                        _SQLCommand.CommandText = "AyohaEnterprisesUserStatus_Load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaEnterprisesUserStatusModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaEnterprisesUserStatusModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.UserStatus = _SQLDataReader["UserStatus"].ToString();
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