namespace model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_CCC.ConfigDetNiv1")]
    public partial class ConfigDetNiv1
    {
        public int Id { get; set; }

        public int IdNiv { get; set; }

        [Required]
        [StringLength(200)]
        public string Valor { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(20)]
        public string tipo { get; set; }
    }
}
