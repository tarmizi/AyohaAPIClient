using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AdvertisementApprovalStatusLogModel
    {
         public int ID
        {
            get;
            set;
        }

         public string AdvertisementID
        {
            get;
            set;
        }
         public string AdvertisementCode
        {
            get;
            set;
        }

         public string AdvertisementStatus
        {
            get;
            set;
        }


         public string AdvertisementStatusRemarks
         {
             get;
             set;
         }
         public string EnterpriseAccNo
         {
             get;
             set;
         }

         public string EnterpriseHQAccNo
         {
             get;
             set;
         }
         public string CreatedBy
         {
             get;
             set;
         }

         public string CreatedDate
         {
             get;
             set;
         }

        public AdvertisementApprovalStatusLogModel() { }



        public static List<AdvertisementApprovalStatusLogModel> AdvertisementApprovalStatusLog_LoadBy_EnterpriseHQAccNo_AdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            List<AdvertisementApprovalStatusLogModel> _Value = new List<AdvertisementApprovalStatusLogModel>();

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
                        _SQLCommand.CommandText = "AdvertisementApprovalStatusLog_LoadBy_EnterpriseHQAccNo_AdvertisementCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementApprovalStatusLogModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementApprovalStatusLogModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementID = _SQLDataReader["AdvertisementID"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementStatus = _SQLDataReader["AdvertisementStatus"].ToString();
                            _result.AdvertisementStatusRemarks = _SQLDataReader["AdvertisementStatusRemarks"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
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