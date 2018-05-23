using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class Ms_Asset
    {
        public int Id { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string AssetModelCode { get; set; }
        public string AssetCategoryCode { get; set; }
        public string AssetSerialNo { get; set; }
        public string AssetTypeCode { get; set; }
        public string AssetBrandCode { get; set; }
        public string bStatus { get; set; }
        public bool bActive { get; set; }
        public string Photo { get; set; }
        public string QRCode { get; set; }
        public string SiteCode { get; set; }
        public string LocationCode { get; set; }
        public string AssignTo { get; set; }
        public string PurchaseNo { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string SupplierCode { get; set; }
        public string CompanyID { get; set; }
        public string DeptCode { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}