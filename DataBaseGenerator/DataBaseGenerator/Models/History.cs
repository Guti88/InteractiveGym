using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseGenerator.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }

        public int UserID { get; set; }
        virtual public Dimensions dimensions { get; set; }
        virtual public UserPerformance performance { get; set; }
        public int weigth { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Pole nie może być puste")]
        public DateTime date { get; set; }
    }
}