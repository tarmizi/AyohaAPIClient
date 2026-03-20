using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class StampCardModel
    {
         public int ID
        {
            get;
            set;
        }



         public string StampCardCode
        {
            get;
            set;
        }
         public string StampCampaignCode
        {
            get;
            set;
        }


         public string StampContent
        {
            get;
            set;
        }


         public string StampContentSequence
        {
            get;
            set;
        }
         public string StampContentNote
        {
            get;
            set;
        }

         public string StampCardType
        {
            get;
            set;
        }

         public string EnterpriseAccNo
        {
            get;
            set;
        }


         public string CreatedByAccNo
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
         public string TextOne
         {
             get;
             set;
         }

         public string TextTwo
         {
             get;
             set;
         }
         public string DivContent
         {
             get;
             set;
         }
         public string DivContentTextTwo
         {
             get;
             set;
         }

        public int StampContentDefaultTemplateID
         {
             get;
             set;
         }

        public string ContentCardImg
        {
            get;
            set;
        }
        public string ContentCardImgName
        {
            get;
            set;
        }


        public string ShowHide
        {
            get;
            set;
        }

        public string ImgContentName
        {
            get;
            set;
        }

        public string isRedeemItem
        {
            get;
            set;
        }
        public string StampedStatus
        {
            get;
            set;
        }
        
        public StampCardModel() { }



        public static List<StampCardModel>StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo(string StampCampaignCode, string EnterpriseAccNo)
        {
            List<StampCardModel> _Value = new List<StampCardModel>();

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
                        _SQLCommand.CommandText = "StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
                            _result.TextTwo = _SQLDataReader["TextTwo"].ToString();
                            _result.DivContent = _SQLDataReader["DivContent"].ToString();
                            _result.DivContentTextTwo = _SQLDataReader["DivContentTextTwo"].ToString();
                            _result.StampContentDefaultTemplateID = Convert.ToInt32(_SQLDataReader["StampContentDefaultTemplateID"].ToString());
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.ImgContentName = _SQLDataReader["ImgContentName"].ToString();
                            _result.isRedeemItem = _SQLDataReader["isRedeemItem"].ToString();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
                            
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



        public static List<StampCardModel> StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide(string StampCampaignCode, string EnterpriseAccNo)
        {
            List<StampCardModel> _Value = new List<StampCardModel>();

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
                        _SQLCommand.CommandText = "StampCard_LoadBy_StampCampaignCode_EnterpriseAccNo_ShowHide";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCardModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCardModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCardCode = _SQLDataReader["StampCardCode"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampContent = _SQLDataReader["StampContent"].ToString();
                            _result.StampContentSequence = _SQLDataReader["StampContentSequence"].ToString();
                            _result.StampContentNote = _SQLDataReader["StampContentNote"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.TextOne = _SQLDataReader["TextOne"].ToString();
                            _result.TextTwo = _SQLDataReader["TextTwo"].ToString();
                            _result.DivContent = _SQLDataReader["DivContent"].ToString();
                            _result.DivContentTextTwo = _SQLDataReader["DivContentTextTwo"].ToString();
                            _result.StampContentDefaultTemplateID = Convert.ToInt32(_SQLDataReader["StampContentDefaultTemplateID"].ToString());
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.ImgContentName = _SQLDataReader["ImgContentName"].ToString();
                            _result.isRedeemItem = _SQLDataReader["isRedeemItem"].ToString();
                            _result.StampedStatus = _SQLDataReader["StampedStatus"].ToString();
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


     
        public static bool StampCard_Insert(string StampCardCode, string StampCampaignCode, string StampCardType, string EnterpriseAccNo, string CreatedByAccNo,string CreatedBy)
        {
        
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "StampCard_Insert";
                        _SQLCommand.Parameters.AddWithValue("@StampCardCode", StampCardCode);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@StampCardType", StampCardType);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }









        public static bool StampCard_Update(int ID, string StampCampaignCode, string StampContent, string StampContentNote, string EnterpriseAccNo, string ModifiedBy, string TextOne, string TextTwo, string isRedeemItem)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "StampCard_Update";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@StampContent", StampContent);
                        _SQLCommand.Parameters.AddWithValue("@StampContentNote", StampContentNote);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@TextOne", TextOne);
                        _SQLCommand.Parameters.AddWithValue("@TextTwo", TextTwo);
                        _SQLCommand.Parameters.AddWithValue("@isRedeemItem", isRedeemItem);   
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }





        public static bool StampCard_UpdateShowHide(int ID, string StampCampaignCode,string EnterpriseAccNo, string ModifiedBy, string StampContentNote,  string ShowHide)
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "StampCard_UpdateShowHide";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@StampContentNote", StampContentNote);
                        _SQLCommand.Parameters.AddWithValue("@ShowHide", ShowHide);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }

        public static void StampCardWrite_ContentCardImage(string ImgStr, string EnterpriseAccNo, string ImageName)
        {
            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ContentCardImgPath = ImgStr;
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
               // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ContentCardImgPath = "/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }





            
        }






       
        


        public static bool StampCard_UpdateContentCardImage(int ID, string StampCampaignCode, string StampContent, string StampContentNote, string ContentCardImg,string EnterpriseAccNo, string ModifiedBy, string TextOne, string TextTwo,string ContentCardImgName,string isRedeemItem)
        {
           
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "StampCard_UpdateStampContent";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@StampContent", StampContent);
                        _SQLCommand.Parameters.AddWithValue("@StampContentNote", StampContentNote);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _SQLCommand.Parameters.AddWithValue("@TextOne", TextOne);
                        _SQLCommand.Parameters.AddWithValue("@TextTwo", TextTwo);
                        _SQLCommand.Parameters.AddWithValue("@ContentCardImgName", ContentCardImgName);
                        _SQLCommand.Parameters.AddWithValue("@isRedeemItem", isRedeemItem);
                        
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();
                        if (ContentCardImg != "ExistingImage")
                        {
                            StampCardWrite_ContentCardImage(ContentCardImg, EnterpriseAccNo, ContentCardImgName);
                        }
                       
                       
                    }

                }

            }



            return _value;
        }






    }
}