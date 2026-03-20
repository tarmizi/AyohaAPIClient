using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AdvertisementApprovalStatusModel
    {
        public int ID
        {
            get;
            set;
        }

        public string AdvertisementStatus
        {
            get;
            set;
        }
        public string AdvertisementStatusDesc
        {
            get;
            set;
        }
       
        public string RowStatus
        {
            get;
            set;
        }


        public AdvertisementApprovalStatusModel() { }

        public static List<AdvertisementApprovalStatusModel> AdvertisementApprovalStatus_Load_Master()
        {
            List<AdvertisementApprovalStatusModel> _Value = new List<AdvertisementApprovalStatusModel>();

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
                        _SQLCommand.CommandText = "AdvertisementApprovalStatus_Load_Master";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementApprovalStatusModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementApprovalStatusModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementStatus = _SQLDataReader["AdvertisementStatus"].ToString();
                            _result.AdvertisementStatusDesc = _SQLDataReader["AdvertisementStatusDesc"].ToString();
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