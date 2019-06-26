using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIneOnCode.Store.Domain.Entities
{
    [Table("Categoria")]
    public class Categoria : Entity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(255)"), Required]
        public string Nome { get; set; }
        [Column(TypeName ="Varchar(255)")]
        public string Descricao { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

    }
}
