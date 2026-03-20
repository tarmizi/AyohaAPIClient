using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaRewardMembershipTermAndConditionModel
    {
        public int ID
        {
            get;
            set;
        }



        public string TermAndCondition
        {
            get;
            set;
        }

        public AyohaRewardMembershipTermAndConditionModel() { }



        public static List<AyohaRewardMembershipTermAndConditionModel> AyohaRewardMembershipTermAndCondition_loadAll()
        {
            List<AyohaRewardMembershipTermAndConditionModel> _Value = new List<AyohaRewardMembershipTermAndConditionModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardMembershipTermAndCondition_loadAll";                       
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardMembershipTermAndConditionModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaRewardMembershipTermAndConditionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.TermAndCondition = _SQLDataReader["TermAndCondition"].ToString();                           
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