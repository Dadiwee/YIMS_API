using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
	public class PosProvider: BaseEntity
	{
        [Required, StringLength(100)]
        public string ProviderName { get; set; }

        [Required, StringLength(20)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string ContactPerson { get; set; }

        [StringLength(14)]
        public string ContactNumber { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        public bool IsActive { get; set; }
    }
}

