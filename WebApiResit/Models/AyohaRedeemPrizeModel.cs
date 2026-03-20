using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRedeemPrizeModel
    {
        public int ID
        {
            get;
            set;
        }

        public string Img64
        {
            get;
            set;
        }


        
        public string ImgPath
        {
            get;
            set;
        }
        public string AyohaUserGroupCode
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }
        public string ItemCode
        {
            get;
            set;
        }
        public string ItemPoint
        {
            get;
            set;
        }
        public string ItemImg
        {
            get;
            set;
        }
        public string RowStatus
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
        public string Remarks
        {
            get;
            set;
        }
        public string ItemPrizePriceCost
        {
            get;
            set;
        }
        public string AyohaUserGroupCategory
        {
            get;
            set;
        }


        public AyohaRedeemPrizeModel() { }



        public static string AyohaRedeemPrize_InsertUpdate(int ID, string Img64, string AyohaUserGroupCode, string ItemName,
            string ItemCode, string ItemPoint, string ItemImg, string RowStatus, string CreatedBy, string Remarks, string ItemPrizePriceCost, string AyohaUserGroupCategory)
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
                        _SQLCommand.CommandText = "AyohaRedeemPrize_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ImgPath", "https://setkita.com/AyohaImgCard/AyohaRedeemPrize/" + AyohaUserGroupCode + "/" + ItemImg);
                        _SQLCommand.Parameters.AddWithValue("@AyohaUserGroupCode", AyohaUserGroupCode);
                        _SQLCommand.Parameters.AddWithValue("@ItemName", ItemName);
                        _SQLCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                        _SQLCommand.Parameters.AddWithValue("@ItemPoint", ItemPoint);
                        _SQLCommand.Parameters.AddWithValue("@ItemImg", ItemImg);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@Remarks", Remarks);
                        _SQLCommand.Parameters.AddWithValue("@ItemPrizePriceCost", ItemPrizePriceCost);
                        _SQLCommand.Parameters.AddWithValue("@AyohaUserGroupCategory", AyohaUserGroupCategory);   
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
                        if (Img64 != "ExistingImage")
                        {
                            AyohaRedeemPrizeImage(Img64, ItemImg, AyohaUserGroupCode);
                        }


                    }

                }

            }



            return _value;
        }




        public static List<AyohaRedeemPrizeModel> AyohaRedeemPrize_LoadByAyohaUserGroupCode(string AyohaUserGroupCode)
        {
            List<AyohaRedeemPrizeModel> _Value = new List<AyohaRedeemPrizeModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrize_LoadByAyohaUserGroupCode";
                        _SQLCommand.Parameters.AddWithValue("@AyohaUserGroupCode", AyohaUserGroupCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeModel();

                            _result.ID =Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemImg = _SQLDataReader["ItemImg"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            _result.AyohaUserGroupCategory = _SQLDataReader["AyohaUserGroupCategory"].ToString();
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

        public static List<AyohaRedeemPrizeModel> AyohaRedeemPrize_LoadByRowStatus(string RowStatus)
        {
            List<AyohaRedeemPrizeModel> _Value = new List<AyohaRedeemPrizeModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrize_LoadByRowStatus";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemImg = _SQLDataReader["ItemImg"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            _result.AyohaUserGroupCategory = _SQLDataReader["AyohaUserGroupCategory"].ToString();
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





        public static List<AyohaRedeemPrizeModel> AyohaRedeemPrize_LoadByRowStatusAndGC(string RowStatus, string GroupCode)
        {
            List<AyohaRedeemPrizeModel> _Value = new List<AyohaRedeemPrizeModel>();

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
                        _SQLCommand.CommandText = "AyohaRedeemPrize_LoadByRowStatusAndGC";
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@GC", GroupCode);
                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRedeemPrizeModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRedeemPrizeModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.AyohaUserGroupCode = _SQLDataReader["AyohaUserGroupCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemImg = _SQLDataReader["ItemImg"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            _result.AyohaUserGroupCategory = _SQLDataReader["AyohaUserGroupCategory"].ToString();
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

        public static void AyohaRedeemPrizeImage(string ImgStr, string ImageName, string AyohaUserGroupCode)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AyohaRedeemPrize\\" + AyohaUserGroupCode + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ImgPath = "https://setkita.com/AyohaImgCard/AyohaRedeemPrize/" + AyohaUserGroupCode + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }

    }
}