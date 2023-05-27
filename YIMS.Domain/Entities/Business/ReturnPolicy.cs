using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YIMS.Domain.Entities.Business
{
    public class ReturnPolicy : BaseEntity
    {
        public long MerchantId { get; set; }

        [Required, StringLength(50)]
        public string PolicyName { get; set; }

        [StringLength(1000)]
        public string TandC { get; set; }

        public bool IsDefault { get; set; }

        public decimal ReturnFee { get; set; }

        public int ValidDays { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }
    }
}

