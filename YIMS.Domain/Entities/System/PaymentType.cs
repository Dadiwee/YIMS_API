using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
	public class PaymentType: BaseEntity
	{
		[Required, StringLength(30)]
		public string Type { get; set; }

		public bool IsActive { get; set; }
	}
}

