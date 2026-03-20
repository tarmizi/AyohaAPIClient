using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaUserStampCardModel
    {
        public int ID
        {
            get;
            set;
        }



        public string StampCardCode
        {
            get;
            set;
        }
        public string StampCampaignCode
        {
            get;
            set;
        }


        public string StampContent
        {
            get;
            set;
        }


        public string StampContentSequence
        {
            get;
            set;
        }
        public string StampContentNote
        {
            get;
            set;
        }

        public string StampCardType
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

        public string RowStatus
        {
            get;
            set;
        }
        public string TextOne
        {
            get;
            set;
        }

        public string TextTwo
        {
            get;
            set;
        }
        public string DivContent
        {
            get;
            set;
        }
        public string DivContentTextTwo
        {
            get;
            set;
        }

        public int StampContentDefaultTemplateID
        {
            get;
            set;
        }

        public string ContentCardImg
        {
            get;
            set;
        }
        public string ContentCardImgName
        {
            get;
            set;
        }


        public string ShowHide
        {
            get;
            set;
        }

        public string ImgContentName
        {
            get;
            set;
        }

        public string isRedeemItem
        {
            get;
            set;
        }
        public string StampedStatus
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string StampedBy
        {
            get;
            set;
        }

        public string StampedDate
        {
            get;
            set;
        }

        public string StampedTime
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

        public string CountRow
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }



        public string StampRuleRemarks
        {
            get;
            set;
        }

        public string IsStampRulePopUp
        {
            get;
            set;
        }
        public string StartDate
        {
            get;
            set;
        }

        public string StampCampaignName
        {
            get;
            set;
        }
         

        public string NextRedeemItemStampContent
        {
            get;
            set;
        }

        public string NextRedeemItemStampContentNote
        {
            get;
            set;
        }
        public string CountStampCardRowShow
        {
            get;
            set;
        }

        public string CountStampCardRowYES
        {
            get;
            set;
        }


        public string MembershipCardCode
        {
            get;
            set;
        }
        
        


           public string CountStampYES
        {
            get;
            set;
        }


        public string EnterprisesLogo
        {
            get;
            set;
        }

        public string PlayerID
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
        

        public int CampaignDayLeft
        {
            get;
            set;

        }


        public string AdvertisementTitle
        {
            get;
            set;
        }
        public string EnterpriseTagLine
        {
            get;
            set;
        }






        public string CountStar
        {
            get;
            set;
        }
        public string CountReviewer
        {
            get;
            set;
        }
        public string SearchCol
        {
            get;
            set;
        }
        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }

        public string BusinessMode
        {
            get;
            set;
        }
        public string EnterpriseDescription
        {
            get;
            set;
        }


        public string StampedRedeemStatus
        {
            get;
            set;
        }

        public string StampEligibleCount
        {
            get;
            set;
        }

        public string Batch
        {
            get;
            set;
        }
        public string isMember
        {
            get;
            set;
        }
        
        public int RowNumber { get; set; } // <--- Add this
        public AyohaUserStampCardModel() { }



        public static List<AyohaUserStampCardModel> AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
                            _result.TextTwo = _SQLDataReader["TextTwo"].ToString();
                            _result.DivContent = _SQLDataReader["DivContent"].ToString();
                            _result.DivContentTextTwo = _SQLDataReader["DivContentTextTwo"].ToString();
                            _result.StampContentDefaultTemplateID = Convert.ToInt32(_SQLDataReader["StampContentDefaultTemplateID"].ToString());
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.ImgContentName = _SQLDataReader["ImgContentName"].ToString();
                            _result.isRedeemItem = _SQLDataReader["isRedeemItem"].ToString();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedTime = String.Format("{0:T}", _SQLDataReader["StampedDate"]);
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();

                            
                            //_result.CheckInDateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["DateDT"]);
                            //_result.CheckInTimeOnly = String.Format("{0:T}", _SQLDataReader["DateDT"]);
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



        public static List<AyohaUserStampCardModel> AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide(string StampCampaignCode, string EnterpriseAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
                            _result.TextTwo = _SQLDataReader["TextTwo"].ToString();
                            _result.DivContent = _SQLDataReader["DivContent"].ToString();
                            _result.DivContentTextTwo = _SQLDataReader["DivContentTextTwo"].ToString();
                            _result.StampContentDefaultTemplateID = Convert.ToInt32(_SQLDataReader["StampContentDefaultTemplateID"].ToString());
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.ImgContentName = _SQLDataReader["ImgContentName"].ToString();
                            _result.isRedeemItem = _SQLDataReader["isRedeemItem"].ToString();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedTime = String.Format("{0:T}", _SQLDataReader["StampedDate"]);
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();


                            //_result.CheckInDateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["DateDT"]);
                            //_result.CheckInTimeOnly = String.Format("{0:T}", _SQLDataReader["DateDT"]);
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




        public static List<AyohaUserStampCardModel> AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo_fromQrCode(string StampCampaignCode, string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide_SubscriberAccNo_fromQrCode";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
                            _result.TextTwo = _SQLDataReader["TextTwo"].ToString();
                            _result.DivContent = _SQLDataReader["DivContent"].ToString();
                            _result.DivContentTextTwo = _SQLDataReader["DivContentTextTwo"].ToString();
                            _result.StampContentDefaultTemplateID = Convert.ToInt32(_SQLDataReader["StampContentDefaultTemplateID"].ToString());
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.ImgContentName = _SQLDataReader["ImgContentName"].ToString();
                            _result.isRedeemItem = _SQLDataReader["isRedeemItem"].ToString();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedTime = String.Format("{0:T}", _SQLDataReader["StampedDate"]);
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();





                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.NextRedeemItemStampContent = _SQLDataReader["NextRedeemItemStampContent"].ToString();
                            _result.NextRedeemItemStampContentNote = _SQLDataReader["NextRedeemItemStampContentNote"].ToString();
                            _result.CountStampCardRowShow = _SQLDataReader["CountStampCardRowShow"].ToString();
                            _result.CountStampCardRowYES = _SQLDataReader["CountStampCardRowYES"].ToString();
                          
                         

                            //_result.CheckInDateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["DateDT"]);
                            //_result.CheckInTimeOnly = String.Format("{0:T}", _SQLDataReader["DateDT"]);
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



        public static List<AyohaUserStampCardModel> AyohaUserStampCard_LoadBy_StampCardCode(string TempStampQRCode)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_LoadBy_StampCardCode";
                        _SQLCommand.Parameters.AddWithValue("@TempStampQRCode", TempStampQRCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
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






        public static List<AyohaUserStampCardModel> AyohaUserStampCard_Check_StampedStatus(string TempStampQRCode)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_Check_StampedStatus";
                        _SQLCommand.Parameters.AddWithValue("@TempStampQRCode", TempStampQRCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
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







        public static List<AyohaUserStampCardModel> AyohaUserStampCard_NearestRedeemItem(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_NearestRedeemItem";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();                   
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();                           
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
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








        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_NearestRedeemItem(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_NearestRedeemItem";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                             _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            //_result.CountRow =  IndexNumber(_SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CountRow"].ToString(), _SQLDataReader["IsStampRulePopUp"].ToString());                          
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
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




        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_NearestRedeemItem_StampCard(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_NearestRedeemItem_StampCard";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            //_result.CountRow =  IndexNumber(_SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CountRow"].ToString(), _SQLDataReader["IsStampRulePopUp"].ToString());                          
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            
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









        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_StampCardLoadByStampedRedeemStatusORI(string SubscriberAccNo, string StampedRedeemStatus)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_StampCardLoadByStampedRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedRedeemStatus", StampedRedeemStatus);                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            //_result.CountRow =  IndexNumber(_SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CountRow"].ToString(), _SQLDataReader["IsStampRulePopUp"].ToString());                          
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.StampEligibleCount = _SQLDataReader["StampEligibleCount"].ToString();
                            _result.SearchCol = _SQLDataReader["StampContentNote"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString();
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


        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_StampCardLoadByStampedRedeemStatus(string SubscriberAccNo, string StampedRedeemStatus)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_StampCardLoadByStampedRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedRedeemStatus", StampedRedeemStatus);
                        _DBConnection.Open();

                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;

                        // 1. Initialize counter starting at 1
                        int rowCounter = 1;

                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();

                            // 2. Assign the counter to the property
                            _result.RowNumber = rowCounter;

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.StampEligibleCount = _SQLDataReader["StampEligibleCount"].ToString();
                            _result.SearchCol = _SQLDataReader["StampContentNote"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString();
                           // _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedDate = String.Format("{0:d/M/yyyy h:mm tt}", _SQLDataReader["StampedDate"]);
                            

                            _Value.Add(_result);

                            // 3. Increment the counter for the next loop
                            rowCounter++;
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

        public static List<AyohaUserStampCardModel> DashBoard_StampCardLoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "DashBoard_StampCardLoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();

                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;

                        // 1. Initialize counter starting at 1
                        int rowCounter = 1;

                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();

                            // 2. Assign the counter to the property
                            _result.RowNumber = rowCounter;

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.StampEligibleCount = _SQLDataReader["StampEligibleCount"].ToString();
                            _result.SearchCol = _SQLDataReader["StampContentNote"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString();
                            // _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedDate = String.Format("{0:d/M/yyyy h:mm tt}", _SQLDataReader["StampedDate"]);


                            _Value.Add(_result);

                            // 3. Increment the counter for the next loop
                            rowCounter++;
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

        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_StampCardLoadByStampedRedeemExpired(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_StampCardLoadByStampedRedeemExpired";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        int rowCounter = 1;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.RowNumber = rowCounter;
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            //_result.CountRow =  IndexNumber(_SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CountRow"].ToString(), _SQLDataReader["IsStampRulePopUp"].ToString());                          
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.StampEligibleCount = _SQLDataReader["StampEligibleCount"].ToString();
                            _result.Batch = _SQLDataReader["Batch"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.SearchCol = _SQLDataReader["StampContentNote"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString();
                           // _result.StampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StampedDate"]);
                            _result.StampedDate = String.Format("{0:d/M/yyyy h:mm tt}", _SQLDataReader["StampedDate"]);
                            _Value.Add(_result);
                            rowCounter++;
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





        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_NearestRedeemItem_PointCard(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_NearestRedeemItem_PointCard";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            //_result.CountRow =  IndexNumber(_SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CountRow"].ToString(), _SQLDataReader["IsStampRulePopUp"].ToString());                          
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = Convert.ToInt32(_SQLDataReader["CampaignDayLeft"].ToString());
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
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


        public static List<AyohaUserStampCardModel> AyohaUserDashBoard_NearestRedeemItemList(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserDashBoard_NearestRedeemItemList";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
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






        public static List<AyohaUserStampCardModel> AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp(string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "AyohaUserStampCard_MerchantLoyaltyCampaign_LoadStamp";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                               _result.CountStar = _SQLDataReader["CountStar"].ToString();
                               _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                               _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["StampCampaignName"].ToString() + '|' + _SQLDataReader["StampContentNote"].ToString();
                               _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                               _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                               _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            
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



        public static List<AyohaUserStampCardModel> Dashboard_StampCard_SuccessCheckIn_LoadStampCardPerk(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaUserStampCardModel> _Value = new List<AyohaUserStampCardModel>();

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
                        _SQLCommand.CommandText = "Dashboard_StampCard_SuccessCheckIn_LoadStampCardPerk";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaUserStampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaUserStampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.CountStampYES = _SQLDataReader["CountStampYES"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["StampCampaignName"].ToString() + '|' + _SQLDataReader["StampContentNote"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            _result.StampedRedeemStatus = _SQLDataReader["StampedRedeemStatus"].ToString();
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




        public int ro;
       
        public string checkEnt;
        
        public static string IndexNumber(string EnterpriseAccountNo, string CountRow,string jenis)
        {
            AyohaUserStampCardModel _result;
            //_result.ro = 0;
            //_result.checkEnt = EnterpriseAccountNo;
            //string sengal = EnterpriseAccountNo;

            string val = "0";
            if (jenis == "POINTLOYALTYCARD")
            {
                _result = new AyohaUserStampCardModel();
                if (_result.checkEnt.Length < 0)
                {
                    _result.checkEnt = EnterpriseAccountNo;
                    _result.ro = Convert.ToInt32(CountRow);
                    val = _result.ro.ToString();
                    return val;
                }
                if (_result.checkEnt.Length > 0)
                {
                    if (EnterpriseAccountNo == _result.checkEnt)
                    {

                        _result.ro = _result.ro - 1;

                        _result.checkEnt = EnterpriseAccountNo;
                        val = _result.ro.ToString();
                        return val;
                    }
                    if (EnterpriseAccountNo != _result.checkEnt)
                    {
                        _result.ro = Convert.ToInt32(CountRow);
                        _result.checkEnt = EnterpriseAccountNo;
                        val = _result.ro.ToString();
                        return val;
                    }


                }

            }

         

           



            return val;


        }



        public static string CheckExpiredCard(string CardDate)
        {
            string val = "";

            DateTime dateTime1 = DateTime.Parse(CardDate);
            DateTime dateTime2 = DateTime.Now;
            int result = DateTime.Compare(dateTime1, dateTime2);
            if (result < 0)
            {
                //it is earlier
                val = "Valid";
            }
            else if (result == 0)
            {
                //it is the same time as
                val = "Expired";
            }
            else
            {
                //it is later
                val = "Expired";
            }






            return val;
        }
    }
}