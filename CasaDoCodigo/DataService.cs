using CasaDoCodigo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {

        private readonly ApplicationContext _contexto;

        public DataService(ApplicationContext contexto)
        {
            _contexto = contexto;
        }

        public void InicializaDB()
        {
            _contexto.Database.EnsureCreated();
            var json = File.ReadAllText("livros.json");

            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);

            foreach(var livro in livros)
            {
                _contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }
            _contexto.SaveChanges();
        }      
    }

    class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
