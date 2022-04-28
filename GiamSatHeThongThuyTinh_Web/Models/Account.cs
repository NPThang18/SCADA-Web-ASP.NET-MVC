namespace GiamSatHeThongThuyTinh_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
