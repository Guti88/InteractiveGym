using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public enum TreningType
    {
        Kardio,
        Ogólnorozwojowy,
        Klatka,
        Plecy,
        Nogi
    }
    public class Trening
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Name { get; set; }    //power Fat burn itp
        public TreningType? Type { get; set; }    //Kardio, plecy+triceps, nogi, klatka piersiwa itp.
    }
}