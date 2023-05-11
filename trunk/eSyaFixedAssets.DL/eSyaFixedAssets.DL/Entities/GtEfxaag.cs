using System;
using System.Collections.Generic;

namespace HCP.FixedAssets.DL.Entities
{
    public partial class GtEfxaag
    {
        public int AssetGroupId { get; set; }
        public int AssetSubGroupId { get; set; }
        public string FaaccountCode { get; set; }
        public string AdaccountCode { get; set; }
        public string DpaccountCode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
