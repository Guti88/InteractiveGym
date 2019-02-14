using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class TreningExercise
    {
        [Key]
        public int Id { get; set; }

        public int TreningID { get; set; }

        public int ExerciseID { get; set; }

        public int Series { get; set; }
        public int Reps { get; set; }
        public int Break { get; set; }
    }
}