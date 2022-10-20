using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;

        }

        public Guid Id { get; set; }
        public string UsuarioLogin = "Usuario";
        public DateTime DataCriacao { get; set; }
    }
}
