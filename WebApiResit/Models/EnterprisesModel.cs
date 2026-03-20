using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesModel 
    {
         public int ID
        {
            get;
            set;
        }

         public string EnterpriseHQAccNo
         {
             get;
             set;
         }
        
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string EnterpriseName
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }

        public string EnterprisePhoneNo
        {
            get;
            set;
        }
        public string EnterpriseRegistrationNo
        {
            get;
            set;
        }
        public string EnterpriseEmail
        {
            get;
            set;
        }
        public string EnterpriseWebsite
        {
            get;
            set;
        }
        public string EnterpriseDescriptions
        {
            get;
            set;
        }
        public string EnterpriseFacebook
        {
            get;
            set;
        }
        public string EnterpriseTwiter
        {
            get;
            set;
        }
        public string EnterpriseInstagram
        {
            get;
            set;
        }

        public string EnterpriseCoordinate
        {
            get;
            set;
        }
        public string EnterpriseLogoPath
        {
            get;
            set;
        }

        public string EnterpriseLogoName
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
        public string ModifiedDate
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
       
        public string PICContactNo
        {
            get;
            set;
        }
        public string PersonInCharge
        {
            get;
            set;
        }
        public string LoyaltyCardType
        {
            get;
            set;
        }


        public string EnterpriseType
        {
            get;
            set;
        }
        public string EnterpriseBusinessType
        {
            get;
            set;
        }
        public string AyohaVersion
        {
            get;
            set;
        }

        public string EnterpriseLogoImg64
        {
            get;
            set;
        }




        public string CountMembership
        {
            get;
            set;
        }

        public string CountStar
        {
            get;
            set;
        }


        public string SearchCol
        {
            get;
            set;
        }

        public string Negeri
        {
            get;
            set;
        }


        public string BusinessMode
        {
            get;
            set;
        }
        
        

          public string BusinessTypeCode
        {
            get;
            set;
        }


          public string BusinessTypeGroupCode
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


          public string MerchantLinkType
          {
              get;
              set;
          }


          public string TotalReviews
          {
              get;
              set;
          }

          public double RateReviews
          {
              get;
              set;
          }

         
         public string eStoreIconPath
          {
              get;
              set;
          }

         public string eStoreName
          {
              get;
              set;
          }

         public string EnterpriseTagLine
          {
              get;
              set;
          }
         
         public string OnlineStoreUrl
         {
             get;
             set;
         }


         public string AdvertisementCode
         {
             get;
             set;
         }

         public string CampaignTag
         {
             get;
             set;
         }

         public string isMember
         {
             get;
             set;
         }


         public string Bandar
         {
             get;
             set;
         }





         public string NamaJalan
         {
             get;
             set;
         }


         public string Postkod
         {
             get;
             set;
         }




         public string CheckInDateTime
         {
             get;
             set;
         }


          public string RelativeCheckInTime
         {
             get;
             set;
         }

          public string SubscriberAccNo
          {
              get;
              set;
          }

          public int AyohaRewardPointCheckIn
          {
              get;
              set;
          }
          public string CheckInCount
          {
              get;
              set;
          }
          public string CheckInCountStr
          {
              get;
              set;
          }
        

          public string CheckInCode
          {
              get;
              set;
          }

          public string JenisPerniagaan
          {
              get;
              set;
          }

          public string CheckIn_MembershipCardCode
          {
              get;
              set;
          }


          public string CheckIn_MembershipCardCode_ApprovalStatus
          {
              get;
              set;
          }

        
        
        public EnterprisesModel() { }



        public static string Enterprises_InsertUpdate(int ID,string EnterpriseHQAccNo, string EnterpriseAccNo, string EnterpriseName, string EnterpriseAddress, string EnterprisePhoneNo
      , string EnterpriseRegistrationNo, string EnterpriseEmail, string EnterpriseWebsite, string EnterpriseDescriptions, string EnterpriseFacebook, string EnterpriseTwiter
      , string EnterpriseInstagram, string EnterpriseCoordinate, string EnterpriseLogoPath, string EnterpriseLogoName,string RowStatus, string CreatedBy
     , string PICContactNo, string PersonInCharge, string LoyaltyCardType, string EnterpriseType, string EnterpriseBusinessType, string AyohaVersion, string EnterpriseLogoImg64, string BusinessTypeGroupCode, string MerchantLinkType, string BusinessMode)
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
                        _SQLCommand.CommandText = "Enterprises_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseName", EnterpriseName);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAddress", EnterpriseAddress);
                        _SQLCommand.Parameters.AddWithValue("@EnterprisePhoneNo", EnterprisePhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseRegistrationNo", EnterpriseRegistrationNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseEmail", EnterpriseEmail);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseWebsite", EnterpriseWebsite);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseDescriptions", EnterpriseDescriptions);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseFacebook", EnterpriseFacebook);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseTwiter", EnterpriseTwiter);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseInstagram", EnterpriseInstagram);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseCoordinate", EnterpriseCoordinate);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseLogoPath", "https://setkita.com/AyohaImgCard/Logo/" + EnterpriseAccNo + "/" + EnterpriseLogoName);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseLogoName", EnterpriseLogoName);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@PICContactNo", PICContactNo);
                        _SQLCommand.Parameters.AddWithValue("@PersonInCharge", PersonInCharge);
                        _SQLCommand.Parameters.AddWithValue("@LoyaltyCardType", LoyaltyCardType);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseType", EnterpriseType);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseBusinessType", EnterpriseBusinessType);
                        _SQLCommand.Parameters.AddWithValue("@AyohaVersion", AyohaVersion);
                        _SQLCommand.Parameters.AddWithValue("@BusinessTypeGroupCode", BusinessTypeGroupCode);
                        _SQLCommand.Parameters.AddWithValue("@MerchantLinkType", MerchantLinkType);
                        _SQLCommand.Parameters.AddWithValue("@BusinessMode", BusinessMode);
                        
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
                        if (EnterpriseLogoImg64 != "ExistingImage")
                        {
                            Enterprises_EnterpriseLogoImage(EnterpriseLogoImg64, EnterpriseAccNo, EnterpriseLogoName);
                        }


                    }

                }

            }



            return _value;
        }








        public static string Enterprises_UpdateCountStar(string EnterpriseAccNo, string CountStar)
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
                        _SQLCommand.CommandText = "Enterprises_UpdateCountStar";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CountStar", CountStar);

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





        public static List<EnterprisesModel> Enterprises_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();                            
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
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









        public static List<EnterprisesModel>Enterprises_LoadByRowStatus(string RowStatus)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByRowStatus";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());
                            
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


        public static List<EnterprisesModel> Enterprises_LoadAyohaMerchantList(string RowStatus,string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadAyohaMerchantList";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            
                           // _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                         //   _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());

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


        public static List<EnterprisesModel> Enterprises_LoadLastCheckIn(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadLastCheckIn";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.CheckIn_MembershipCardCode = _SQLDataReader["CheckIn_MembershipCardCode"].ToString();
                            _result.CheckIn_MembershipCardCode_ApprovalStatus = _SQLDataReader["CheckIn_MembershipCardCode_ApprovalStatus"].ToString();

                            
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.CheckInDateTime = _SQLDataReader["CheckInDateTime"].ToString();
                            _result.RelativeCheckInTime = _SQLDataReader["RelativeCheckInTime"].ToString();
                            _result.AyohaRewardPointCheckIn = Convert.ToInt32(_SQLDataReader["AyohaRewardPointCheckIn"].ToString());
                            _result.CheckInCountStr = _SQLDataReader["CheckInCountStr"].ToString();
                            _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();
                            _result.CheckInCode = _SQLDataReader["CheckInCode"].ToString();
                            _result.JenisPerniagaan = _SQLDataReader["JenisPerniagaan"].ToString();                            
                            // _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            //   _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());

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



        public static List<EnterprisesModel> Enterprises_LoadRecentlyCheckIn(string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadRecentlyCheckIn";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;


                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();

                            // --- FIX STARTS HERE ---
                            // Safely handle Integer conversion for ID
                            int _tempID = 0;
                            int.TryParse(_SQLDataReader["ID"].ToString(), out _tempID);
                            _result.ID = _tempID;

                            // Safely handle Integer conversion for AyohaRewardPointCheckIn
                            int _tempPoints = 0;
                            int.TryParse(_SQLDataReader["AyohaRewardPointCheckIn"].ToString(), out _tempPoints);
                            _result.AyohaRewardPointCheckIn = _tempPoints;
                            // --- FIX ENDS HERE ---

                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.CheckInDateTime = _SQLDataReader["CheckInDateTime"].ToString();
                            _result.RelativeCheckInTime = _SQLDataReader["RelativeCheckInTime"].ToString();
                            _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();

                            _Value.Add(_result);
                        }








                        //while (_SQLDataReader.Read())
                        //{
                        //    _result = new EnterprisesModel();
                        //    _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                        //    _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                        //    _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                        //    _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                        //    _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                        //    _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                        //    _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                        //    _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                        //    _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                        //    _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                        //    _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                        //    _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                        //    _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                        //    _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                        //    _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                        //    _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                        //    _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                        //    _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                        //    _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                        //    _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                        //    _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                        //    _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                        //    _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                        //    _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                        //    _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                        //    _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                        //    _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                        //    _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                        //    _result.CountStar = _SQLDataReader["CountStar"].ToString();
                        //    _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                        //    _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                        //    _result.Postkod = _SQLDataReader["Postkod"].ToString();
                        //    _result.Bandar = _SQLDataReader["Bandar"].ToString();
                        //    _result.Negeri = _SQLDataReader["Negeri"].ToString();
                        //    _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                        //    _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                        //    _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                        //    _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                        //    _result.isMember = _SQLDataReader["isMember"].ToString();
                        //    _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                        //    _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                        //    _result.CheckInDateTime = _SQLDataReader["CheckInDateTime"].ToString();
                        //    _result.RelativeCheckInTime = _SQLDataReader["RelativeCheckInTime"].ToString();
                        //    _result.AyohaRewardPointCheckIn = Convert.ToInt32(_SQLDataReader["AyohaRewardPointCheckIn"].ToString());
                        //    _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();
                           
                        //    _Value.Add(_result);
                        //}
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






        public static List<EnterprisesModel> EnterprisesFavorite_LoadFavorite(string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "EnterprisesFavorite_LoadFavorite";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;


                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();

                            // --- FIX STARTS HERE ---
                            // Safely handle Integer conversion for ID
                            int _tempID = 0;
                            int.TryParse(_SQLDataReader["ID"].ToString(), out _tempID);
                            _result.ID = _tempID;

                            // Safely handle Integer conversion for AyohaRewardPointCheckIn
                            int _tempPoints = 0;
                            int.TryParse(_SQLDataReader["AyohaRewardPointCheckIn"].ToString(), out _tempPoints);
                            _result.AyohaRewardPointCheckIn = _tempPoints;
                            // --- FIX ENDS HERE ---

                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            //_result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                             _result.CheckInDateTime = _SQLDataReader["LastCheckInDateTime"].ToString();
                           // _result.RelativeCheckInTime = _SQLDataReader["RelativeCheckInTime"].ToString();
                            _result.CheckInCount = _SQLDataReader["CheckInCount"].ToString();

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









        public static List<EnterprisesModel> Enterprises_LoadAyohaMerchantList_byEnterpriseBusinessType(string RowStatus, string SubscriberAccNo, string EnterpriseBusinessType)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadAyohaMerchantList_byEnterpriseBusinessType";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseBusinessType", EnterpriseBusinessType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();

                            // _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            //   _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());

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

        public static List<EnterprisesModel> Enterprises_LoadByMerchantCategory(string Category, string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByMerchantCategory";
                        _SQLCommand.Parameters.AddWithValue("@Category", Category);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());
                            //_result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
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

        public static List<EnterprisesModel> Enterprises_LoadByEnterpriseAccNoAndSubscriberAccNo(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByEnterpriseAccNoAndSubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                           // _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                           // _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());
                            //_result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
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




        public static List<EnterprisesModel> Enterprises_LoadByEnterpriseBusinessType(string EnterpriseBusinessType,string SubscriberAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByEnterpriseBusinessType";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseBusinessType", EnterpriseBusinessType);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());
                            //_result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
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





        public static List<EnterprisesModel> Enterprises_DashboardSearchAyohaMerchantEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_DashboardSearchAyohaMerchantEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.TotalReviews = _SQLDataReader["TotalReview"].ToString();
                            _result.RateReviews = (Convert.ToDouble(_SQLDataReader["TotalFiveStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalFourStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalThreeStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalTwoStar"].ToString()) + Convert.ToDouble(_SQLDataReader["TotalOneStar"].ToString())) / Convert.ToDouble(_SQLDataReader["TotalReview"].ToString());
                            //_result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();

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
        public static List<EnterprisesModel>Enterprises_GetEnterprisesHQAccNo(string EnterpriseAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_GetEnterprisesHQAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
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









        public static List<EnterprisesModel> Enterprises_LoadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByEnterpriseHQAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseLogoName = _SQLDataReader["EnterpriseLogoName"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                            _result.AyohaVersion = _SQLDataReader["AyohaVersion"].ToString();
                            _result.CountMembership = _SQLDataReader["CountMembership"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.BusinessTypeCode = _SQLDataReader["BusinessTypeCode"].ToString();
                            _result.BusinessTypeGroupCode = _SQLDataReader["BusinessTypeGroupCode"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
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



        public static List<EnterprisesModel> Enterprises_ContactUsLink(string EnterpriseHQAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_ContactUsLink";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();                           
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                           // _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                            _result.PersonInCharge = _SQLDataReader["PersonInCharge"].ToString();
                            _result.MerchantLinkType = _SQLDataReader["MerchantLinkType"].ToString();
                            _result.eStoreIconPath = _SQLDataReader["eStoreIconPath"].ToString();
                            _result.eStoreName = _SQLDataReader["eStoreName"].ToString();
                            _result.OnlineStoreUrl = _SQLDataReader["OnlineStoreUrl"].ToString();
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






        public static List<EnterprisesModel> Enterprises_LoadByEnterpriseAccNo_ScannedQR(string EnterpriseAccNo)
        {
            List<EnterprisesModel> _Value = new List<EnterprisesModel>();

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
                        _SQLCommand.CommandText = "Enterprises_LoadByEnterpriseAccNo_ScannedQR";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesModel();                           
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.Negeri = _SQLDataReader["Negeri"].ToString();
                            _result.NamaJalan = _SQLDataReader["NamaJalan"].ToString();
                            _result.Bandar = _SQLDataReader["Bandar"].ToString();
                            _result.Postkod = _SQLDataReader["Postkod"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
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












        public static void Enterprises_EnterpriseLogoImage(string ImgStr, string EnterpriseAccNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\Logo\\" + EnterpriseAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ImgPath="";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ImgPath = "https://setkita.com/AyohaImgCard/Logo/" + EnterpriseAccNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            
        }












       

    }
}