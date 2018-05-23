using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class TrSellingAsset
    {
        public int Id { get; set; }
        public string SellingNo { get; set; }
        public string Status { get; set; }
        public DateTime SellingDate { get; set; }
        public string SellingTo { get; set; }
        public decimal SellingAmount { get; set; }
        public string Notes { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}