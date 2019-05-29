using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeProjectWithSQL_Compact.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        [Required]
        [StringLength(50)]
        public String Surname { get; set; }
        [StringLength(200)]
        public String Note { get; set; }
    }
}