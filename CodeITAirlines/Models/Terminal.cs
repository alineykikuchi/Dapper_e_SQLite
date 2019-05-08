using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeITAirlines.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public int PessoaFisicaId { get; set; }
        public PessoaFisica PessoaFisica { get; set; }

        public bool Embarcado { get; set; }
    }
}
