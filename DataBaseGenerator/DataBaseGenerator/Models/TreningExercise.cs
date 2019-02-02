using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class TreningExercise
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int TreningId { get; set; }
        [Required(ErrorMessage = "Pole nie może być puste")]
        public int ExerciseId { get; set; }
        public int Series { get; set; }
        public int Reps { get; set; }
        public int Break { get; set; }
    }
}