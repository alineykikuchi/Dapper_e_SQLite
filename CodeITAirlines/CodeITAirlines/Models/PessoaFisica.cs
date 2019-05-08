using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeITAirlines.Models
{
    public class PessoaFisica
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }

        public virtual int? FuncaoId { get; set; }
        public virtual Funcao Funcao { get; set; }

        public virtual int? SituacaoSocialId { get; set; }
        public virtual SituacaoSocial SituacaoSocial { get; set; }

        public virtual int SituacaoEmbarque { get; set; }
    }
}
