namespace GiamSatHeThongThuyTinh_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [Column("Total Input Product")]
        public int? Total_Input_Product { get; set; }

        [Column("Total Output Product")]
        public int? Total_Output_Product { get; set; }

        [Column("Total Defective Product")]
        public int? Total_Defective_Product { get; set; }

        public float? Efficiency { get; set; }
    }
}
