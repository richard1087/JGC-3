using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class TrDeleteAsset
    {
        public int Id { get; set; }
        public string DeleteNo { get; set; }
        public string Status { get; set; }
        public DateTime DeleteDate { get; set; }
        public string Notes { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}