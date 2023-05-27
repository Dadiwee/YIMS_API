using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
	public class RefundStatus: BaseEntity
	{
        [Required, StringLength(30)]
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}

