using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaeWalletAccountSettingModel
    {
        public int ID
        {
            get;
            set;
        }

        public string Icon
        {
            get;
            set;
        }
        public string AyohaeWalletAccountSettingName
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }

        public AyohaeWalletAccountSettingModel() { }

        public static List<AyohaeWalletAccountSettingModel> AyohaeWalletAccountSetting_load()
        {
            List<AyohaeWalletAccountSettingModel> _Value = new List<AyohaeWalletAccountSettingModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletAccountSetting_load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletAccountSettingModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaeWalletAccountSettingModel();
                            _result.ID =Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.Icon = _SQLDataReader["Icon"].ToString();
                            _result.AyohaeWalletAccountSettingName = _SQLDataReader["AyohaeWalletAccountSettingName"].ToString();
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