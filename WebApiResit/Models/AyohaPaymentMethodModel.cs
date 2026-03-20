using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaPaymentMethodModel
    {
         public string ID
        {
            get;
            set;
        }

        public string Icon
        {
            get;
            set;
        }
        public string PaymentMethodName
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }

        public AyohaPaymentMethodModel() { }


        public static List<AyohaPaymentMethodModel> AyohaPaymentMethod_load()
        {
            List<AyohaPaymentMethodModel> _Value = new List<AyohaPaymentMethodModel>();

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
                        _SQLCommand.CommandText = "AyohaPaymentMethod_load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaPaymentMethodModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaPaymentMethodModel();
                            _result.ID = _SQLDataReader["ID"].ToString();
                            _result.Icon = _SQLDataReader["Icon"].ToString();
                            _result.PaymentMethodName = _SQLDataReader["PaymentMethodName"].ToString();
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