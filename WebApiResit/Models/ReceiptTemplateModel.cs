using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class ReceiptTemplateModel
    {
        public int ID
        {
            get;
            set;
        }
        public string TemplateHeader
        {
            get;
            set;
        }
        public string TemplateDescription
        {
            get;
            set;
        }
        public string TemplateDetails
        {
            get;
            set;
        }
        public string TemplateAdvertisement
        {
            get;
            set;
        }


        public string TemplateFooter
        {
            get;
            set;
        }
        public string TemplateType
        {
            get;
            set;
        }




        public string Status
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }


        public string TagNote
        {
            get;
            set;
        }
        public string TemplateCode
        {
            get;
            set;
        }


        public ReceiptTemplateModel() { }





        public static List<ReceiptTemplateModel> ReceiptTemplate_getByTemplateEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<ReceiptTemplateModel> _Value = new List<ReceiptTemplateModel>();

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
                        _SQLCommand.CommandText = "ReceiptTemplate_getByTemplateEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        ReceiptTemplateModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new ReceiptTemplateModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.TemplateHeader = _SQLDataReader["TemplateHeader"].ToString();
                            _result.TemplateDescription = _SQLDataReader["TemplateDescription"].ToString();
                            _result.TemplateDetails = _SQLDataReader["TemplateDetails"].ToString();
                            _result.TemplateAdvertisement = _SQLDataReader["TemplateAdvertisement"].ToString();
                            _result.TemplateFooter = _SQLDataReader["TemplateFooter"].ToString();
                            _result.TemplateType = _SQLDataReader["TemplateType"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.TagNote = _SQLDataReader["TagNote"].ToString();
                            _result.TemplateCode = _SQLDataReader["TemplateCode"].ToString();

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





        public static List<ReceiptTemplateModel> ReceiptTemplate_getByTemplateCode(string TemplateCode)
        {
            List<ReceiptTemplateModel> _Value = new List<ReceiptTemplateModel>();

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
                        _SQLCommand.CommandText = "ReceiptTemplate_getByTemplateCode";
                        _SQLCommand.Parameters.AddWithValue("@TemplateCode", TemplateCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        ReceiptTemplateModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new ReceiptTemplateModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.TemplateHeader = _SQLDataReader["TemplateHeader"].ToString();
                            _result.TemplateDescription = _SQLDataReader["TemplateDescription"].ToString();
                            _result.TemplateDetails = _SQLDataReader["TemplateDetails"].ToString();
                            _result.TemplateAdvertisement = _SQLDataReader["TemplateAdvertisement"].ToString();
                            _result.TemplateFooter = _SQLDataReader["TemplateFooter"].ToString();
                            _result.TemplateType = _SQLDataReader["TemplateType"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.TagNote = _SQLDataReader["TagNote"].ToString();
                            _result.TemplateCode = _SQLDataReader["TemplateCode"].ToString();

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