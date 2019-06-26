using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIneOnCode.Store.Domain.Entities
{
    [Table("Produto")]
    public class Produto : Entity
    {
        [Key]
        public int Id { get; set; }
        [Column("Nome", Order = 1, TypeName = "Varchar(100)")]
        [Required]
        public string Nome { get; set; }
        [Column(TypeName = "money")]
        public decimal ValorUnitario { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public Categoria Categoria { get; set; }

    }
}
