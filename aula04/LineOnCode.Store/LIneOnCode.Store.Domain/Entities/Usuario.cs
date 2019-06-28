using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOnCode.Store.Domain.Entities
{
    [Table(nameof(Usuario))]
    public class Usuario : Entity
    {
        [Key]
        public int Id { get; set; }
        [Required, Column(TypeName = "Varchar(20)")]
        public string Nome { get; set; }
        [Required, Column(TypeName ="Varchar(20)")]
        public string UserName { get; set; }
        [Required, Column(TypeName = "char(88)")]
        public string Senha { get; set; }

    }
}
