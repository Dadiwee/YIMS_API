using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YIMS.Domain.Entities.System
{
	public class State: BaseEntity
	{
        public long CountryId { get; set; }

        [Required, StringLength(50)]
        public string StateName { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}

