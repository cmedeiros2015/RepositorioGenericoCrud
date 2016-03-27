using RepositorioGenerico.Crud.Data.Entities;
using RepositorioGenerico.Crud.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGenerico.Crud.Data.Contexts
{
    public class AmigosContext : DbContext
    {
        public AmigosContext()
            : base(ConfigurationManager.ConnectionStrings["AmigosCrud"].ConnectionString)
        { 
            
        }

        public DbSet<AmigosModel> Amigos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AmigosContext>());

            modelBuilder.Configurations.Add(new AmigosEntities());
        }

    }
}
