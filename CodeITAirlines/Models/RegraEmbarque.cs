using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeITAirlines.Models
{
    public class RegraEmbarque
    {
        public int? PilotoHierarquia { get; set; }
        public int? PilotoGrupoTripulacao { get; set; }

        
        public int? AcompanhanteHierarquia { get; set; }
        public int? AcompanhanteGrupoTripulacao { get; set; }

        public int? AcompanhanteSituacaoSocialId { get; set; }


    }
}
