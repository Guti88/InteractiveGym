namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interactivegym.cwiczenie")]
    public partial class cwiczenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cwiczenie()
        {
            trening_cwiczenia = new HashSet<trening_cwiczenia>();
        }

        [Key]
        public int idCwiczenia { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string nazwa { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string typ { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string sprzęt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trening_cwiczenia> trening_cwiczenia { get; set; }
    }
}
