using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaRewardContestModel
    {

        public int ID
        {
            get;
            set;
        }



        public string ContestCode
        {
            get;
            set;
        }
        public string AdvertisementImgPath
        {
            get;
            set;
        }



        public string AdvertismentImgName
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

        public string ContestStatus
        {
            get;
            set;
        }

        public string SegmentContestCode
        {
            get;
            set;
        }


        public string StartDate_DateOnly
        {
            get;
            set;
        }


        public string EndDate_DateOnly
        {
            get;
            set;
        }

        public string ContestDescription
        {
            get;
            set;
        }
        public string ContestFees
        {
            get;
            set;
        }


        public string FirstPrizeImgPath
        {
            get;
            set;
        }

        public string FirstPrizeImgName
        {
            get;
            set;
        }


        public string SecondPrizeImgPath
        {
            get;
            set;
        }


        public string SecondPrizeImgName
        {
            get;
            set;
        }

        public string ThirdPrizeImgPath
        {
            get;
            set;
        }
        public string ThirdPrizeImgName
        {
            get;
            set;
        }

        public string ConsolationPrizeImg
        {
            get;
            set;
        }
        public string ConsolationPrizeName
        {
            get;
            set;
        }
        public string ContestName
        {
            get;
            set;
        }
        public string WinnerAnnoucementStatus
        {
            get;
            set;
        }
        public string TodayDateSvr
        {
            get;
            set;
        }


        public string ContestStatus_ContestStatus
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

        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string ContestType
        {
            get;
            set;
        }
        public string ContestQuestion
        {
            get;
            set;
        }
        public string isRequiredReceipt
        {
            get;
            set;
        }
        public string RedeemStatus
        {
            get;
            set;
        }

        public string SubscriberAccNo
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
        
        public AyohaRewardContestModel() { }


        public static List<AyohaRewardContestModel> AyohaRewardContest_LoadActive(string RowStatus)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContest_LoadActive";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", _SQLDataReader["TodayDateSvr"]);
                            

                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                        


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

        public static List<AyohaRewardContestModel> AyohaRewardContest_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();
            DateTime now = DateTime.Now;
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
                        _SQLCommand.CommandText = "AyohaRewardContest_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", now);
                            _result.ContestStatus_ContestStatus = _SQLDataReader["ContestStatus_ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ContestType = _SQLDataReader["ContestType"].ToString();
                            _result.ContestQuestion = _SQLDataReader["ContestQuestion"].ToString();
                            _result.isRequiredReceipt = _SQLDataReader["isRequiredReceipt"].ToString();
                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));



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





        public static List<AyohaRewardContestModel> ContestCampaignRedeemLoadByContestRedeemStatus(string SubscriberAccNo, string RedeemStatus)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();
            DateTime now = DateTime.Now;
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
                        _SQLCommand.CommandText = "ContestCampaignRedeemLoadByContestRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemStatus", RedeemStatus);                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", now);
                            _result.ContestStatus_ContestStatus = _SQLDataReader["ContestStatus_ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ContestType = _SQLDataReader["ContestType"].ToString();
                            _result.ContestQuestion = _SQLDataReader["ContestQuestion"].ToString();
                            _result.isRequiredReceipt = _SQLDataReader["isRequiredReceipt"].ToString();
                            _result.SearchCol = _SQLDataReader["ContestName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));



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




        public static List<AyohaRewardContestModel> Dashboard_Contest_SuccessCheckIn_LoadContestPerk(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();
            DateTime now = DateTime.Now;
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
                        _SQLCommand.CommandText = "Dashboard_Contest_SuccessCheckIn_LoadContestPerk";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                    
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", now);
                            _result.ContestStatus_ContestStatus = _SQLDataReader["ContestStatus_ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ContestType = _SQLDataReader["ContestType"].ToString();
                            _result.ContestQuestion = _SQLDataReader["ContestQuestion"].ToString();
                            _result.isRequiredReceipt = _SQLDataReader["isRequiredReceipt"].ToString();
                            _result.SearchCol = _SQLDataReader["ContestName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.isMember = _SQLDataReader["isMember"].ToString();
                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));



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

        public static List<AyohaRewardContestModel> AyohaRewardContest_LoadBySubscriberAccNoAndContestCode(string SubscriberAccNo,string ContestCode)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();
            DateTime now = DateTime.Now;
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
                        _SQLCommand.CommandText = "AyohaRewardContest_LoadBySubscriberAccNoAndContestCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", now);
                            _result.ContestStatus_ContestStatus = _SQLDataReader["ContestStatus_ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ContestType = _SQLDataReader["ContestType"].ToString();
                            _result.ContestQuestion = _SQLDataReader["ContestQuestion"].ToString();
                            _result.isRequiredReceipt = _SQLDataReader["isRequiredReceipt"].ToString();
                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));



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




        public static List<AyohaRewardContestModel> AyohaRewardContest_LoadBySubscriberAccNo_EnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<AyohaRewardContestModel> _Value = new List<AyohaRewardContestModel>();
            DateTime now = DateTime.Now;
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
                        _SQLCommand.CommandText = "AyohaRewardContest_LoadBySubscriberAccNo_EnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.AdvertismentImgName = _SQLDataReader["AdvertismentImgName"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.SegmentContestCode = _SQLDataReader["SegmentContestCode"].ToString();
                            _result.StartDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate_DateOnly = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.FirstPrizeImgPath = _SQLDataReader["FirstPrizeImgPath"].ToString();
                            _result.FirstPrizeImgName = _SQLDataReader["FirstPrizeImgName"].ToString();
                            _result.SecondPrizeImgPath = _SQLDataReader["SecondPrizeImgPath"].ToString();
                            _result.SecondPrizeImgName = _SQLDataReader["SecondPrizeImgName"].ToString();
                            _result.ThirdPrizeImgPath = _SQLDataReader["ThirdPrizeImgPath"].ToString();
                            _result.ThirdPrizeImgName = _SQLDataReader["ThirdPrizeImgName"].ToString();
                            _result.ConsolationPrizeImg = _SQLDataReader["ConsolationPrizeImg"].ToString();
                            _result.ConsolationPrizeName = _SQLDataReader["ConsolationPrizeName"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.WinnerAnnoucementStatus = _SQLDataReader["WinnerAnnoucementStatus"].ToString();
                            _result.TodayDateSvr = String.Format("{0:d/M/yyyy}", now);
                            _result.ContestStatus_ContestStatus = _SQLDataReader["ContestStatus_ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();

                            //_result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            //_result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));



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