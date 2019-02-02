using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace TheGym.Models
{
    public class UserProgress
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int ProgressID { get; set; }
        public float Circuit { get; set; }
        public float Max { get; set; }
    }
}