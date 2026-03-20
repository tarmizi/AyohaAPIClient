using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipCardCampaingEntitledModel
    {
        public int ID
        {
            get;
            set;
        }



        public string CampaignCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string EnterpriseHQAccNo
        {
            get;
            set;
        }


        public string MembershipCardCode
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
          public string CampaignType
        {
            get;
            set;
        }

        




          public string CampaignName
        {
            get;
            set;
        }


          public string CampaignStartDate
        {
            get;
            set;
        }
          public string CampaignEndDate
        {
            get;
            set;
        }

          public string isRulePopUp
        {
            get;
            set;
        }
          public string Stamp
        {
            get;
            set;
        }









            public string isStampRulePopUp
        {
            get;
            set;
        }
          public string EnterpriseName
        {
            get;
            set;
        }

             public string EnterpriseLogo
        {
            get;
            set;
        }
          public string CountLoyaltyStamped
        {
            get;
            set;
        }

          public string Remarks
        {
            get;
            set;
        }




          public string isRequiredStartEndDate
          {
              get;
              set;
          }
          public string isCampaignExpired
          {
              get;
              set;
          }

          public string CampaignDayLeft
          {
              get;
              set;
          }
          public string MembershipCardName
          {
              get;
              set;
          }
          public string MembershipcardImg
          {
              get;
              set;
          }
        

          public MembershipCardCampaingEntitledModel() { }

 
          public static string MembershipCardCampaingEntitled_InsertUpdate(int ID, string CampaignCode, string EnterpriseHQAccNo,
      string EnterpriseAccNo, string MembershipCardCode, string CreatedBy, string RowStatus, string CampaignType)
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
                          _SQLCommand.CommandText = "MembershipCardCampaingEntitled_InsertUpdate";
                          _SQLCommand.Parameters.AddWithValue("@ID", ID);
                          _SQLCommand.Parameters.AddWithValue("@CampaignCode", CampaignCode);
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                          _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                          _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                          _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                          _SQLCommand.Parameters.AddWithValue("@CampaignType", CampaignType);
                          
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





          public static List<MembershipCardCampaingEntitledModel> MembershipCardCampaingEntitled_LoadByMembershipCardCode(string MembershipCardCode, string SubscriberAccNo)
          {
              List<MembershipCardCampaingEntitledModel> _Value = new List<MembershipCardCampaingEntitledModel>();

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
                          _SQLCommand.CommandText = "MembershipCardCampaingEntitled_LoadByMembershipCardCode";
                          _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                          
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          MembershipCardCampaingEntitledModel _result;
                          while (_SQLDataReader.Read())
                          {
                              
                              _result = new MembershipCardCampaingEntitledModel();
                              //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              //_result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                              //_result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              //_result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                              //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                              //_result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              //_result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              //_result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              //_result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              //_result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              //_result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                              //_result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                              //_result.CampaignStartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["CampaignStartDate"]);
                              //_result.CampaignEndDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["CampaignEndDate"]);
                              //_result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                              //_result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();                              
                              //_result.Stamp = _SQLDataReader["Stamp"].ToString();
                              //_result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              //_result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              //_result.CountLoyaltyStamped = _SQLDataReader["CountLoyaltyStamped"].ToString();


                              _result = new MembershipCardCampaingEntitledModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                              _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                              _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString(); 
                              _result.Remarks = _SQLDataReader["Remarks"].ToString();
                              _result.isRulePopUp = _SQLDataReader["isRulePopUp"].ToString();
                              _result.Stamp = _SQLDataReader["Stamp"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.CountLoyaltyStamped = _SQLDataReader["CountLoyaltyStamped"].ToString();
                              _result.CampaignStartDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["CampaignStartDate"]);
                              _result.CampaignEndDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["CampaignEndDate"]);

                              _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                              _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                              _result.CampaignDayLeft = _SQLDataReader["CampaignDayLeft"].ToString();
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


          public static List<MembershipCardCampaingEntitledModel> MembershipCardCampaingEntitled_LoadByEnterpriseAccNo_MerchantDetailPage(string EnterpriseAccNo, string SubscriberAccNo)
          {
              List<MembershipCardCampaingEntitledModel> _Value = new List<MembershipCardCampaingEntitledModel>();

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
                          _SQLCommand.CommandText = "MembershipCardCampaingEntitled_LoadByEnterpriseAccNo_MerchantDetailPage";
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          MembershipCardCampaingEntitledModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new MembershipCardCampaingEntitledModel();
                              //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              //_result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                              //_result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              //_result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                              //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                              //_result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              //_result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              //_result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              //_result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              //_result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              //_result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                              //_result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                              //_result.CampaignStartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["CampaignStartDate"]);
                              //_result.CampaignEndDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["CampaignEndDate"]);
                              //_result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                              //_result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();                              
                              //_result.Stamp = _SQLDataReader["Stamp"].ToString();
                              //_result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              //_result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              //_result.CountLoyaltyStamped = _SQLDataReader["CountLoyaltyStamped"].ToString();


                              _result = new MembershipCardCampaingEntitledModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                              _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                              _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.Remarks = _SQLDataReader["Remarks"].ToString();
                              _result.isRulePopUp = _SQLDataReader["isRulePopUp"].ToString();
                              _result.Stamp = _SQLDataReader["Stamp"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.CountLoyaltyStamped = _SQLDataReader["CountLoyaltyStamped"].ToString();
                              _result.CampaignStartDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["CampaignStartDate"]);
                              _result.CampaignEndDate = String.Format("{0:dd-MM-yyyy}", _SQLDataReader["CampaignEndDate"]);

                              _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                              _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                              _result.CampaignDayLeft = _SQLDataReader["CampaignDayLeft"].ToString();
                              _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                              _result.MembershipcardImg = _SQLDataReader["MembershipcardImg"].ToString();                               
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





          public static List<MembershipCardCampaingEntitledModel> MembershipCardCampaingEntitled_MerchantLoadByMembershipCardCode(string MembershipCardCode, string EnterpriseAccNo)
          {
              List<MembershipCardCampaingEntitledModel> _Value = new List<MembershipCardCampaingEntitledModel>();

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
                          _SQLCommand.CommandText = "MembershipCardCampaingEntitled_MerchantLoadByMembershipCardCode";
                          _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);

                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          MembershipCardCampaingEntitledModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new MembershipCardCampaingEntitledModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                              _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                              _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              //_result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              //_result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                           
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





          public static string MembershipCardCampaingEntitled_Delete(int ID, string CreatedBy)
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
                          _SQLCommand.CommandText = "MembershipCardCampaingEntitled_Delete";
                          _SQLCommand.Parameters.AddWithValue("@ID", ID);
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

    }
}