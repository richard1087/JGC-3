using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class TrLeaseReturnAsset
    {
        public int Id { get; set; }
        public string LeaseReturnNo { get; set; }
        public string Status { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CustomerCode { get; set; }
        public string Notes { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}