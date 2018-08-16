namespace Telerik.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moto")]
    public partial class Moto
    {
        [Key]
        public int idM { get; set; }

        [StringLength(50)]
        public string NombreM { get; set; }

        [StringLength(50)]
        public string ModeloM { get; set; }
    }
}
