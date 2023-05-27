using System;
using System.ComponentModel.DataAnnotations;

namespace YIMS.Domain.Entities.System
{
    public class Country : BaseEntity
    {
        [Required, StringLength(50)]
        public string CountryName { get; set; }

        [Required, Range(3, 4)]
        public string CountryCode { get; set; }

        [Required, StringLength(2)]
        public string RegionCode1 { get; set; }

        [StringLength(3)]
        public string RegionCode2 { get; set; }

        [StringLength(100)]
        public string FlagUrl { get; set; }

        public bool IsActive { get; set; }
    }
}

