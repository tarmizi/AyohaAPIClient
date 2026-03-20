using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class StampCampaignStamperModel
    {

         public int ID
        {
            get;
            set;
        }

         public string AccountName
        {
            get;
            set;
        }
         public string AccountNo
        {
            get;
            set;
        }
         public string StampCampaignCode
        {
            get;
            set;
        }
         public string UserType
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




        public StampCampaignStamperModel() { }




        public static string StampCampaignStamper_InsertUpdate(int ID, string AccountName, string AccountNo, string StampCampaignCode, string UserType, string CreatedBy, string RowStatus)
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
                        _SQLCommand.CommandText = "StampCampaignStamper_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AccountName", AccountName);
                        _SQLCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@UserType", UserType);

                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
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




        public static string StampCampaignStamper_Delete(int ID, string StampCampaignCode, string CreatedBy)
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
                        _SQLCommand.CommandText = "StampCampaignStamper_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
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




        public static List<StampCampaignStamperModel> StampCampaignStamper_LoadByStampCampaignCode(string StampCampaignCode)
        {
            List<StampCampaignStamperModel> _Value = new List<StampCampaignStamperModel>();

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
                        _SQLCommand.CommandText = "StampCampaignStamper_LoadByStampCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignStamperModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new StampCampaignStamperModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.UserType = _SQLDataReader["UserType"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
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