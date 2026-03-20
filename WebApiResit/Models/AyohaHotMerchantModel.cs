using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaHotMerchantModel : EnterprisesModel
    {
       
        public int ID
        {
            get;
            set;
        }



        public string AyohaHotMerchant_VideoUrl
        {
            get;
            set;
        }
        public string AyohaHotMerchant_CoverImgVideoUrl
        {
            get;
            set;
        }



        public string AyohaHotMerchant_Description
        {
            get;
            set;
        }
        public string AyohaHotMerchant_Code
        {
            get;
            set;
        }
        public string AyohaHotMerchant_Status
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }



        public string RowStatus
        {
            get;
            set;
        }
        public string Segment
        {
            get;
            set;
        }

        public string StartDate
        {
            get;
            set;
        }



        public string EndDate
        {
            get;
            set;
        }
        public string isUsedEndDate
        {
            get;
            set;
        }



        public string CreatedDate
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }

        public string ModifiedDate
        {
            get;
            set;
        }


        //
        public string ModifiedBy
        {
            get;
            set;
        }
        public string AyohaHotMerchant_BackgroundImgUrl
        {
            get;
            set;
        }



        public AyohaHotMerchantModel() { }








        public static List<AyohaHotMerchantModel> AyohaHotMerchant_LoadByAyohaHotMerchant_Status(string AyohaHotMerchant_Status)
        {
            List<AyohaHotMerchantModel> _Value = new List<AyohaHotMerchantModel>();

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
                        _SQLCommand.CommandText = "AyohaHotMerchant_LoadByAyohaHotMerchant_Status";
                        _SQLCommand.Parameters.AddWithValue("@AyohaHotMerchant_Status", AyohaHotMerchant_Status);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaHotMerchantModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaHotMerchantModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AyohaHotMerchant_VideoUrl = _SQLDataReader["AyohaHotMerchant_VideoUrl"].ToString();
                            _result.AyohaHotMerchant_CoverImgVideoUrl = _SQLDataReader["AyohaHotMerchant_CoverImgVideoUrl"].ToString();
                            _result.AyohaHotMerchant_Description = _SQLDataReader["AyohaHotMerchant_Description"].ToString();
                            _result.AyohaHotMerchant_Code = _SQLDataReader["AyohaHotMerchant_Code"].ToString();
                            _result.AyohaHotMerchant_Status = _SQLDataReader["AyohaHotMerchant_Status"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.Segment = _SQLDataReader["Segment"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EndDate"]);
                            _result.isUsedEndDate = _SQLDataReader["isUsedEndDate"].ToString(); 
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString(); 
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.AyohaHotMerchant_BackgroundImgUrl = _SQLDataReader["AyohaHotMerchant_SourceURL"].ToString();
                            ((EnterprisesModel)_result).EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            ((EnterprisesModel)_result).EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            ((EnterprisesModel)_result).EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            ((EnterprisesModel)_result).EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            ((EnterprisesModel)_result).PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            ((EnterprisesModel)_result).EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            ((EnterprisesModel)_result).EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
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