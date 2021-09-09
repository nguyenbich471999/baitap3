using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace baitap3.Models
{
    [Table("Students")]
    public class Student
    {
       [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}