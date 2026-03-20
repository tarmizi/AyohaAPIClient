using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipCardPaymentPlanModel
    {
        public int ID
        {
            get;
            set;
        }
        public string PaymentPlanCode
        {
            get;
            set;
        }
        public string PaymentCycleCode
        {
            get;
            set;
        }
        public string PaymentPlanPrice
        {
            get;
            set;
        }
        public string PaymentPlanDescription
        {
            get;
            set;
        }

        public string isDiscount
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string DiscountPercentage
        {
            get;
            set;
        }
        public string PaymentPlanPriceDiscount
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

        public string RowStatus
        {
            get;
            set;
        }

        public MembershipCardPaymentPlanModel() { }




        public static List<MembershipCardPaymentPlanModel> MembershipCardPaymentPlan_LoadBy_PaymentPlanCode(string PaymentPlanCode)
        {
            List<MembershipCardPaymentPlanModel> _Value = new List<MembershipCardPaymentPlanModel>();

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
                        _SQLCommand.CommandText = "MembershipCardPaymentPlan_LoadBy_PaymentPlanCode";
                        _SQLCommand.Parameters.AddWithValue("@PaymentPlanCode", PaymentPlanCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardPaymentPlanModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipCardPaymentPlanModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.PaymentPlanCode = _SQLDataReader["PaymentPlanCode"].ToString();
                            _result.PaymentCycleCode = _SQLDataReader["PaymentCycleCode"].ToString();
                            _result.PaymentPlanPrice = _SQLDataReader["PaymentPlanPrice"].ToString();
                            _result.PaymentPlanDescription = _SQLDataReader["PaymentPlanDescription"].ToString();
                            _result.isDiscount = _SQLDataReader["isDiscount"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.DiscountPercentage = _SQLDataReader["DiscountPercentage"].ToString();
                            _result.PaymentPlanPriceDiscount = _SQLDataReader["PaymentPlanPriceDiscount"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            //_result.StampedByDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedByDate"]);
                            //_result.StampedByDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["StampedByDate"]);
                            //_result.StampedByDate_MonthYear = ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["StampedByDate"]), String.Format("{0:yyyy}", _SQLDataReader["StampedByDate"]));



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