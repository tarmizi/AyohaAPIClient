using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class LoyaltyPointRedeemPrizeHistoryModel
    {
        public int ID
        {
            get;
            set;
        }

        public string ItemCode
        {
            get;
            set;
        }



        public string RedeemHistoryCode
        {
            get;
            set;
        }
        public string RedeemHistoryStatus
        {
            get;
            set;
        }



        public string RedeemHistoryStatusBy
        {
            get;
            set;
        }
        public string RedeemHistoryStatusDate
        {
            get;
            set;
        }



        public int RedeemPoint
        {
            get;
            set;
        }
        public string Remarks
        {
            get;
            set;
        }



        public string RowStatus
        {
            get;
            set;
        }





        public string ImgPath
        {
            get;
            set;
        }



        public string ItemName
        {
            get;
            set;
        }


        public string RowNumber
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string PointCampaignCode
        {
            get;
            set;
        }

        public string RedeemHistoryApprovalStatusBy
        {
            get;
            set;
        }



        
        public LoyaltyPointRedeemPrizeHistoryModel() { }



        public static string LoyaltyPoint_RedeemPrizeHistory_InsertUpdate(int ID, string ItemCode, string RedeemHistoryCode, string RedeemHistoryStatus,
           string RedeemHistoryStatusBy, int RedeemPoint, string Remarks, string RowStatus, string EnterpriseAccNo, string PointCampaignCode, string RedeemHistoryApprovalStatusBy)
        {
           


            string genRedeemHistoryCode;

            if (ID == 0)
            {
                genRedeemHistoryCode = GenerateRedeemHistoryCode(ID, ItemCode);
            }else
            {
                genRedeemHistoryCode = RedeemHistoryCode;
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
                        _SQLCommand.CommandText = "LoyaltyPoint_RedeemPrizeHistory_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryCode", genRedeemHistoryCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatus", RedeemHistoryStatus);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@RedeemPoint", RedeemPoint);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryApprovalStatusBy", RedeemHistoryApprovalStatusBy);                        
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





        public static List<LoyaltyPointRedeemPrizeHistoryModel> LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory(string RedeemHistoryStatusBy, string EnterpriseAccNo)
        {
            List<LoyaltyPointRedeemPrizeHistoryModel> _Value = new List<LoyaltyPointRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);

                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new LoyaltyPointRedeemPrizeHistoryModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.RedeemHistoryCode = _SQLDataReader["RedeemHistoryCode"].ToString();
                            _result.RedeemHistoryStatus = _SQLDataReader["RedeemHistoryStatus"].ToString();
                            _result.RedeemHistoryStatusBy = _SQLDataReader["RedeemHistoryStatusBy"].ToString();
                          //  _result.RedeemHistoryStatusDate = _SQLDataReader["RedeemHistoryStatusDate"].ToString();
                            _result.RedeemHistoryStatusDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["RedeemHistoryStatusDate"]) + " " + String.Format("{0:T}", _SQLDataReader["RedeemHistoryStatusDate"]);
                           // _result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.RedeemPoint = Convert.ToInt32(_SQLDataReader["RedeemPoint"].ToString());
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.RedeemHistoryApprovalStatusBy = _SQLDataReader["RedeemHistoryApprovalStatusBy"].ToString();
                            



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




        public static List<LoyaltyPointRedeemPrizeHistoryModel> LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory_Merchant(string RedeemHistoryStatusBy, string EnterpriseAccNo)
        {
            List<LoyaltyPointRedeemPrizeHistoryModel> _Value = new List<LoyaltyPointRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_RedeemPrizeHistory_LoadRedeemHistory_Merchant";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new LoyaltyPointRedeemPrizeHistoryModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.RedeemHistoryCode = _SQLDataReader["RedeemHistoryCode"].ToString();
                            _result.RedeemHistoryStatus = _SQLDataReader["RedeemHistoryStatus"].ToString();
                            _result.RedeemHistoryStatusBy = _SQLDataReader["RedeemHistoryStatusBy"].ToString();
                            _result.RedeemHistoryStatusDate = _SQLDataReader["RedeemHistoryStatusDate"].ToString();
                            _result.RedeemPoint = Convert.ToInt32(_SQLDataReader["RedeemPoint"].ToString());
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.RedeemHistoryApprovalStatusBy = _SQLDataReader["RedeemHistoryApprovalStatusBy"].ToString();


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




        public static string GenerateRedeemHistoryCode(int val, string ItemCode)
        {

            string GenNo = "";

            if (val == 0)
            {
                Random rnd = new Random();
                int card = rnd.Next(99999);

                GenNo =ItemCode +"-"+ card.ToString();
            }
            else
            {
                GenNo = val.ToString();
            }





            return GenNo;

        }

    }
}