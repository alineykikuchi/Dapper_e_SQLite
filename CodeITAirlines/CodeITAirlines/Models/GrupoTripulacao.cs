using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeITAirlines.Models
{
    public class GrupoTripulacao
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
    }
}
