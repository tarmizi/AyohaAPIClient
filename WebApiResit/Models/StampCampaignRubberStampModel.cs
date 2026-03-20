using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApiResit.Models
{
    public class StampCampaignRubberStampModel
    {
          public int ID
        {
            get;
            set;
        }



        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string StampCampaignCode
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
        public string RowStatus
        {
            get;
            set;
        }

        public string ModifiedBy
        {
            get;
            set;
        }




        public string ModifiedDate
        {
            get;
            set;
        }






        public string EnterpriseHQAccNo
        {
            get;
            set;
        }

        public string RubberStampImagePath
        {
            get;
            set;
        }




        public string RubberStampImageName
        {
            get;
            set;
        }




        public StampCampaignRubberStampModel() { }


        public static List<StampCampaignRubberStampModel> StampCampaignRubberStamp_LoadByStampCampaignCode(string StampCampaignCode)
        {
            List<StampCampaignRubberStampModel> _Value = new List<StampCampaignRubberStampModel>();

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
                        _SQLCommand.CommandText = "StampCampaignRubberStamp_LoadByStampCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignRubberStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCampaignRubberStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.RubberStampImagePath = _SQLDataReader["RubberStampImagePath"].ToString();
                            _result.RubberStampImageName = _SQLDataReader["RubberStampImageName"].ToString();
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