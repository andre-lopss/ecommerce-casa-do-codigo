using System;
using System.Collections.Generic;
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
        }

    }
}
