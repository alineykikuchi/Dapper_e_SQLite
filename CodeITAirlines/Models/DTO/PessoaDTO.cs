using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeITAirlines.Models.DTO
{
    public class PessoaDTO
    {
        public int PessoaFisicaId { get; set; }
        public string Nome { get; set; }

        public string Funcao { get; set; }

        public string GrupoTripulacao { get; set; }

        public string SituacaoSocial { get; set; }
        public int SituacaoEmbarque { get; set; }
    }
}
