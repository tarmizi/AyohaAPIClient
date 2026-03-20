using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class RedeemItemModel
    {
        public int ID
        {
            get;
            set;
        }

        public string CloudReceiptAccNo
        {
            get;
            set;
        }


        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string ItemName
        {
            get;
            set;
        }
        public string ItemCode
        {
            get;
            set;
        }


        public string ItemPoint
        {
            get;
            set;
        }

        public string ItemImg
        {
            get;
            set;
        }

        public string RowStatus
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

        public string Remarks
        {
            get;
            set;
        }


        public RedeemItemModel() { }



        public static List<RedeemItemModel> RedeemItem_getByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<RedeemItemModel> _Value = new List<RedeemItemModel>();
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
                        _SQLCommand.CommandText = "RedeemItem_getByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        RedeemItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new RedeemItemModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CloudReceiptAccNo = _SQLDataReader["CloudReceiptAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemImg = _SQLDataReader["ItemImg"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();

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