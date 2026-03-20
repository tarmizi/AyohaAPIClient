using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class MembershipLoyaltyProgramMasterModel
    {
        public int ID
        {
            get;
            set;
        }




        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string IconImg
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }



        public string RowStatus
        {
            get;
            set;
        }
        public int Seq
        {
            get;
            set;
        }

        public int countPerks_Program
        {
            get;
            set;
        }


        

        public MembershipLoyaltyProgramMasterModel() { }




        public static List<MembershipLoyaltyProgramMasterModel> MembershipLoyaltyProgramMaster_LoadMaster(string SubscriberAccNo)
        {
            List<MembershipLoyaltyProgramMasterModel> _Value = new List<MembershipLoyaltyProgramMasterModel>();

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
                        _SQLCommand.CommandText = "MembershipLoyaltyProgramMaster_LoadMaster";
                            _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipLoyaltyProgramMasterModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MembershipLoyaltyProgramMasterModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.IconImg = _SQLDataReader["IconImg"].ToString();
                            _result.Title = _SQLDataReader["Title"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.Seq = Convert.ToInt32(_SQLDataReader["Seq"].ToString());
                            _result.countPerks_Program = Convert.ToInt32(_SQLDataReader["countPerks_Program"].ToString());
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