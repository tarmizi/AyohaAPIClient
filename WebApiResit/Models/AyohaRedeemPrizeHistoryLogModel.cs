using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRedeemPrizeHistoryLogModel
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

        public string AccountName
        {
            get;
            set;
        }

        public AyohaRedeemPrizeHistoryLogModel() { }



        public static List<AyohaRedeemPrizeHistoryLogModel> AyohaRedeemPrizeHistoryLog_LoadByRedeemHistoryCode(string RedeemHistoryCode,string RedeemHistoryStatusBy)
        {
            List<AyohaRedeemPrizeHistoryLogModel> _Value = new List<AyohaRedeemPrizeHistoryLogModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrizeHistoryLog_LoadByRedeemHistoryCode";
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryCode", RedeemHistoryCode);
                        _SQLCommand.Parameters.AddWithValue("@RedeemHistoryStatusBy", RedeemHistoryStatusBy);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeHistoryLogModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeHistoryLogModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.RedeemHistoryCode = _SQLDataReader["RedeemHistoryCode"].ToString();
                            _result.RedeemHistoryStatus = _SQLDataReader["RedeemHistoryStatus"].ToString();
                            _result.RedeemHistoryStatusBy = _SQLDataReader["RedeemHistoryStatusBy"].ToString();
                            _result.RedeemHistoryStatusDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["RedeemHistoryStatusDate"]) + " " + String.Format("{0:T}", _SQLDataReader["RedeemHistoryStatusDate"]);
                            _result.RedeemPoint = Convert.ToInt32(_SQLDataReader["RedeemPoint"].ToString());
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();


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