namespace Telerik.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carro")]
    public partial class Carro
    {
        [Key]
        public int idC { get; set; }

        [StringLength(50)]
        public string NombreC { get; set; }

        [StringLength(50)]
        public string ModeloC { get; set; }


        [StringLength(50)]
        public string NombreM { get; set; }

        [StringLength(50)]
        public string ModeloM { get; set; }
    }
}
