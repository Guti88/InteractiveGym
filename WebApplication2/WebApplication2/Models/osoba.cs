namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("interactivegym.osoba")]
    public partial class osoba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public osoba()
        {
            archiwum = new HashSet<archiwum>();
            uzytkownik_progress = new HashSet<uzytkownik_progress>();
        }

        [Key]
        public int idOsoba { get; set; }

        public long PESEL { get; set; }

        [Required]
        [StringLength(25)]
        public string imie { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string nazwisko { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string mail { get; set; }

        [Required]
        [StringLength(9)]
        public string telefon { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_rejestracji { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DKU { get; set; }

        [Column(TypeName = "usmallint")]
        public int? waga { get; set; }

        [Column(TypeName = "usmallint")]
        public int? wzrost { get; set; }

        public int rola_id { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string haslo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archiwum> archiwum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uzytkownik_progress> uzytkownik_progress { get; set; }

        public virtual rola rola { get; set; }
    }
}
