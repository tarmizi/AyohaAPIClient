using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaUserProfile_BankAccountModel
    {
        public int ID
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string BankAccountNo
        {
            get;
            set;
        }
        public string BankName
        {
            get;
            set;
        }
        public string BankAccountType
        {
            get;
            set;
        }
        public string BankAccountName
        {
            get;
            set;
        }
        public string eWalletCashOutChargePersent
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
        public AyohaUserProfile_BankAccountModel() { }



        public static List<AyohaUserProfile_BankAccountModel> AyohaUserProfile_BankAccount_RequestCashOut_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaUserProfile_BankAccountModel> _Value = new List<AyohaUserProfile_BankAccountModel>();

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
                        _SQLCommand.CommandText = "AyohaUserProfile_BankAccount_RequestCashOut_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserProfile_BankAccountModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaUserProfile_BankAccountModel();

                            _result.BankAccountNo = _SQLDataReader["BankAccountNo"].ToString();
                            _result.BankName = _SQLDataReader["BankName"].ToString();
                            _result.BankAccountType = _SQLDataReader["BankAccountType"].ToString();
                            _result.BankAccountName = _SQLDataReader["BankAccountName"].ToString();
                            _result.eWalletCashOutChargePersent = _SQLDataReader["eWalletCashOutChargePersent"].ToString();




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



        public static string AyohaUserProfile_BankAccount_InsertUpdate(string SubscriberAccNo, string BankAccountNo, string BankName,
            string BankAccountType, string BankAccountName)
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
                        _SQLCommand.CommandText = "AyohaUserProfile_BankAccount_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@BankAccountNo", BankAccountNo);
                        _SQLCommand.Parameters.AddWithValue("@BankName", BankName);
                        _SQLCommand.Parameters.AddWithValue("@BankAccountType", BankAccountType);
                        _SQLCommand.Parameters.AddWithValue("@BankAccountName", BankAccountName);
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
                       

                        // OneSignalModel.onesignalAPI_AyohaNotification_UserProfileCreated(AccountName, PlayerID);
                    }

                }

            }



            return _value;
        }



    }
}