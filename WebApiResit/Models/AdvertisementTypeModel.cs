using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AdvertisementTypeModel
    {
        public int ID
        {
            get;
            set;
        }

        public string AdvertismentTypeCode
        {
            get;
            set;
        }
        public string AdvertisementType
        {
            get;
            set;
        }
        public string Descriptions
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }


        public AdvertisementTypeModel() { }

        public static List<AdvertisementTypeModel> AdvertisementType_loadAll()
        {
            List<AdvertisementTypeModel> _Value = new List<AdvertisementTypeModel>();

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
                        _SQLCommand.CommandText = "AdvertisementType_loadAll";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementTypeModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementTypeModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertismentTypeCode = _SQLDataReader["AdvertismentTypeCode"].ToString();
                            _result.AdvertisementType = _SQLDataReader["AdvertisementType"].ToString();
                            _result.Descriptions = _SQLDataReader["Descriptions"].ToString();
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