using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class TemporaryStampQrCodeModel
    {

        public string TempStampQrCode
        {
            get;
            set;
        }


        public TemporaryStampQrCodeModel() { }

     

        public static List<TemporaryStampQrCodeModel> TemporaryStampQrCode_GenerateTempQrCode(string StampCampaignCode, string EnterpriseAccNo,string SubscriberAccNo)
        {
            List<TemporaryStampQrCodeModel> _Value = new List<TemporaryStampQrCodeModel>();

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
                        _SQLCommand.CommandText = "TemporaryStampQrCode_GenerateTempQrCode";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        TemporaryStampQrCodeModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new TemporaryStampQrCodeModel();
                            _result.TempStampQrCode = _SQLDataReader["TempStampQrCode"].ToString();
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