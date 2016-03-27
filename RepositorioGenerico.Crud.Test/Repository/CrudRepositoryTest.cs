using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositorioGenerico.Crud.Repository.Repositories;
using RepositorioGenerico.Crud.Model.Entidades;

namespace RepositorioGenerico.Crud.Test.Repository
{
    [TestClass]
    public class CrudRepositoryTest
    {
        AmigosRepository repository = new AmigosRepository();

        [TestMethod]
        public void Cadastrar()
        {
            var novoRegistro = new AmigosModel()
            {
                Nome = "Jennifer Martins Pontes",
                RG = "21.755.636-5",
                CPF = "301.994.838-09",
                Data_Nascimento = new DateTime(1983, 04, 25),
                Telefone = "(11)99725-0603",
                Email = "jenny@email.com.br"
            };
            repository.Add(novoRegistro);
        }

        [TestMethod]
        public void atualizar()
        {
            var query = repository.Find(2);
            query.Nome = "Jennifer Martins Medeiros";
            repository.Update(query);
        }

        [TestMethod]
        public void deletar() 
        {
            var query = repository.Find(1);
            repository.Delete(query);
        }

        [TestMethod]
        public void listarRegistros()
        {
            var query = repository.GetAll();
        }

        [TestMethod]
        public void listarComFiltro() 
        {
            var query = repository.GetAll(c => c.Nome.Contains("Martins"));
        }
    }
}
