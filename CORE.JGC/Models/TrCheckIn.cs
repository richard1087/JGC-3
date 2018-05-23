using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class TrCheckIn
    {
        public int Id { get; set; }
        public string CheckInNo { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime ReturnDate { get; set; }
        public string SiteCode { get; set; }
        public string LocationCode { get; set; }
        public string Notes { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}