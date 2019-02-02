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
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int Role { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Password { get; set; }
        public int Hight { get; set; }
        public int Weight { get; set; }
    }
}