using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class MembershipCardEnterprisesEntitledModel
    {




        public int ID
        {
            get;
            set;
        }



        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string CampaignCode
        {
            get;
            set;
        }


        public string EnterpriseHQAccNo
        {
            get;
            set;
        }


        public string MembershipCardCode
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




        public string EnterpriseRegistrationNo
        {
            get;
            set;
        }

        public string EnterpriseEmail
        {
            get;
            set;
        }


        public string EnterprisePhoneNo
        {
            get;
            set;
        }


        public string EnterpriseType
        {
            get;
            set;
        }

        public string EnterpriseAddress
        {
            get;
            set;
        }
        

        

        public MembershipCardEnterprisesEntitledModel() { }




        public static string MembershipCardEnterprisesEntitled_InsertUpdate(int ID, string CampaignCode, string EnterpriseHQAccNo, string EnterpriseAccNo, 
     string MembershipCardCode, string CreatedBy, string RowStatus)
        {

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
                        _SQLCommand.CommandText = "MembershipCardEnterprisesEntitled_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CampaignCode", CampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);                       
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);

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





        public static List<MembershipCardEnterprisesEntitledModel> MembershipCardEnterprisesEntitled_LoadByMembershipCardCode(string MembershipCardCode, string EnterpriseHQAccNo)
        {
            List<MembershipCardEnterprisesEntitledModel> _Value = new List<MembershipCardEnterprisesEntitledModel>();

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
                        _SQLCommand.CommandText = "MembershipCardEnterprisesEntitled_LoadByMembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardEnterprisesEntitledModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipCardEnterprisesEntitledModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            


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





        public static string MembershipCardEnterprisesEntitled_Delete(int ID, string CreatedBy)
        {

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
                        _SQLCommand.CommandText = "MembershipCardEnterprisesEntitled_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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





    }
}