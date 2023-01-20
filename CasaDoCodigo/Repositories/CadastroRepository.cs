using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novocadastro);
    }
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {  
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Cadastro Update(int cadastroId, Cadastro novocadastro)
        {
            var cadastroDb = dbSet.Where(c => c.Id == cadastroId).SingleOrDefault();
            if(cadastroDb == null)
            {
                throw new ArgumentException("cadastro");
            }

            cadastroDb.Update(novocadastro);
            _contexto.SaveChanges();
            return cadastroDb;
        }
    }
}
