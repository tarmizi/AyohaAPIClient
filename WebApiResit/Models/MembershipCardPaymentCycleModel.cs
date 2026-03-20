using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipCardPaymentCycleModel
    {

        public int ID
        {
            get;
            set;
        }



        public string PaymentCycle
        {
            get;
            set;
        }
        public int Code
        {
            get;
            set;
        }


        public int SequenceNo
        {
            get;
            set;
        }



        public MembershipCardPaymentCycleModel() { }



        public static List<MembershipCardPaymentCycleModel> MembershipCardPaymentCycleLoad()
        {
            List<MembershipCardPaymentCycleModel> _Value = new List<MembershipCardPaymentCycleModel>();

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
                        _SQLCommand.CommandText = "MembershipCardPaymentCycleLoad";
                     //   _SQLCommand.Parameters.AddWithValue("@EnterpriseAccountNo", EnterpriseAccountNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardPaymentCycleModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MembershipCardPaymentCycleModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.PaymentCycle = _SQLDataReader["PaymentCycle"].ToString();
                            _result.Code = Convert.ToInt32(_SQLDataReader["Code"].ToString());
                            _result.SequenceNo = Convert.ToInt32(_SQLDataReader["SequenceNo"].ToString());
                        


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