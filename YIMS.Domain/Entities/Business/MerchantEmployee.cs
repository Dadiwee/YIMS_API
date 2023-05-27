using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YIMS.Domain.Entities.Business
{
	public class MerchantEmployee: BaseEntity
	{
        public long MerchantId { get; set; }

        public long? StoreId { get; set; }

        [Required, StringLength(25)]
        public string FirstName { get; set; }

        [Required, StringLength(25)]
        public string LastName { get; set; }

        [Required, StringLength(14)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(10)]
        public string EmployeeCode { get; set; }

        [Required, StringLength(80)]
        public string EmailAddress { get; set; }

        public bool IsActive { get; set; }

        public DateTime? LastTransactionDate { get; set; }

        [StringLength(120)]
        public string ImageUrl { get; set; }

        [Required, StringLength(6)]
        public string Gender { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }

        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}

