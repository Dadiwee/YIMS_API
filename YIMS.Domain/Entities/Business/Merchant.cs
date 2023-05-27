using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YIMS.Domain.Entities.System;

namespace YIMS.Domain.Entities.Business
{
	public class Merchant: BaseEntity
	{
        public long  CountryId { get; set; }

        public long StateId { get; set; }

        [Required, StringLength(100)]
        public string MerchantName { get; set; }

        [Required, StringLength(50)]
        public string DisplayName { get; set; }

        [Required, StringLength(150)]
        public string Address { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}

