using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace YIMS.Domain.Entities.Business
{
	public class MerchantCustomerLink: BaseEntity
	{
        public long MerchantId { get; set; }

        public long CustomerId { get; set; }

        public bool IsActive { get; set; }

        public DateTime? LastTransactionDate { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}

