using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class UserPerformance
    {
        [Key]
        public int id { get; set; }

        public int UserID { get; set; }

        public int ExerciseID { get; set; }
        
        public float Max { get; set; }
        public int Reps { get; set; }
    }
}