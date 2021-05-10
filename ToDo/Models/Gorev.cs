using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Gorev
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz")]
        public String GorevName { get; set; }

    }
}