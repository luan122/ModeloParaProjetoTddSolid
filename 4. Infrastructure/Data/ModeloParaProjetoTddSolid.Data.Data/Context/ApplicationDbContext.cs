using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloParaProjetoTddSolid.Data.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        ///TODO: Inserir reositorios aqui
        //public DbSet<> abcd {get;set;}
    }
}
