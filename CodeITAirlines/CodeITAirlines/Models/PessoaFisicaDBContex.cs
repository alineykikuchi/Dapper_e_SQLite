using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeITAirlines.Models
{
    public class PessoaFisicaDBContex : DbContext
    {
        public PessoaFisicaDBContex(string connString)
        : base(connString)
        {

        }
        public DbSet<PessoaFisica> Pessoas { get; set; }
        


    }
}
