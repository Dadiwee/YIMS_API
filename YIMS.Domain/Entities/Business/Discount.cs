using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YIMS.Domain.Entities.Business
{
	public class Discount: BaseEntity
	{
        public long MerchantId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string DisplayName { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal DicountCap { get; set; }

        [ForeignKey("MerchantId")]
        public virtual  Merchant Merchant { get; set; }
    }
}

