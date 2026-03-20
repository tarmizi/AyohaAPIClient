using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardContest_SelfieAndWinModel
    {
        public int ID
        {
            get;
            set;
        }



        public string ContestCode
        {
            get;
            set;
        }
        public string SelfieImagePath
        {
            get;
            set;
        }



        public string SelfieImageName
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


        public string CreatedBy
        {
            get;
            set;
        }


        public string ModifiedDate
        {
            get;
            set;
        }

        public string ModifiedBy
        {
            get;
            set;
        }

        public string Note
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }


        public string ContestStatus
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }



        public string ReceiptLink
        {
            get;
            set;
        }

        public string ReceiptName
        {
            get;
            set;
        }
        public string isRequiredReceipt
        {
            get;
            set;
        }

        public string ContestType
        {
            get;
            set;
        }
        
        public AyohaRewardContest_SelfieAndWinModel() { }


        public static string AyohaRewardContest_SelfieAndWin_InsertUpdate(int ID, string ContestCode, string SelfieImagePath,
   string SelfieImageName, string SubscriberAccNo, string CreatedBy, string ModifiedBy, string Note, string ContestStatus, string EnterpriseAccNo
            ,string ReceiptLink, string ReceiptName,string isRequiredReceipt,string ContestType)
        {
            string myAnswer;

            
            if (ContestType == "Image")
            {
                myAnswer = "https://setkita.com/AyohaImgCard/AyohaRewardContest_SelfieAndWin/" + EnterpriseAccNo + "/" + SubscriberAccNo + "/" + SelfieImageName;
            }
            else
            {
                myAnswer = SelfieImagePath;
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
                        _SQLCommand.CommandText = "AyohaRewardContest_SelfieAndWin_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _SQLCommand.Parameters.AddWithValue("@SelfieImagePath", myAnswer);
                        _SQLCommand.Parameters.AddWithValue("@SelfieImageName", SelfieImageName);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@Note", Note);
                        _SQLCommand.Parameters.AddWithValue("@ContestStatus", ContestStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ReceiptLink", "https://setkita.com/AyohaImgCard/AyohaRewardContest_Receipts/" + EnterpriseAccNo + "/" + SubscriberAccNo + "/" + ReceiptName);
                        _SQLCommand.Parameters.AddWithValue("@ReceiptName", ReceiptName);
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
                        if (SelfieImagePath != "ExistingImage")
                        {
                            AyohaRewardContest_SelfieAndWin_CreateImg(SelfieImagePath, EnterpriseAccNo, SelfieImageName, SubscriberAccNo);
                        }

                        if(isRequiredReceipt=="Yes"){
                            AyohaRewardContest_SelfieAndWin_CreateReceipt(ReceiptLink, EnterpriseAccNo, ReceiptName, SubscriberAccNo);
                        }

                    }

                }

            }



            return _value;
        }









        public static string AyohaRewardContest_SelfieAndWin_Delete(int ID, string ContestCode, string SubscriberAccNo)
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
                        _SQLCommand.CommandText = "AyohaRewardContest_SelfieAndWin_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
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





        public static List<AyohaRewardContest_SelfieAndWinModel> AyohaRewardContest_SelfieAndWin_LoadBySubscriberAccNo_ContestCode(string SubscriberAccNo, string ContestCode)
        {
            List<AyohaRewardContest_SelfieAndWinModel> _Value = new List<AyohaRewardContest_SelfieAndWinModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContest_SelfieAndWin_LoadBySubscriberAccNo_ContestCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContest_SelfieAndWinModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContest_SelfieAndWinModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.SelfieImagePath = _SQLDataReader["SelfieImagePath"].ToString();
                            _result.SelfieImageName = _SQLDataReader["SelfieImageName"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.Note = _SQLDataReader["Note"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ReceiptLink = _SQLDataReader["ReceiptLink"].ToString();
                            _result.ReceiptName = _SQLDataReader["ReceiptName"].ToString();


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



        public static void AyohaRewardContest_SelfieAndWin_CreateImg(string ImgStr, string AccountNo, string ImageName, string SubscriberAccNo)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AyohaRewardContest_SelfieAndWin\\" + AccountNo + "\\" + SubscriberAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            // string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                //ImgPath = "https://setkita.com/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            
        }




        

        public static void AyohaRewardContest_SelfieAndWin_CreateReceipt(string ImgStr, string AccountNo, string ImageName, string SubscriberAccNo)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AyohaRewardContest_Receipts\\" + AccountNo + "\\" + SubscriberAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            // string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                //ImgPath = "https://setkita.com/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            
        }

    }
}