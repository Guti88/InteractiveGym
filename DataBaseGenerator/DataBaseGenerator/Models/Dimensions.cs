using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class Dimensions
    {
        [Key]
        public int Id { get; set; }

        public int UserID { get; set; }

        public float Arm { get; set; }
        public float Chest { get; set; }
        public float Shoulder { get; set; }
        public float Waist { get; set; }
        public float Hip { get; set; }
        public float Thigh { get; set; }
        public float Calf { get; set; }
    }
}