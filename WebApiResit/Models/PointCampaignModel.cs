using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class PointCampaignModel
    {
        public int ID
        {
            get;
            set;
        }



        public string PointCampaignCode
        {
            get;
            set;
        }
        public string PointCampaignName
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


        public string ModifiedStartDate
        {
            get;
            set;
        }


        public string ModifiedEndDate
        {
            get;
            set;
        }


        public string StrEndDate
        {
            get;
            set;
        }




        public string RowStatus
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string CreatedByAccNo
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




        public string PointCampaignPremiumQRCode
        {
            get;
            set;
        }



        public string TermAndCondition
        {
            get;
            set;
        }



        public string isPointRulePopUp
        {
            get;
            set;
        }





        public string PointOption
        {
            get;
            set;
        }



        public string PointAmountEquation
        {
            get;
            set;
        }


        public string RequiredReceiptBillNo
        {
            get;
            set;
        }

        public int CountMembers
        {
            get;
            set;
        }

        
        public PointCampaignModel() { }




      //  public static string PointCampaign_InsertUpdate(int ID, string PointCampaignCode, string PointCampaignName, string StartDate, string EndDate, string StrEndDate, string RowStatus
      //, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy, string Remarks, string PointCampaignPremiumQRCode)
      //  {

      //      SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
      //      string _value = "true";
      //      using (SqlConnection _DBConnection = _SQLConnection)
      //      {
      //          SqlCommand _SQLCommand = new SqlCommand();
      //          _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
      //          _SQLCommand.CommandTimeout = 0;
      //          using (_SQLCommand)
      //          {
      //              try
      //              {
      //                  _SQLCommand.Connection = _DBConnection;
      //                  _SQLCommand.CommandText = "PointCampaign_InsertUpdate";
      //                  _SQLCommand.Parameters.AddWithValue("@ID", ID);
      //                  _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
      //                  _SQLCommand.Parameters.AddWithValue("@PointCampaignName", PointCampaignName);
      //                  _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
      //                  _SQLCommand.Parameters.AddWithValue("@EndDate", EndDate);
      //                  _SQLCommand.Parameters.AddWithValue("@StrEndDate", StrEndDate);
      //                  _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
      //                  _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
      //                  _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
      //                  _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
      //                  _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
      //                  _SQLCommand.Parameters.AddWithValue("@PointCampaignPremiumQRCode", PointCampaignPremiumQRCode);
      //                  _DBConnection.Open();
      //                  _SQLCommand.ExecuteNonQuery();
      //              }

      //              catch (Exception ex)
      //              {
      //                  _value = "false," + ex.ToString(); 
      //              }

      //              finally
      //              {

      //                  _DBConnection.Close();

      //              }

      //          }

      //      }



      //      return _value;
      //  }




        public static string PointCampaign_Insert(string PointCampaignName, string StartDate, string EndDate, string StrEndDate, string RowStatus
  , string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy, string Remarks, string PointCampaignPremiumQRCode, string TermAndCondition)
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
                        _SQLCommand.CommandText = "PointCampaign_Insert"; 
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignName", PointCampaignName);
                        _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                        _SQLCommand.Parameters.AddWithValue("@EndDate", EndDate);
                        _SQLCommand.Parameters.AddWithValue("@StrEndDate", StrEndDate);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignPremiumQRCode", PointCampaignPremiumQRCode);
                        _SQLCommand.Parameters.AddWithValue("@TermAndCondition", TermAndCondition);                        
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }




        public static string PointCampaign_Update(int ID,string PointCampaignCode,string PointCampaignName, string StartDate, string EndDate, string StrEndDate, string RowStatus
, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy, string Remarks, string PointCampaignPremiumQRCode, string TermAndCondition, string isPointRulePopUp, string PointOption, string PointAmountEquation, string RequiredReceiptBillNo)
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
                        _SQLCommand.CommandText = "PointCampaign_Update";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignName", PointCampaignName);
                        _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                        _SQLCommand.Parameters.AddWithValue("@EndDate", EndDate);
                        _SQLCommand.Parameters.AddWithValue("@StrEndDate", StrEndDate);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        //_SQLCommand.Parameters.AddWithValue("@PointCampaignPremiumQRCode", PointCampaignPremiumQRCode);
                        _SQLCommand.Parameters.AddWithValue("@TermAndCondition", TermAndCondition);
                        _SQLCommand.Parameters.AddWithValue("@isPointRulePopUp", isPointRulePopUp);

                        _SQLCommand.Parameters.AddWithValue("@PointOption", PointOption);
                        _SQLCommand.Parameters.AddWithValue("@PointAmountEquation", PointAmountEquation);
                        _SQLCommand.Parameters.AddWithValue("@RequiredReceiptBillNo", RequiredReceiptBillNo);
                        
                        
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }



        public static List<PointCampaignModel> PointCampaign_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<PointCampaignModel> _Value = new List<PointCampaignModel>();

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
                        _SQLCommand.CommandText = "PointCampaign_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new PointCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                          //  _result.StartDate = _SQLDataReader["StartDate"].ToString();
                           // _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);


                            _result.ModifiedStartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            _result.ModifiedEndDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StrEndDate = _SQLDataReader["StrEndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.PointCampaignPremiumQRCode = _SQLDataReader["PointCampaignPremiumQRCode"].ToString();
                            _result.isPointRulePopUp = _SQLDataReader["isPointRulePopUp"].ToString();

                            _result.PointOption = _SQLDataReader["PointOption"].ToString();
                            _result.PointAmountEquation = _SQLDataReader["PointAmountEquation"].ToString();
                            _result.RequiredReceiptBillNo = _SQLDataReader["RequiredReceiptBillNo"].ToString();
                            _result.CountMembers = Convert.ToInt32(_SQLDataReader["CountMembers"].ToString());


                            
                            
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









        public static List<PointCampaignModel> PointCampaign_LoadByPointCampaignCode(string PointCampaignCode)
        {
            List<PointCampaignModel> _Value = new List<PointCampaignModel>();

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
                        _SQLCommand.CommandText = "PointCampaign_LoadByPointCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new PointCampaignModel();
                           
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.isPointRulePopUp = _SQLDataReader["isPointRulePopUp"].ToString();
                            _result.PointOption = _SQLDataReader["PointOption"].ToString();
                            _result.PointAmountEquation = _SQLDataReader["PointAmountEquation"].ToString();
                            _result.RequiredReceiptBillNo = _SQLDataReader["RequiredReceiptBillNo"].ToString();

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