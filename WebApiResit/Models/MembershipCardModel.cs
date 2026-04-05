using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using WebApiResit.Helpers;
namespace WebApiResit.Models
{
    public class MembershipCardModel
    {


        public int ID
        {
            get;
            set;
        }


        public string RowNumber
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string MembershipCardFee
        {
            get;
            set;
        }


        public string MembershipCardType
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }




        public string ExpiredDate
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg
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





        public string StartDate
        {
            get;
            set;
        }


        public string MembershipCardName
        {
            get;
            set;
        }

        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }

        public string StrExpiredDate
        {
            get;
            set;
        }

        public string isValidLifeTime
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

      public string MembershipCardBackgroundImgName
        {
            get;
            set;
        }




















       

        public string AyohaUserAccountName
        {
            get;
            set;
        }





        public string AyohaUserAccountNo
        {
            get;
            set;
        }


        public string AyohaUserPhoto
        {
            get;
            set;
        }

        public string EnterprisesName
        {
            get;
            set;
        }

        public string EnterprisesLogo
        {
            get;
            set;
        }

        public string EnterpriseAddress
        {
            get;
            set;
        }
        public string EnterpriseType
        {
            get;
            set;
        }

      public string BusinessTypeIconPath
        {
            get;
            set;
        }

      public string BusinessTypeGroup
        {
            get;
            set;
        }

      public string MembershipNo
        {
            get;
            set;
        }


     public string ValidUntilDateMonthYearOnly
      {
          get;
          set;
      }

     public string isRequiredApproval
      {
          get;
          set;
      }

     public string isMembershipCardSubscribed
      {
          get;
          set;
      }
     public string MembershipApprovalStatus
      {
          get;
          set;
      }

     public string MembersCount
      {
          get;
          set;
      }

     public string MembrshipApprovalDate
     {
         get;
         set;
     }



     public string MembershipCardBackgroundImgName_back
     {
         get;
         set;
     }

     public string MembershipCardBackgroundImg_back
     {
         get;
         set;
     }











     public string MembershipDate
     {
         get;
         set;
     }

     public string MembershipByMethod
     {
         get;
         set;
     }

     public string MembershipApprovalBy
     {
         get;
         set;
     }
     public string ReferalSubscriberAccNo
     {
         get;
         set;
     }

     public string IsRequiredMembershipFee
     {
         get;
         set;
     }

     public string MembershipFeePaymentMethod
     {
         get;
         set;
     }

     public string MembershipPaymentLink
     {
         get;
         set;
     }


     public string MembershipPaymentPaidProof
     {
         get;
         set;
     }

     public string MembershipPaymentCode
     {
         get;
         set;
     }

     public string MembershipPaymentPaidProofName
     {
         get;
         set;
     }
     public string ReceivedAmount
     {
         get;
         set;
     }

     public string Remarks
     {
         get;
         set;
     }

     public string MembershipRejectedDate
     {
         get;
         set;
     }

     public string SubscriberAccNo
     {
         get;
         set;
     }
     public string MembershipCardPoint
     {
         get;
         set;
     }


     public int LoyaltCampaignCount
     {
         get;
         set;
     }
     public string CountReviewer
     {
         get;
         set;
     }

     public string CountStar
     {
         get;
         set;
     }

     public string ValidUntilDate
     {
         get;
         set;
     }
     public int TodayCheckInCount
     {
         get;
         set;
     }

     public string MembershipCardSubscribed_ApprovalStatus
     {
         get;
         set;
     }



        public string MembershipStartDate
        {
            get;
            set;
        }

        public string MembershipStartDate_MonthYearOnly
        {
            get;
            set;
        }
        public string MembershipSince
        {
            get;
            set;
        }
        public string isMember
        {
            get;
            set;
        }









        public string EnterpriseMode
        {
            get;
            set;
        }
        public string Bandar
        {
            get;
            set;
        }
        public string Negeri
        {
            get;
            set;
        }


        public MembershipCardModel() { }

        //test





      public static string MembershipCard_InsertUpdate(int ID, string MembershipCardCode, string EnterpriseAccNo,
          string MembershipCardFee, string MembershipCardType, string ExpiredDate, string MembershipCardBackgroundImg, 
          string CreatedBy, string StartDate,string MembershipCardName,string MembershipCardFeePaymentCycle,string StrExpiredDate,
          string isValidLifeTime, string MembershipCardBackgroundImgName, string isRequiredApproval, string MembershipCardBackgroundImgName_back, string MembershipCardBackgroundImg_back)
      {


          string folderEnterpriseAccNo = EnterpriseAccNo;

          if (MembershipCardBackgroundImgName == "Default.png")
          {
              folderEnterpriseAccNo = "Default";
          }


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
                      _SQLCommand.CommandText = "MembershipCard_InsertUpdate";
                      _SQLCommand.Parameters.AddWithValue("@ID", ID);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardFee", MembershipCardFee);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardType", MembershipCardType);
                      _SQLCommand.Parameters.AddWithValue("@ExpiredDate", ExpiredDate);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardBackgroundImg", "https://setkita.com/AyohaImgCard/MembershipCardBackgroundImg/" + folderEnterpriseAccNo + "/" + MembershipCardBackgroundImgName);
                      _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                      _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardName", MembershipCardName);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardFeePaymentCycle", MembershipCardFeePaymentCycle);
                      _SQLCommand.Parameters.AddWithValue("@StrExpiredDate", StrExpiredDate);
                      _SQLCommand.Parameters.AddWithValue("@isValidLifeTime", isValidLifeTime);
                      _SQLCommand.Parameters.AddWithValue("@isRequiredApproval", isRequiredApproval);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardBackgroundImgName_back", MembershipCardBackgroundImgName_back);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardBackgroundImg_back","https://setkita.com/AyohaImgCard/MembershipCardBackgroundImgBack/" + folderEnterpriseAccNo + "/" + MembershipCardBackgroundImgName_back);
                   
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

                      if (MembershipCardBackgroundImg != "ExistingImage")
                      {
                          MembershipCardBackground_CreateImg(MembershipCardBackgroundImg, EnterpriseAccNo, MembershipCardBackgroundImgName);
                      }
                      if (MembershipCardBackgroundImg_back != "ExistingImage")
                      {
                          MembershipCardBackground_CreateImg_back(MembershipCardBackgroundImg_back, EnterpriseAccNo, MembershipCardBackgroundImgName_back);
                      }
                  }

              }

          }



          return _value;
      }





      //public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                      _SQLCommand.Parameters.AddWithValue("@AyohaUserAccountNo", AyohaUserAccountNo);
                    //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                           _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();                          
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                           _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                           _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                         
                        //  _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );


                            _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                          _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                          
                          
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








      public static List<MembershipCardModel> MembershipCard_LoadBySubscriberAccNo_DashboardMain(string SubscriberAccNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadBySubscriberAccNo_DashboardMain";
                      _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                      //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );
                           // _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                         
                            
                            
                            
                            
                            _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                        
                            
                            
                            
                            
                            
                            _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                          _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                          _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                          _result.CountStar = _SQLDataReader["CountStar"].ToString();
                          

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





      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_DashboardMain(string EnterpriseAccNo,string SubscriberAccNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_DashboardMain";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                      //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                           _result.ValidUntilDate = ModifiedExpiredDate(
      _SQLDataReader["ValidUntilDate"],
      _SQLDataReader["StrExpiredDate"]?.ToString(),
      _SQLDataReader["isValidLifeTime"]?.ToString()
  );
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
      _SQLDataReader["ValidUntilDate"],
      _SQLDataReader["StrExpiredDate"]?.ToString(),
      _SQLDataReader["isValidLifeTime"]?.ToString()
  );
                            //_result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                          _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                          _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                          _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                          _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.MembershipStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["MembershipStartDate"]);
                            _result.MembershipStartDate_MonthYearOnly = String.Format("{0:MM/yyyy}", _SQLDataReader["MembershipStartDate"]);

                          
                            DateTime membershipStartDateValue;
                            if (DateTime.TryParse(_SQLDataReader["MembershipStartDate"].ToString(), out membershipStartDateValue))
                            {
                                _result.MembershipSince = HtmlUtility.AmbilBulanTahun(membershipStartDateValue);
                            }
                            else
                            {
                                _result.MembershipSince = string.Empty;
                            }
                          
















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



        public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_SubscriberAccNo_MembershipCardCode(string EnterpriseAccNo, string SubscriberAccNo,string MembershipCardCode)
        {
            List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                        _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_SubscriberAccNo_MembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MembershipCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                            _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                            _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                            _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDate = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
      _SQLDataReader["ValidUntilDate"],
      _SQLDataReader["StrExpiredDate"]?.ToString(),
      _SQLDataReader["isValidLifeTime"]?.ToString()
  );
                            //_result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                            _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                            _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                            _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                            _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.MembershipStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["MembershipStartDate"]);
                            _result.MembershipStartDate_MonthYearOnly = String.Format("{0:MM/yyyy}", _SQLDataReader["MembershipStartDate"]);


                            DateTime membershipStartDateValue;
                            if (DateTime.TryParse(_SQLDataReader["MembershipStartDate"].ToString(), out membershipStartDateValue))
                            {
                                _result.MembershipSince = HtmlUtility.AmbilBulanTahun(membershipStartDateValue);
                            }
                            else
                            {
                                _result.MembershipSince = string.Empty;
                            }

















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


        public static List<MembershipCardModel> MembershipCard_LoadBySubscriberAccNo_MembershipCardCode_EnterpriseAccNo(string EnterpriseAccNo, string SubscriberAccNo,string MembershipCardCode)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadBySubscriberAccNo_MembershipCardCode_EnterpriseAccNo";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );
                           // _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                          _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                          _result.MembershipCardSubscribed_ApprovalStatus = _SQLDataReader["MembershipCardSubscribed_ApprovalStatus"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                          _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                          _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                          _result.CountStar = _SQLDataReader["CountStar"].ToString();
















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


      public static List<MembershipCardModel> MembershipCard_LoadforCheck_In(string SubscriberAccNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadforCheck_In";
                      _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                      //  _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                        //  _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          var mct = _SQLDataReader["MembershipCardType"];
                          _result.MembershipCardType = (mct == DBNull.Value ? "" : mct.ToString()).Trim().ToUpperInvariant();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );
                            //_result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate_Extended((_SQLDataReader["ValidUntilDate"]).ToString(), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                          _result.isMembershipCardSubscribed = _SQLDataReader["isMembershipCardSubscribed"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                          _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                          _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                          _result.CountStar = _SQLDataReader["CountStar"].ToString();
                          _result.ValidUntilDate = _SQLDataReader["ValidUntilDate"].ToString();
                          _result.MembershipDate = String.Format("{0:MM/yy}", _SQLDataReader["MembershipDate"]);
                          _result.TodayCheckInCount =Convert.ToInt32(_SQLDataReader["TodayCheckInCount"].ToString());

                            _result.EnterpriseMode = _SQLDataReader["EnterpriseMode"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();






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




      public static List<MembershipCardModel> MembershipCard_AyohaUserMembershipCard(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)     
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_AyohaUserMembershipCard";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                      _SQLCommand.Parameters.AddWithValue("@AyohaUserAccountNo", AyohaUserAccountNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
       _SQLDataReader["ValidUntilDate"],
       _SQLDataReader["StrExpiredDate"]?.ToString(),
       _SQLDataReader["isValidLifeTime"]?.ToString()
   );
                           // _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
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


      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode(string EnterpriseAccNo, string EnterpriseHQAccNo, string AyohaUserAccountNo, string MembershipCardCode)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                      _SQLCommand.Parameters.AddWithValue("@AyohaUserAccountNo", AyohaUserAccountNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);  
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                            _result = new MembershipCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                            _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            //  _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                            _result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                            _result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(
          _SQLDataReader["ValidUntilDate"],
          _SQLDataReader["StrExpiredDate"]?.ToString(),
          _SQLDataReader["isValidLifeTime"]?.ToString()
      );
                            //_result.ValidUntilDateMonthYearOnly = ModifiedExpiredDate(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembrshipApprovalDate = String.Format("{0:MM/yyyy}", _SQLDataReader["MembrshipApprovalDate"]);
                            _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                            _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                            _result.MembershipStartDate_MonthYearOnly = String.Format("{0:MM/yyyy}", _SQLDataReader["MembershipStartDate"]);


                            DateTime membershipStartDateValue;
                            if (DateTime.TryParse(_SQLDataReader["MembershipStartDate"].ToString(), out membershipStartDateValue))
                            {
                                _result.MembershipSince = HtmlUtility.AmbilBulanTahun(membershipStartDateValue);
                            }
                            else
                            {
                                _result.MembershipSince = string.Empty;
                            }


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







      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode_MembershipCardSaleDetail(string EnterpriseAccNo, string MembershipCardCode)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_MembershipCardCode_MembershipCardSaleDetail";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterpriseName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterpriseLogoPath"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
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



        //test comment utk git

      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_MerchantVersion_extMembershipCardCode(string EnterpriseAccNo,string MembershipCardCode)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_MerchantVersion_extMembershipCardCode";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          //_result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          //_result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          //_result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembersCount = _SQLDataReader["MembersCount"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.RowNumber = _SQLDataReader["RowNumber"].ToString();

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





      public static List<MembershipCardModel> MembershipCard_LoadByEnterpriseAccNo_MerchantVersion(string EnterpriseAccNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_MerchantVersion";
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);

                      _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();   
                          //_result.AyohaUserAccountName = _SQLDataReader["AyohaUserAccountName"].ToString();
                          //_result.AyohaUserAccountNo = _SQLDataReader["AyohaUserAccountNo"].ToString();
                          //_result.AyohaUserPhoto = _SQLDataReader["AyohaUserPhoto"].ToString();
                          _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                          _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                          _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                          _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                          _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                          _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                          _result.MembersCount = _SQLDataReader["MembersCount"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                          _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                          
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






      public static string MembershipCard_Delete(int ID, string MembershipCardCode, string EnterpriseAccNo,
  string ModifiedBy)
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
                      _SQLCommand.CommandText = "MembershipCard_Delete";
                      _SQLCommand.Parameters.AddWithValue("@ID", ID);
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                      _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                      _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);

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












      public static List<MembershipCardModel> MembershipCard_LoadByMembershipCardCode(string MembershipCardCode, string SubscriberAccNo)
      {
          List<MembershipCardModel> _Value = new List<MembershipCardModel>();

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
                      _SQLCommand.CommandText = "MembershipCard_LoadByMembershipCardCode";
                      _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                      SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                      MembershipCardModel _result;
                      while (_SQLDataReader.Read())
                      {
                          _result = new MembershipCardModel();
                          _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                          _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                          _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                          _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                          _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                          _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                          _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                          _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                          _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                          _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                          _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                          _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                          _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                          _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                          _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                          _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                          _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                          _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                          _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                          _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
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





































      public static void MembershipCardBackground_CreateImg(string ImgStr, string AccountNo, string ImageName)
      {



          //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
          String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\MembershipCardBackgroundImg\\" + AccountNo + "\\";//Path
          //string NameImg = ImgName;
          //Check if directory exist
          if (!System.IO.Directory.Exists(dirPath))
          {
              System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
          }
          // string ImgPath = "";
          if (ImgStr.Contains("data:image"))
          {

              string[] namesArray = ImgStr.Split(',');
              string n = namesArray[1];
              // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
              // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
              String imgNames = ImageName;
              //ImgPath = "http://42.1.63.57/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



              byte[] imgByteArray = Convert.FromBase64String(n);
              File.WriteAllBytes(dirPath + imgNames, imgByteArray);
          }

         
      }

      public static void MembershipCardBackground_CreateImg_back(string ImgStr, string AccountNo, string ImageName)
      {



          //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
          String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\MembershipCardBackgroundImgBack\\" + AccountNo + "\\";//Path
          //string NameImg = ImgName;
          //Check if directory exist
          if (!System.IO.Directory.Exists(dirPath))
          {
              System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
          }
          // string ImgPath = "";
          if (ImgStr.Contains("data:image"))
          {

              string[] namesArray = ImgStr.Split(',');
              string n = namesArray[1];
              // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
              // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
              String imgNames = ImageName;
              //ImgPath = "http://42.1.63.57/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



              byte[] imgByteArray = Convert.FromBase64String(n);
              File.WriteAllBytes(dirPath + imgNames, imgByteArray);
          }


      }







      public static string ModifiedExpiredDateORI(DateTime ValidUntilDate, string StrExpiredDated, string isValidLifeTimes)
      {

          string _value = "";


          if(isValidLifeTimes=="YES")
          {
              _value = StrExpiredDated;
          }
          if (isValidLifeTimes == "NO")
          {
              _value = String.Format("{0:MM/yyyy}", ValidUntilDate);
          }






          return _value;

          

      }

        public static string ModifiedExpiredDate(object validUntilDate, string strExpiredDated, string isValidLifeTimes)
        {
            string rawValue = validUntilDate == null || validUntilDate == DBNull.Value
                ? ""
                : validUntilDate.ToString().Trim();

            if (isValidLifeTimes == "YES")
            {
                return strExpiredDated;
            }

            if (isValidLifeTimes == "NO")
            {
                DateTime parsedDate;

                if (validUntilDate is DateTime dt)
                {
                    return dt.ToString("MM/yyyy");
                }
                else if (DateTime.TryParse(rawValue, out parsedDate))
                {
                    return parsedDate.ToString("MM/yyyy");
                }
                else
                {
                    return rawValue;
                }
            }

            return rawValue;
        }

        public static string ModifiedExpiredDate_Extended(string ValidUntilDate, string StrExpiredDated, string isValidLifeTimes)
      {

          string _value = "";


          if (isValidLifeTimes == "YES")
          {
              _value = StrExpiredDated;
          }
          if (isValidLifeTimes == "NO")
          {


              DateTime dateValue;

              // 2. Check menggunakan TryParse
              // Logic: Cuba convert ValidUntilDate masukkan ke dalam dateValue
              bool isDate = DateTime.TryParse(ValidUntilDate, out dateValue);

              if (isDate)
              {
                  // -----------------------------------------------------------
                  // SITUASI A: Ia adalah TARIKH YANG SAH (cth: "2025-12-31")
                  // -----------------------------------------------------------

                  // Anda boleh format semula tarikh tu jadi cantik, contoh: "31 Dec 2025"
                  _value = String.Format("{0:MM/yy}", dateValue);
                //  return dateValue.ToString("dd MMM yyyy");
              }
              else
              {
                  _value = StrExpiredDated;
                 
              }



              
          }






          return _value;



      }











    }
















      
}