using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeITAirlines.Models
{
    public class ViagemSmartFortwo
    {
        public int DestinoAviao { get; set; }
        public int DestinoTerminal { get; set; }
        public DateTime DataRealizada { get; set; }

        public int? PilotoId { get { return Piloto != null ? Piloto.Id : (int?)null; } }
        public int? PassageiroId { get { return Passageiro != null ? Passageiro.Id : (int?)null; } }

        public PessoaFisica Piloto { get; set; }
        public PessoaFisica Passageiro { get; set; }
    }
}
