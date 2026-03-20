using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRedeemPrizeHistoryModel
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

        public int AyohaPoint
        {
            get;
            set;
        }


        public static string strRedeemHistoryCode
        {
            get;
            set;
        }





        public int Submitted
        {
            get;
            set;
        }

        public int Accepted
        {
            get;
            set;
        }

        public int Approved
        {
            get;
            set;
        }

        public int Cancel
        {
            get;
            set;
        }


        public string ItemPrizePriceCost
        {
            get;
            set;
        }

        public AyohaRedeemPrizeHistoryModel() { }


        public static string AyohaRedeemPrizeHistory_InsertUpdate(int ID, string ItemCode, string RedeemHistoryCode, string RedeemHistoryStatus,
            string RedeemHistoryStatusBy, int RedeemPoint, string Remarks, string RowStatus, int AyohaPoint)
        {


           

            if (RedeemHistoryStatus == "Cancel")
            {
                strRedeemHistoryCode = RedeemHistoryCode;
            } 
            if (RedeemHistoryStatus == "Approved")
            {
                strRedeemHistoryCode = RedeemHistoryCode;
            } if (RedeemHistoryStatus == "Accepted")
            {
                strRedeemHistoryCode = RedeemHistoryCode;
            }
            if (RedeemHistoryStatus == "Submitted")
            {
                strRedeemHistoryCode = ItemCode + '-' + GenerateRandomNo(ID);
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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistory_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryCode", strRedeemHistoryCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatus", RedeemHistoryStatus);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@RedeemPoint", RedeemPoint);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@AyohaPoint", AyohaPoint);
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


        public static List<AyohaRedeemPrizeHistoryModel>AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy(string RedeemHistoryStatusBy)
        {
            List<AyohaRedeemPrizeHistoryModel> _Value = new List<AyohaRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeHistoryModel();

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






        public static List<AyohaRedeemPrizeHistoryModel> AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy_Year_Status(string RedeemHistoryStatusBy, string Year, string Status)
        {
            List<AyohaRedeemPrizeHistoryModel> _Value = new List<AyohaRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistory_LoadRedeemHistoryStatusBy_Year_Status";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _SQLCommand.Parameters.AddWithValue("@Status", Status);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeHistoryModel();

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
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            



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




        public static List<AyohaRedeemPrizeHistoryModel> AyohaRedeemPrizeHistory_LoadByRedeemHistoryCode(string RedeemHistoryStatusBy, string RedeemHistoryCode)
        {
            List<AyohaRedeemPrizeHistoryModel> _Value = new List<AyohaRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistory_LoadByRedeemHistoryCode";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryCode", RedeemHistoryCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeHistoryModel();

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



        public static List<AyohaRedeemPrizeHistoryModel> AyohaRedeemPrizeHistory_CountStatusBySubscriberAccNo_Year(string SubscriberAccNo, string Year)
        {
            List<AyohaRedeemPrizeHistoryModel> _Value = new List<AyohaRedeemPrizeHistoryModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistory_CountStatusBySubscriberAccNo_Year";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeHistoryModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeHistoryModel();

                            _result.Submitted = Convert.ToInt32(_SQLDataReader["Submitted"].ToString());
                            _result.Accepted = Convert.ToInt32(_SQLDataReader["Accepted"].ToString());
                            _result.Approved = Convert.ToInt32(_SQLDataReader["Approved"].ToString());
                            _result.Cancel = Convert.ToInt32(_SQLDataReader["Cancel"].ToString());

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







        public static string GenerateRandomNo(int val)
        {

            string GenNo = "";

            if (val == 0)
            {
                Random rnd = new Random();
                int card = rnd.Next(99999);

                GenNo = card.ToString();
            }else
            {
                GenNo = val.ToString();
            }
           




            return GenNo;

        }

    }
}