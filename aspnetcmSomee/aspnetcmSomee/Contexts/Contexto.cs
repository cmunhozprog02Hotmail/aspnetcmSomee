using aspnetcmSomee.Contextos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace aspnetcmSomee.Contexts
{
    public class Contexto : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Forçar que todo o nome de campo que conter Id é uma chave promária
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Alterar os campos string nvarchar para varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Padronizar tamanho do campo string
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

        }
    }
}