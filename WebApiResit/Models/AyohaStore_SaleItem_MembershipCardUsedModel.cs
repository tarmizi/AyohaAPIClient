using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaStore_SaleItem_MembershipCardUsedModel
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
        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }
        public string CreatedDate
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
        public string SaleItemCode
        {
            get;
            set;
        }
        public AyohaStore_SaleItem_MembershipCardUsedModel() { }

        public static string AyohaStore_SaleItem_MembershipCardUsed_InsertUpdate(string EnterpriseAccNo, string SubscriberAccNo,
 string MembershipCardCode, string SaleItemCode)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";
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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_MembershipCardUsed_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@SaleItemCode", SaleItemCode);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                        // _value = ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }


    }
}