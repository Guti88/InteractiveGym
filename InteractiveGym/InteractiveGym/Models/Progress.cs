using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace TheGym.Models
{
    public class Progress
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public string Name { get; set; }
    }
}