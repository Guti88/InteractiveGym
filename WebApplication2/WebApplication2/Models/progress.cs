namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interactivegym.progress")]
    public partial class progress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public progress()
        {
            uzytkownik_progress = new HashSet<uzytkownik_progress>();
        }

        [Key]
        public int idProgress { get; set; }

        [Required]
        [StringLength(15)]
        public string nazwa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uzytkownik_progress> uzytkownik_progress { get; set; }
    }
}
