namespace GiamSatHeThongThuyTinh_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Efficiency")]
    public partial class Efficiency
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [Column("Visual 1 (%)")]
        public float? Visual_1____ { get; set; }

        [Column("Mcal3 (%)")]
        public float? Mcal3____ { get; set; }

        [Column("Multi3 (%)")]
        public float? Multi3____ { get; set; }

        [Column("OLT-S (%)")]
        public float? OLT_S____ { get; set; }

        [Column("M1 (%)")]
        public float? M1____ { get; set; }

        [Column("Visual 2 (%)")]
        public float? Visual_2____ { get; set; }

        public float? Total { get; set; }
    }
}
