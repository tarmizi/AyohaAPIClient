using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class MasterMembershipsModel
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
        public string CreatedDate
        {
            get;
            set;
        }

        public string MembershipApprovalStatus
        {
            get;
            set;
        }
        public string MembershipApprovalBy
        {
            get;
            set;
        }
        public string MembrshipApprovalDate
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
        public string Photo
        {
            get;
            set;
        }





        public string CardCount
        {
            get;
            set;
        }
        public string CountStamp
        {
            get;
            set;
        }

        public string CountPoint
        {
            get;
            set;
        }
        public string LastPointed_ActivityDate
        {
            get;
            set;
        }



        public string LastStamped_ActivityDate
        {
            get;
            set;
        }

        public string Latest_ActivityDate
        {
            get;
            set;
        }


        public string SearchCol
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }


        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string EnterpriseHQAccNo
        {
            get;
            set;
        }




        public string MembershipByMethod
        {
            get;
            set;
        }


        
        public string Remarks
        {
            get;
            set;
        }


        public string ReceivedAmount
        {
            get;
            set;
        }

        public string MembershipPaymentPaidProofName
        {
            get;
            set;
        }
        public string MembershipPaymentPaidProof
        {
            get;
            set;
        }
        public string MembershipFeePaymentMethod
        {
            get;
            set;
        }
        public string MembershipRejectedDate
        {
            get;
            set;
        }

        

        

          public string Request
        {
            get;
            set;
        }
        public string Rejected
        {
            get;
            set;
        }
        public string Expired
        {
            get;
            set;
        }
        public string Approved
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }
        
        public MasterMembershipsModel() { }










        public static string MasterMemberships_UpdateStatusApproval(int ID,string EnterpriseHQAccNo, string SubscriberAccNo,string MembershipCardCode,string MembershipApprovalBy
            , string MembershipApprovalStatus, string Remarks, string ReceivedAmount, string MembershipPaymentPaidProofName, string MembershipPaymentPaidProof, string MembershipFeePaymentMethod)
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
                        _SQLCommand.CommandText = "MasterMemberships_UpdateStatusApproval";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@MembershipApprovalBy", MembershipApprovalBy);
                        _SQLCommand.Parameters.AddWithValue("@MembershipApprovalStatus", MembershipApprovalStatus);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        _SQLCommand.Parameters.AddWithValue("@ReceivedAmount", ReceivedAmount);
                        _SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProofName", MembershipPaymentPaidProofName);
                        _SQLCommand.Parameters.AddWithValue("@MembershipPaymentMethod", MembershipFeePaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProof", "https://setkita.com/AyohaImgCard/PaymentProofDoc/" + EnterpriseHQAccNo + "/" + MembershipCardCode + "/" + MembershipPaymentPaidProofName);
                 

                        
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
                        if (MembershipPaymentPaidProof != "ExistingImage")
                        {
                            MasterMemberships_PaymentProof(MembershipPaymentPaidProof, EnterpriseHQAccNo, MembershipCardCode, MembershipPaymentPaidProofName);
                        }


                    }

                }

            }



            return _value;
        }




        public static List<MasterMembershipsModel> MasterMemberships_DashboardApprovalStatusCount(string EnterpriseHQAccNo)
        {
            List<MasterMembershipsModel> _Value = new List<MasterMembershipsModel>();

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
                        _SQLCommand.CommandText = "MasterMemberships_DashboardApprovalStatusCount";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MasterMembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MasterMembershipsModel();

                            _result.Request = _SQLDataReader["Request"].ToString();
                            _result.Rejected = _SQLDataReader["Rejected"].ToString();
                            _result.Expired = _SQLDataReader["Expired"].ToString();
                            _result.Approved = _SQLDataReader["Approved"].ToString();
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







        public static List<MasterMembershipsModel> MasterMemberships_VerifiedSubscriber(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<MasterMembershipsModel> _Value = new List<MasterMembershipsModel>();

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
                        _SQLCommand.CommandText = "MasterMemberships_VerifiedSubscriber";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MasterMembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MasterMembershipsModel();

                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();                      
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













        public static List<MasterMembershipsModel>MasterMemberships_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<MasterMembershipsModel> _Value = new List<MasterMembershipsModel>();

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
                        _SQLCommand.CommandText = "MasterMemberships_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MasterMembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MasterMembershipsModel();
                            _result.ID =Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();                            
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            //_result.CreatedDate = String.Format("{0:d/M/yyyy HH:mm:ss}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate = setNullDate(_SQLDataReader["CreatedDate"].ToString());
                            //_result.CreatedDate = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipApprovalBy = _SQLDataReader["MembershipApprovalBy"].ToString();
                            //_result.MembrshipApprovalDate = String.Format("{0:d/M/yyyy HH:mm:ss}", _SQLDataReader["MembrshipApprovalDate"]);
                            _result.MembrshipApprovalDate = setNullDate( _SQLDataReader["MembrshipApprovalDate"].ToString());
                            _result.MembershipRejectedDate = setNullDate(_SQLDataReader["MembershipRejectedDate"].ToString());
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["CampaignEnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["CampaignEnterpriseHQAccNo"].ToString(); 
                            _result.CardCount = _SQLDataReader["CardCount"].ToString();
                            _result.CountStamp = _SQLDataReader["CountStamp"].ToString();
                            _result.CountPoint = _SQLDataReader["CountPoint"].ToString();
                            //_result.LastPointed_ActivityDate = String.Format("{0:d/M/yyyy HH:mm:ss}", _SQLDataReader["LastPointed_ActivityDate"]);
                            //_result.LastStamped_ActivityDate = String.Format("{0:d/M/yyyy HH:mm:ss}", _SQLDataReader["LastStamped_ActivityDate"]);

                            _result.LastPointed_ActivityDate =  setNullDate(_SQLDataReader["LastPointed_ActivityDate"].ToString());
                            _result.LastStamped_ActivityDate = setNullDate(_SQLDataReader["LastStamped_ActivityDate"].ToString());
                            _result.Latest_ActivityDate = FindLatestDate(_SQLDataReader["CreatedDate"].ToString(), _SQLDataReader["MembrshipApprovalDate"].ToString(), _SQLDataReader["LastPointed_ActivityDate"].ToString(), _SQLDataReader["LastStamped_ActivityDate"].ToString(), _SQLDataReader["MembershipRejectedDate"].ToString(), _SQLDataReader["LastRedeem_ActivityDate"].ToString());
                            _result.SearchCol = _SQLDataReader["AccountName"].ToString() + "|" + _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            
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

        public static DateTime a;
        public static string setNullDate(string val)
        {
           


            //2020-12-04 03:16:49.307
            // DateTime? means it is nullable
//var DateTime? date = null;

//// .HasValue only exists if DateTime is nullable
//if(date.HasValue)
//    Console.WriteLine("date has a value");
//else
//    Console.WriteLine("date is null");

                if(val.Length>1){
                       a = Convert.ToDateTime(val);
                  //  a= DateTime.ParseExact(val, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                      
                }else
                {
                    a = Convert.ToDateTime("1993-12-04 03:16:49.307");
                }

            //DateTime date = DateTime.ParseExact("2010-01-01 23:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                string b = a.ToString("yyyy-MM-dd HH:mm:ss");
             //  string c= String.Format("{0:yyyy-MM-dd HH:mm:ss}", b);
                return b;



           

        }



        //public static string FindLatest_CreatedDate;
        //public static string FindLatest_ApprovalDate;
        //public static string FindLatest_PointDate;
        //public static string FindLatest_StampedDate;
        public static string Activity;
        public static int i;
        public static string FindLatestDate(string FindLatest_CreatedDate, string FindLatest_ApprovalDate, string FindLatest_PointDate, string FindLatest_StampedDate, string FindLatest_RejectedDate, string FindLatest_RedeemDate)
        {

            i = 0;
            Activity = "";

            //2020-12-04 03:16:49.307
            // DateTime? means it is nullable
            //var DateTime? date = null;

            //// .HasValue only exists if DateTime is nullable
            //if(date.HasValue)
            //    Console.WriteLine("date has a value");
            //else
            //    Console.WriteLine("date is null");

            //if (val.Length > 1)
            //{
            //    //aa = Convert.ToDateTime(val);
            //    FindLatest_CreatedDate = val;
            //    //  a= DateTime.ParseExact(val, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //}
            //else
            //{
            //   // aa = Convert.ToDateTime("1993-12-04 03:16:49.307");
            //    FindLatest_CreatedDate = "1993-12-04 03:16:49.307";
            //}






            //if (val01.Length > 1)
            //{
            //    //bb = Convert.ToDateTime(val01);
            //    //  a= DateTime.ParseExact(val, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //    FindLatest_ApprovalDate = val01;

            //}
            //else
            //{
            //    FindLatest_ApprovalDate = "1993-12-04 03:16:49.307";
            //}




            //if (val02.Length > 1)
            //{
            //    FindLatest_PointDate = val02;
            //    //  a= DateTime.ParseExact(val, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //}
            //else
            //{
            //    FindLatest_PointDate = "1993-12-04 03:16:49.307";
            //}






            //if (val03.Length > 1)
            //{
            //    FindLatest_StampedDate = val03;
            //    //  a= DateTime.ParseExact(val, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //}
            //else
            //{
            //    FindLatest_StampedDate = "1993-12-04 03:16:49.307";
            //}


            List<string> stringDates = new List<string>();
            //stringDates.Add("Not a date");
            //stringDates.Add("2015-01-01");
            //stringDates.Add("2015-10-10");
            //stringDates.Add("2015-9-10");
            //stringDates.Add("123");
            stringDates.Add(FindLatest_CreatedDate);
            stringDates.Add(FindLatest_ApprovalDate);
            stringDates.Add(FindLatest_PointDate);
            stringDates.Add(FindLatest_StampedDate);
            stringDates.Add(FindLatest_RejectedDate);
            stringDates.Add(FindLatest_RedeemDate);
            

            
         

            DateTime sapInvoiceDate;
            DateTime tempDate = DateTime.MinValue;
            sapInvoiceDate = stringDates.Select(x => DateTime.TryParse(x, out tempDate)).Select(x => tempDate).Max();


            i = stringDates.IndexOf(sapInvoiceDate.ToString()); // RETURNS 1.
            //DateTime date = DateTime.ParseExact("2010-01-01 23:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            if (i == 5)
            {
                Activity = "Point Redemption!";
            }
            if (i == 4)
            {
                Activity = "Rejected Request!";
            }

            if (i == 3)
            {
                Activity = "Stamped Collected";
            }
            if (i ==2)
            {
                Activity = "Point Collected";
            } if (i == 1)
            {
                Activity = "Approved M.Ship!";
            }
            if (i == 0)
            {
                Activity = "M.ship Registration";
            }
            string b = sapInvoiceDate.ToString("dd-MM-yyyy HH:mm:ss") + " - " + Activity;
            //  string c= String.Format("{0:yyyy-MM-dd HH:mm:ss}", b);

            //string b = stringDates[2]+" - "+stringDates[3];
            return b;





        }










        
        public static void MasterMemberships_PaymentProof(string ImgStr, string EnterpriseAccNo,string MembershipCardCode, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\PaymentProofDoc\\" + EnterpriseAccNo + "\\" + MembershipCardCode + "\\" ;//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ImgPath="";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ImgPath = "https://setkita.com/AyohaImgCard/PaymentProofDoc/" + EnterpriseAccNo + "/" + MembershipCardCode + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            
        }
    }
}


