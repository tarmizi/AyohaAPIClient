using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class RedeemApprovalStatusModel
    {

         public int ID
        {
            get;
            set;
        }

        public string RedeemStatus
        {
            get;
            set;
        }



        public string RedeemStatusCode
        {
            get;
            set;
        }


          public string RowStatus
        {
            get;
            set;
        }

          public RedeemApprovalStatusModel() { }


          public static List<RedeemApprovalStatusModel> RedeemApprovalStatus_Load()
          {
              List<RedeemApprovalStatusModel> _Value = new List<RedeemApprovalStatusModel>();

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
                          _SQLCommand.CommandText = "RedeemApprovalStatus_Load";
                          _DBConnection.Open();
                          SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                          RedeemApprovalStatusModel _result;
                          while (_SQLDataReader.Read())
                          {

                              _result = new RedeemApprovalStatusModel();

                              _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                              _result.RedeemStatus = _SQLDataReader["RedeemStatus"].ToString();
                              _result.RedeemStatusCode = _SQLDataReader["RedeemStatusCode"].ToString();
                              _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
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