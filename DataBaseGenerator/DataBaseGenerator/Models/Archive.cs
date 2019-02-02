using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class Archive
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int TreningID { get; set; }
        [RegularExpression(@"^(0[1-9]|1[012])[/]([1-9]|0[1-9]|[12][0-9]|3[01])[/](19[0-9][0-9]|20[0-9][0-9])$",
        ErrorMessage = "Characters are not allowed.")]
        public string DateStart { get; set; }
        [RegularExpression(@"^(0[1-9]|1[012])[/]([1-9]|0[1-9]|[12][0-9]|3[01])[/](19[0-9][0-9]|20[0-9][0-9])$",
        ErrorMessage = "Characters are not allowed.")]
        public string DateFinish { get; set; }
    }
}