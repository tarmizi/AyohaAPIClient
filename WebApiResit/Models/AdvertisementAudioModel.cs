using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AdvertisementAudioModel
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
        public string AdvertisementAudio
        {
            get;
            set;
        }
        public string AdvertisementAudioName
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

        public AdvertisementAudioModel() { }









        public static string AdvertisementAudio_InsertUpdate(int ID, string AdvertisementCode, string AdvertisementAudio,
           string AdvertisementAudioName, string EnterpriseAccNo, string EnterpriseHQAccNo, string RowStatus)
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
                        _SQLCommand.CommandText = "AdvertisementAudio_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementAudio", AdvertisementAudio);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementAudioName", AdvertisementAudioName);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
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






        public static List<AdvertisementAudioModel> AdvertisementAudio_loadBy_EnterpriseHQAccNo_AdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            List<AdvertisementAudioModel> _Value = new List<AdvertisementAudioModel>();

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
                        _SQLCommand.CommandText = "AdvertisementAudio_loadBy_EnterpriseHQAccNo_AdvertisementCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementAudioModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementAudioModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementAudio = _SQLDataReader["AdvertisementAudio"].ToString();
                            _result.AdvertisementAudioName = _SQLDataReader["AdvertisementAudioName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
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