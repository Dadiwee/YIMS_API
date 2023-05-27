using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
	public class Bank: BaseEntity
	{
        [Required, StringLength(50)]
        public string BankName { get; set; }

        [Required, StringLength(3)]
        public string BankCode { get; set; }

        [Required, StringLength(120)]
        public string IconUrl { get; set; }

        public bool IsActive { get; set; }
    }
}

