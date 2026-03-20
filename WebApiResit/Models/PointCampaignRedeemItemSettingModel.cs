using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class PointCampaignRedeemItemSettingModel
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


        public string PointCampaignCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string TotalItemPoint
        {
            get;
            set;
        }
        public string TotalItemPrizePriceCost
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }









        public string EnterpriseName
        {
            get;
            set;
        }


        public string CountRow
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }


        public string StartDate
        {
            get;
            set;
        }
        public string PointCampaignName
        {
            get;
            set;
        }

        public string EnterprisesLogo
        {
            get;
            set;
        }









        public string isRequiredStartEndDate
        {
            get;
            set;
        }


        public string isCampaignExpired
        {
            get;
            set;
        }
        public string CampaignDayLeft
        {
            get;
            set;
        }

        public string AdvertisementTitle
        {
            get;
            set;
        }







        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string RedeemPointStatus
        {
            get;
            set;
        }

        public string SearchCol
        {
            get;
            set;
        }

        
        public PointCampaignRedeemItemSettingModel() { }


        public static string PointCampaignRedeem_InsertUpdate(int ID, string Img64, string AyohaUserGroupCode, string ItemName,
           string ItemCode, string ItemPoint, string ItemImg, string RowStatus, string CreatedBy, string Remarks, string ItemPrizePriceCost, string AyohaUserGroupCategory,
            string PointCampaignCode, string EnterpriseAccNo)
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
                        _SQLCommand.CommandText = "PointCampaignRedeem_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ImgPath", "https://setkita.com/AyohaImgCard/PointCampaignRedeem/" + EnterpriseAccNo + "/" + ItemImg);
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
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);

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
                            PointCampaignRedeemImage(Img64, ItemImg, EnterpriseAccNo);
                        }


                    }

                }

            }



            return _value;
        }







        public static List<PointCampaignRedeemItemSettingModel> PointCampaignRedeem_LoadByPointCampaignCode(string PointCampaignCode, string EnterpriseAccNo)
        {
            List<PointCampaignRedeemItemSettingModel> _Value = new List<PointCampaignRedeemItemSettingModel>();

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
                        _SQLCommand.CommandText = "PointCampaignRedeem_LoadByPointCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignRedeemItemSettingModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new PointCampaignRedeemItemSettingModel();

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
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.TotalItemPoint = _SQLDataReader["TotalItemPoint"].ToString();
                            _result.TotalItemPrizePriceCost = _SQLDataReader["TotalItemPrizePriceCost"].ToString();
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




        public static List<PointCampaignRedeemItemSettingModel> PointCampaignRedeem_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<PointCampaignRedeemItemSettingModel> _Value = new List<PointCampaignRedeemItemSettingModel>();

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
                        _SQLCommand.CommandText = "PointCampaignRedeem_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignRedeemItemSettingModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new PointCampaignRedeemItemSettingModel();

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
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.TotalItemPoint = _SQLDataReader["TotalItemPoint"].ToString();
                            _result.TotalItemPrizePriceCost = _SQLDataReader["TotalItemPrizePriceCost"].ToString();
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





        public static List<PointCampaignRedeemItemSettingModel> PointCampaignRedeem_LoadByPointRedeemStatusORI(string SubscriberAccNo, string RedeemPointStatus)
        {
            List<PointCampaignRedeemItemSettingModel> _Value = new List<PointCampaignRedeemItemSettingModel>();

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
                        _SQLCommand.CommandText = "PointCampaignRedeemLoadByPointRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemPointStatus", RedeemPointStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignRedeemItemSettingModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new PointCampaignRedeemItemSettingModel();

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
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();

                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();


                            //_result.EndDate = _SQLDataReader["EndDate"].ToString();
                            //_result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy h:mm tt}", _SQLDataReader["EndDate"]);
                            _result.StartDate = String.Format("{0:d/M/yyyy}",_SQLDataReader["StartDate"].ToString());
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();


                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();

                            _result.CampaignDayLeft = _SQLDataReader["CampaignDayLeft"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
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


        public static List<PointCampaignRedeemItemSettingModel> PointCampaignRedeem_LoadByPointRedeemStatus(
    string SubscriberAccNo, string RedeemPointStatus)
        {
            List<PointCampaignRedeemItemSettingModel> _Value = new List<PointCampaignRedeemItemSettingModel>();

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
                        _SQLCommand.CommandText = "PointCampaignRedeemLoadByPointRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemPointStatus", RedeemPointStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        PointCampaignRedeemItemSettingModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new PointCampaignRedeemItemSettingModel();

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
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();

                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountRow = _SQLDataReader["CountRow"].ToString();

                            // --- StartDate (always date only) ---
                            var startDateObj = _SQLDataReader["StartDate"];
                            if (startDateObj != DBNull.Value)
                            {
                                var startDate = (DateTime)startDateObj;
                                _result.StartDate = startDate.ToString("d/M/yyyy");
                            }
                            else
                            {
                                _result.StartDate = string.Empty;
                            }

                            // --- EndDate (hide time if 00:00:00) ---
                            var endDateObj = _SQLDataReader["EndDate"];
                            if (endDateObj != DBNull.Value)
                            {
                                var endDate = (DateTime)endDateObj;

                                if (endDate.TimeOfDay == TimeSpan.Zero)
                                {
                                    // Only date
                                    _result.EndDate = endDate.ToString("d/M/yyyy");
                                }
                                else
                                {
                                    // Date + time
                                    _result.EndDate = endDate.ToString("d/M/yyyy h:mm tt");
                                }
                            }
                            else
                            {
                                _result.EndDate = string.Empty;
                            }

                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.CampaignDayLeft = _SQLDataReader["CampaignDayLeft"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.SearchCol = _SQLDataReader["ItemName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString();

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





        public static void PointCampaignRedeemImage(string ImgStr, string ImageName, string EnterpriseAccNo)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\PointCampaignRedeem\\" + EnterpriseAccNo + "\\";//Path
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
                ImgPath = "https://setkita.com/AyohaImgCard/PointCampaignRedeem/" + EnterpriseAccNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }

    }
}