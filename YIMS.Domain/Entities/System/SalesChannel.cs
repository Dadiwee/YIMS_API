using System;
namespace YIMS.Domain.Entities.System
{
	public class SalesChannel: BaseEntity
	{
        public string ChannelName { get; set; }

        public bool IsActive { get; set; }
    }
}

