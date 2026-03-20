using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaUserGroupModel
    {
        public int ID
        {
            get;
            set;
        }

        public string AyohaUserDesc
        {
            get;
            set;
        }



        public string AyohaUserGroupCode
        {
            get;
            set;
        }


        public AyohaUserGroupModel() { }


        public static List<AyohaUserGroupModel> AyohaUserGroup_Load()
        {
            List<AyohaUserGroupModel> _Value = new List<AyohaUserGroupModel>();

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
                        _SQLCommand.CommandText = "AyohaUserGroup_Load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserGroupModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaUserGroupModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AyohaUserDesc = _SQLDataReader["AyohaUserDesc"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
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