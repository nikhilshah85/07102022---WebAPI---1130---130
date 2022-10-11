using System;
using System.Collections.Generic;

namespace productsWebAPI_EF.Models.EF
{
    public partial class Customer
    {
        public int CId { get; set; }
        public string? CName { get; set; }
        public int? CWalletBalance { get; set; }
        public string? CCity { get; set; }
        public bool? CIsActive { get; set; }
    }
}
