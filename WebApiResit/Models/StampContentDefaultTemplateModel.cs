using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class StampContentDefaultTemplateModel
    {
        public string StampContent
        {
            get;
            set;
        }
        public string TextOne
        {
            get;
            set;
        }
        public StampContentDefaultTemplateModel() { }

        public static List<StampContentDefaultTemplateModel> StampContentDefaultTemplate_ResetByID(int ID, int StampCardRowID)
        {
            List<StampContentDefaultTemplateModel> _Value = new List<StampContentDefaultTemplateModel>();

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
                        _SQLCommand.CommandText = "StampContentDefaultTemplate_ResetByID";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StampCardRowID", StampCardRowID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampContentDefaultTemplateModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampContentDefaultTemplateModel();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
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