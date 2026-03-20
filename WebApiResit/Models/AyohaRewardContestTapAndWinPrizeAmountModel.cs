using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardContestTapAndWinPrizeAmountModel
    {


        public string TapPrizeAmount
        {
            get;
            set;
        }
        public string MembershipGroupCode
        {
            get;
            set;
        }
        public string TapBalance
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }


        public string ContestCode
        {
            get;
            set;
        }
       
        public AyohaRewardContestTapAndWinPrizeAmountModel() { }


        public static List<AyohaRewardContestTapAndWinPrizeAmountModel> AyohaRewardContestTapAndWinPrizeAmount_LoadContestRule(string SubscriberAccNo, string ContestCode)
        {
            List<AyohaRewardContestTapAndWinPrizeAmountModel> _Value = new List<AyohaRewardContestTapAndWinPrizeAmountModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContestTapAndWinPrizeAmount_LoadContestRule";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestTapAndWinPrizeAmountModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestTapAndWinPrizeAmountModel();

                            _result.TapPrizeAmount = _SQLDataReader["TapPrizeAmount"].ToString();
                            _result.MembershipGroupCode = _SQLDataReader["MembershipGroupCode"].ToString();
                            _result.TapBalance = _SQLDataReader["TapBalance"].ToString();




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