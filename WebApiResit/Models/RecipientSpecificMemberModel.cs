using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class RecipientSpecificMemberModel
    {
        public int ID
        {
            get;
            set;
        }

        public string NotificationCode
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
        public string AccountName
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }


        public string PlayerID
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
        public string RowStatus
        {
            get;
            set;
        }

        public int RowNumber
        {
            get;
            set;
        }


        public string word
        {
            get;
            set;
        }
        public RecipientSpecificMemberModel() { }







        public static string RecipientSpecificMember_Insert(string NotificationCode, string SubscriberAccNo,
        string EnterpriseAccNo, string CreatedBy)
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
                        _SQLCommand.CommandText = "RecipientSpecificMember_Insert";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", NotificationCode);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);

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









        public static List<RecipientSpecificMemberModel> RecipientSpecificMember_LoadByNotificationCode(string NotificationCode, string EnterpriseAccNo)
        {
            List<RecipientSpecificMemberModel> _Value = new List<RecipientSpecificMemberModel>();

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
                        _SQLCommand.CommandText = "RecipientSpecificMember_LoadByNotificationCode";
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", NotificationCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        RecipientSpecificMemberModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new RecipientSpecificMemberModel();
                             _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                             _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                             _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
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






        public static string RecipientSpecificMember_Delete(int ID)
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
                        _SQLCommand.CommandText = "RecipientSpecificMember_Delete";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);

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