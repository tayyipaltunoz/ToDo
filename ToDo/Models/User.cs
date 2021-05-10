using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public String UserName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public String Password { get; set; }
    }
}