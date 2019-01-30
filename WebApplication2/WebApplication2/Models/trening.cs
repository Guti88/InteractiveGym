namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interactivegym.trening")]
    public partial class trening
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trening()
        {
            archiwum = new HashSet<archiwum>();
            trening_cwiczenia = new HashSet<trening_cwiczenia>();
        }

        [Key]
        public int idTreningu { get; set; }

        [Required]
        [StringLength(15)]
        public string nazwa { get; set; }

        [Required]
        [StringLength(50)]
        public string typ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archiwum> archiwum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trening_cwiczenia> trening_cwiczenia { get; set; }
    }
}
