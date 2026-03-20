using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class SubscriberModel
    {


        public string SubcriberAccNo
        {
            get;
            set;
        }

        public string SubscribedDate
        {
            get;
            set;
        }


        public string CR_AccountName
        {
            get;
            set;
        }


        public string CR_Email
        {
            get;
            set;
        }


        public string CR_PhoneNumber
        {
            get;
            set;
        }



        public string LoyaltyCardType
        {
            get;
            set;
        }



        public string countStamps
        {
            get;
            set;
        }


        public string LastStampDate
        {
            get;
            set;
        }




        public string LastStampBy
        {
            get;
            set;
        }





        public string SearchCol
        {
            get;
            set;
        }


        public string RowNumber
        {
            get;
            set;
        }

        public string CR_Photo
        {
            get;
            set;
        }
        





        public SubscriberModel() { }


        public static List<SubscriberModel> Subscriber_LoadByEnterpriseAccountNo(string EnterpriseAccountNo)
        {
            List<SubscriberModel> _Value = new List<SubscriberModel>();

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
                        _SQLCommand.CommandText = "Subscriber_LoadByEnterpriseAccountNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccountNo", EnterpriseAccountNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        SubscriberModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new SubscriberModel();
                            _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                            _result.SubcriberAccNo = _SQLDataReader["SubcriberAccNo"].ToString();
                            _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                            _result.CR_AccountName = _SQLDataReader["CR_AccountName"].ToString();
                            _result.CR_Email = _SQLDataReader["CR_Email"].ToString();
                            _result.CR_PhoneNumber = _SQLDataReader["CR_PhoneNumber"].ToString();
                            _result.LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
                            _result.countStamps = _SQLDataReader["countStamps"].ToString();
                            _result.LastStampDate = _SQLDataReader["LastStampDate"].ToString();
                            _result.LastStampBy = _SQLDataReader["LastStampBy"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.CR_Photo = _SQLDataReader["CR_Photo"].ToString();

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