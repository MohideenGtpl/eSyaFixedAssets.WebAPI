using System;
using System.Collections.Generic;

namespace HCP.FixedAssets.DL.Entities
{
    public partial class GtEfxard
    {
        public GtEfxard()
        {
            GtEfxaal = new HashSet<GtEfxaal>();
        }

        public int BusinessKey { get; set; }
        public int InternalAssetNumber { get; set; }
        public int IaserialNumber { get; set; }
        public decimal UnitAcquisitionValue { get; set; }
        public decimal UnitOriginalCost { get; set; }
        public decimal ProvisionalDepreciationValue { get; set; }
        public string LastProvisionalDeprMonthYear { get; set; }
        public decimal DepreciationValue { get; set; }
        public DateTime? LastTransferDate { get; set; }
        public decimal? LastTransferValue { get; set; }
        public string EquipmentSerialNumber { get; set; }
        public string AssetCondition { get; set; }
        public string AssetStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEfxarh GtEfxarh { get; set; }
        public virtual ICollection<GtEfxaal> GtEfxaal { get; set; }
    }
}
