namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interactivegym.archiwum")]
    public partial class archiwum
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idOsoba { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTreningu { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime dataRozpoczecia { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime dataZakonczenia { get; set; }

        public virtual osoba osoba { get; set; }

        public virtual trening trening { get; set; }
    }
}
