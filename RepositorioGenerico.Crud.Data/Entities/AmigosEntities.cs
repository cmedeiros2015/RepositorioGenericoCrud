using RepositorioGenerico.Crud.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGenerico.Crud.Data.Entities
{
    public class AmigosEntities : EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities() {
            ToTable("tb_Amigos");

            HasKey(c => c.ID);

            Property(c => c.Nome).HasColumnName("Nome")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.RG).HasColumnName("RG")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.CPF).HasColumnName("CPF")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.Data_Nascimento).HasColumnName("Dt_Nascimento")
                .IsRequired();

            Property(c => c.Telefone).HasColumnName("Telefone")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(c => c.Email).HasColumnName("Email")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
