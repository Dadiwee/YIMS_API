using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YIMS.Domain.Entities.System;

namespace YIMS.Domain.Entities.Business
{
	public class Store: BaseEntity
	{
        public long MerchantId { get; set; }

        public long CountryId { get; set; }

        public long StateId { get; set; }

        [Required, StringLength(0)]
        public string StoreName { get; set; }

        [Required, StringLength(150)]
        public string Address { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}

