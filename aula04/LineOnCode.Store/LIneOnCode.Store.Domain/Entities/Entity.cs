using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIneOnCode.Store.Domain.Entities
{
    public abstract class Entity
    {
        public DateTime Cadastro { get; set; } = DateTime.Now;
        public DateTime UltimaAlteracao { get; set; } = DateTime.Now;
    }
}
