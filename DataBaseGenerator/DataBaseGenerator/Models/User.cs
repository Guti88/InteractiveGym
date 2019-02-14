using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength =1)]
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Surname { get; set; }

        [Range(0,1)]
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int Role { get; set; }

        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Password { get; set; }

        public int Hight { get; set; }
        public int Weight { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return Name + " " + Surname; }
        }
    }
}