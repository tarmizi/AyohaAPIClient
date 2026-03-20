using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardContestTapAndWinSponsorModel
    {
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
        public string EnterpriseLogo
        {
            get;
            set;
        }
        public string IDK
        {
            get;
            set;
        }

        public AyohaRewardContestTapAndWinSponsorModel() { }
        public static List<AyohaRewardContestTapAndWinSponsorModel> AyohaRewardContestTapAndWinSponsor_load(string IDK)
        {
            List<AyohaRewardContestTapAndWinSponsorModel> _Value = new List<AyohaRewardContestTapAndWinSponsorModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContestTapAndWinSponsor_load";
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestTapAndWinSponsorModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestTapAndWinSponsorModel();

                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();




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