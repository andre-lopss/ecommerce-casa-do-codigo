using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
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
        private readonly IProdutoRepository _produtoRepository;


        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            _contexto = contexto;
            _produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            _contexto.Database.EnsureCreated();

            List<Livro> livros = GetLivros();

            _produtoRepository.SaveProdutos(livros);
        }


        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }

  
}
