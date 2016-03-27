using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositorioGenerico.Crud.Data.Contexts;
using RepositorioGenerico.Crud.Model.Entidades;

namespace RepositorioGenerico.Crud.Test.Data
{
    [TestClass]
    public class CriandoBancoTest
    {
        [TestMethod]
        public void CriarBanco()
        {
            var context = new AmigosContext();

            var novoRegistro = new AmigosModel()
            {
                Nome = "Carlos Edu Medeiros",
                RG = "20.713.632-4",
                CPF = "116.725.558-50",
                Data_Nascimento = new DateTime(1971, 11, 20),
                Telefone = "(11)96240-1957",
                Email = "cmedeiros@sabesp.com.br"

            };

            context.Amigos.Add(novoRegistro);
            context.SaveChanges();
        }
    }
}
