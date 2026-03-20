using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaRewardEventModel
    {
        public int ID
        {
            get;
            set;
        }



        public string EventCode
        {
            get;
            set;
        }
        public string EventType
        {
            get;
            set;
        }



        public string EventName
        {
            get;
            set;
        }
        public string EventStartDate_Day
        {
            get;
            set;
        }

        public string EventStartDate_Month
        {
            get;
            set;
        }

        
        public string EventStartTime
        {
            get;
            set;
        }
        public string EventEndDate_Day
        {
            get;
            set;
        }

        public string EventEndDate_Month
        {
            get;
            set;
        }


        public string EventEndTime
        {
            get;
            set;
        }
        public string EventSegmentMembershipCardCode
        {
            get;
            set;
        }

        public string EventDescription
        {
            get;
            set;
        }



        public string EventCategoryCode
        {
            get;
            set;
        }
        public string EventLocationCoordinate
        {
            get;
            set;
        }



        public string EventLocationName
        {
            get;
            set;
        }
        public string EventCoverPhoto
        {
            get;
            set;
        }

        public string EventUrlTicket
        {
            get;
            set;
        }


        //
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string EventStatus
        {
            get;
            set;
        }



        public string RowStatus
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


        //
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


         public string EnterpriseLogo
        {
            get;
            set;
        }
         public string EnterpriseName
        {
            get;
            set;
        }

         public string RespondStatus
        {
            get;
            set;
        }





         public string RespondStatus_IwillAttendCount
         {
             get;
             set;
         }

         public string RespondStatus_InterestedCount
         {
             get;
             set;
         }

         public string SubscriberAccNo
         {
             get;
             set;
         }

         public string RedeemStatus
         {
             get;
             set;
         }

         public string SearchCol
         {
             get;
             set;
         }

         public string isMember
         {
             get;
             set;
         }  
        
        
          public AyohaRewardEventModel() { }


          public static List<AyohaRewardEventModel> AyohaRewardEvent_LoadBySubscriberAccNo(string SubscriberAccNo)
          {
              List<AyohaRewardEventModel> _Value = new List<AyohaRewardEventModel>();

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
                          _SQLCommand.CommandText = "AyohaRewardEvent_LoadBySubscriberAccNo";
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          AyohaRewardEventModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new AyohaRewardEventModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.EventCode = _SQLDataReader["EventCode"].ToString();
                              _result.EventType = _SQLDataReader["EventType"].ToString();
                              _result.EventName = _SQLDataReader["EventName"].ToString();
                             // _result.EventStartDate = _SQLDataReader["EventStartDate"].ToString();
                              _result.EventStartDate_Day = ExtractDay(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartDate_Month = ExtractMonth(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartTime = _SQLDataReader["EventStartTime"].ToString();



                              _result.EventEndDate_Day =  ExtractDay(_SQLDataReader["EventEndDate"].ToString());
                              _result.EventEndDate_Month = ExtractMonth(_SQLDataReader["EventEndDate"].ToString());


                              _result.EventEndTime = _SQLDataReader["EventEndTime"].ToString();
                              _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                              _result.EventCategoryCode = _SQLDataReader["EventCategoryCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.EventLocationCoordinate = _SQLDataReader["EventLocationCoordinate"].ToString();
                              _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                              _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                              _result.EventUrlTicket = _SQLDataReader["EventUrlTicket"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.RespondStatus = _SQLDataReader["RespondStatus"].ToString();
                              _result.RespondStatus_IwillAttendCount = _SQLDataReader["RespondStatus_IwillAttendCount"].ToString();
                              _result.RespondStatus_InterestedCount = _SQLDataReader["RespondStatus_InterestedCount"].ToString();   
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






          public static List<AyohaRewardEventModel> EventCampaignRedeemLoadByEventRedeemStatus(string SubscriberAccNo, string RedeemStatus)
          {
              List<AyohaRewardEventModel> _Value = new List<AyohaRewardEventModel>();

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
                          _SQLCommand.CommandText = "EventCampaignRedeemLoadByEventRedeemStatus";
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                          _SQLCommand.Parameters.AddWithValue("@RedeemStatus", RedeemStatus);
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          AyohaRewardEventModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new AyohaRewardEventModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.EventCode = _SQLDataReader["EventCode"].ToString();
                              _result.EventType = _SQLDataReader["EventType"].ToString();
                              _result.EventName = _SQLDataReader["EventName"].ToString();
                              // _result.EventStartDate = _SQLDataReader["EventStartDate"].ToString();
                              _result.EventStartDate_Day = ExtractDay(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartDate_Month = ExtractMonth(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartTime = _SQLDataReader["EventStartTime"].ToString();



                              _result.EventEndDate_Day = ExtractDay(_SQLDataReader["EventEndDate"].ToString());
                              _result.EventEndDate_Month = ExtractMonth(_SQLDataReader["EventEndDate"].ToString());


                              _result.EventEndTime = _SQLDataReader["EventEndTime"].ToString();
                              _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                              _result.EventCategoryCode = _SQLDataReader["EventCategoryCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.EventLocationCoordinate = _SQLDataReader["EventLocationCoordinate"].ToString();
                              _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                              _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                              _result.EventUrlTicket = _SQLDataReader["EventUrlTicket"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.RespondStatus = _SQLDataReader["RespondStatus"].ToString();
                              _result.RespondStatus_IwillAttendCount = _SQLDataReader["RespondStatus_IwillAttendCount"].ToString();
                              _result.RespondStatus_InterestedCount = _SQLDataReader["RespondStatus_InterestedCount"].ToString();
                              _result.SearchCol = _SQLDataReader["EventName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EventEndDate"]) + "|" + _SQLDataReader["EventLocationName"].ToString() + "|" + _SQLDataReader["EventDescription"].ToString() + "|" + _SQLDataReader["EventStartDate"].ToString();
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







          public static List<AyohaRewardEventModel> Dashboard_Event_SuccessCheckIn_Load_EventPerk(string EnterpriseAccNo, string SubscriberAccNo)
          {
              List<AyohaRewardEventModel> _Value = new List<AyohaRewardEventModel>();

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
                          _SQLCommand.CommandText = "Dashboard_Event_SuccessCheckIn_Load_EventPerk";
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                         
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          AyohaRewardEventModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new AyohaRewardEventModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.EventCode = _SQLDataReader["EventCode"].ToString();
                              _result.EventType = _SQLDataReader["EventType"].ToString();
                              _result.EventName = _SQLDataReader["EventName"].ToString();
                              // _result.EventStartDate = _SQLDataReader["EventStartDate"].ToString();
                              _result.EventStartDate_Day = ExtractDay(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartDate_Month = ExtractMonth(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartTime = _SQLDataReader["EventStartTime"].ToString();



                              _result.EventEndDate_Day = ExtractDay(_SQLDataReader["EventEndDate"].ToString());
                              _result.EventEndDate_Month = ExtractMonth(_SQLDataReader["EventEndDate"].ToString());


                              _result.EventEndTime = _SQLDataReader["EventEndTime"].ToString();
                              _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                              _result.EventCategoryCode = _SQLDataReader["EventCategoryCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.EventLocationCoordinate = _SQLDataReader["EventLocationCoordinate"].ToString();
                              _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                              _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                              _result.EventUrlTicket = _SQLDataReader["EventUrlTicket"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.RespondStatus = _SQLDataReader["RespondStatus"].ToString();
                              _result.RespondStatus_IwillAttendCount = _SQLDataReader["RespondStatus_IwillAttendCount"].ToString();
                              _result.RespondStatus_InterestedCount = _SQLDataReader["RespondStatus_InterestedCount"].ToString();
                              _result.isMember = _SQLDataReader["isMember"].ToString();
                              _result.SearchCol = _SQLDataReader["EventName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EventEndDate"]) + "|" + _SQLDataReader["EventLocationName"].ToString() + "|" + _SQLDataReader["EventDescription"].ToString() + "|" + _SQLDataReader["EventStartDate"].ToString();
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

          public static List<AyohaRewardEventModel> AyohaRewardEvent_LoadBySubscriberAccNoAndEventCode(string SubscriberAccNo, string EventCode)
          {
              List<AyohaRewardEventModel> _Value = new List<AyohaRewardEventModel>();

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
                          _SQLCommand.CommandText = "AyohaRewardEvent_LoadBySubscriberAccNoAndEventCode";
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                          _SQLCommand.Parameters.AddWithValue("@EventCode", EventCode);
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          AyohaRewardEventModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new AyohaRewardEventModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.EventCode = _SQLDataReader["EventCode"].ToString();
                              _result.EventType = _SQLDataReader["EventType"].ToString();
                              _result.EventName = _SQLDataReader["EventName"].ToString();
                              // _result.EventStartDate = _SQLDataReader["EventStartDate"].ToString();
                              _result.EventStartDate_Day = ExtractDay(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartDate_Month = ExtractMonth(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartTime = _SQLDataReader["EventStartTime"].ToString();



                              _result.EventEndDate_Day = ExtractDay(_SQLDataReader["EventEndDate"].ToString());
                              _result.EventEndDate_Month = ExtractMonth(_SQLDataReader["EventEndDate"].ToString());


                              _result.EventEndTime = _SQLDataReader["EventEndTime"].ToString();
                              _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                              _result.EventCategoryCode = _SQLDataReader["EventCategoryCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.EventLocationCoordinate = _SQLDataReader["EventLocationCoordinate"].ToString();
                              _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                              _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                              _result.EventUrlTicket = _SQLDataReader["EventUrlTicket"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.RespondStatus = _SQLDataReader["RespondStatus"].ToString();
                              _result.RespondStatus_IwillAttendCount = _SQLDataReader["RespondStatus_IwillAttendCount"].ToString();
                              _result.RespondStatus_InterestedCount = _SQLDataReader["RespondStatus_InterestedCount"].ToString();
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
          public static List<AyohaRewardEventModel> AyohaRewardEvent_LoadBySubscriberAccNo_EnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
          {
              List<AyohaRewardEventModel> _Value = new List<AyohaRewardEventModel>();

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
                          _SQLCommand.CommandText = "AyohaRewardEvent_LoadBySubscriberAccNo_EnterpriseAccNo";
                          _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                          _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          AyohaRewardEventModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new AyohaRewardEventModel();
                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.EventCode = _SQLDataReader["EventCode"].ToString();
                              _result.EventType = _SQLDataReader["EventType"].ToString();
                              _result.EventName = _SQLDataReader["EventName"].ToString();
                              // _result.EventStartDate = _SQLDataReader["EventStartDate"].ToString();
                              _result.EventStartDate_Day = ExtractDay(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartDate_Month = ExtractMonth(_SQLDataReader["EventStartDate"].ToString());
                              _result.EventStartTime = _SQLDataReader["EventStartTime"].ToString();



                              _result.EventEndDate_Day = ExtractDay(_SQLDataReader["EventEndDate"].ToString());
                              _result.EventEndDate_Month = ExtractMonth(_SQLDataReader["EventEndDate"].ToString());


                              _result.EventEndTime = _SQLDataReader["EventEndTime"].ToString();
                              _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                              _result.EventCategoryCode = _SQLDataReader["EventCategoryCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.EventLocationCoordinate = _SQLDataReader["EventLocationCoordinate"].ToString();
                              _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                              _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                              _result.EventUrlTicket = _SQLDataReader["EventUrlTicket"].ToString();
                              _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                              _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                              _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                              _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                              _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                              _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                              _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                              _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                              _result.RespondStatus = _SQLDataReader["RespondStatus"].ToString();
                              _result.RespondStatus_IwillAttendCount = _SQLDataReader["RespondStatus_IwillAttendCount"].ToString();
                              _result.RespondStatus_InterestedCount = _SQLDataReader["RespondStatus_InterestedCount"].ToString();
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



          public static string  ExtractDay(string Tarikh)
          {
              string result="";

              DateTime dt = Convert.ToDateTime(Tarikh);
              int day = dt.Day;
              result = day.ToString();


              return result;
          }
          public static string ExtractMonth(string Tarikh)
          {
              string result = "";

              DateTime dt = Convert.ToDateTime(Tarikh);
              int month = dt.Month;

              if (month == 1)
              {
                  result = "JAN";
              } if (month == 2)
              {
                  result = "FEB";
              } if (month == 3)
              {
                  result = "MAR";

              } if (month == 4)
              {
                  result = "APR";
              } if (month == 5)
              {
                  result = "MAY";
              } if (month == 6)
              {
                  result = "JUN";

              } if (month == 7)
              {
                  result = "JUL";
              } if (month == 8)
              {
                  result = "AUG";
              } if (month == 9)
              {
                  result = "SEP";
              } if (month == 10)
              {
                  result = "OCT";
              } if (month == 11)
              {
                  result = "NOV";
              } if (month == 12)
              {
                  result = "DEC";

              }
            

              return result;
          }

    }
}