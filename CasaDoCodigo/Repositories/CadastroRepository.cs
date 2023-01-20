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
            throw new NotImplementedException();
        }
    }
}
