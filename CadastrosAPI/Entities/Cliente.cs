using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrosAPI.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Sexo { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
