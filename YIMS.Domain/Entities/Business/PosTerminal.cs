using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YIMS.Domain.Entities.System;

namespace YIMS.Domain.Entities.Business
{
	public class PosTerminal: BaseEntity
	{
        public long MerchantId { get; set; }

        public long StoreId { get; set; }

        public long IssuerBankId { get; set; }

        public long ProviderId { get; set; }

        [Required, StringLength(20)]
        public string SerialNumber { get; set; }

        [Required, StringLength(15)]
        public string UID { get; set; }

        public DateTime? LastTransactionDate { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }

        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }

        [ForeignKey("IssuerBankId")]
        public virtual Bank IssuerBank { get; set; }

        [ForeignKey("ProviderId")]
        public virtual PosProvider Provider { get; set; }
    }
}

