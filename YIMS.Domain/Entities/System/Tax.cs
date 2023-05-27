using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
	public class Tax: BaseEntity
	{
        [Required, StringLength(50)] 
        public string TaxName { get; set; }

        [Required, StringLength(10)]
        public string ShortName { get; set; }

        public decimal Rate { get; set; }

        public bool IsDefault { get; set; }

        public bool IsActive { get; set; }
    }
}

