using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaMembershipLevelDescModel
    {
        public int ID
        {
            get;
            set;
        }

        public string AyohaMembershipLevelCode
        {
            get;
            set;
        }
        public string AyohaMembershipDescription
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }


        public AyohaMembershipLevelDescModel() { }



        public static List<AyohaMembershipLevelDescModel> AyohaMembershipLevelDesc_LoadbyMembershipCode(string AyohaMembershipLevelCode)
        {
            List<AyohaMembershipLevelDescModel> _Value = new List<AyohaMembershipLevelDescModel>();

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
                        _SQLCommand.CommandText = "AyohaMembershipLevelDesc_LoadbyMembershipCode";
                        _SQLCommand.Parameters.AddWithValue("@AyohaMembershipLevelCode", AyohaMembershipLevelCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMembershipLevelDescModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaMembershipLevelDescModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AyohaMembershipLevelCode = _SQLDataReader["AyohaMembershipLevelCode"].ToString();
                            _result.AyohaMembershipDescription = _SQLDataReader["AyohaMembershipDescription"].ToString();
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


    }
}