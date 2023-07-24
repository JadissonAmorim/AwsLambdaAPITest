using Entidade.Models;
using Infra.Cotext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Interface
{
    public class PessoaRepository : IPessoaRepository
    {
        private Context _context;

        public PessoaRepository(Context context)
        {
            _context = context;
        }
        public List<Pessoa> Select(string nome)
        {
            return _context.Pessoa.Where(t => t.Nome.Contains(nome)).ToList();
        }
    }
}
