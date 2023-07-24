using Entidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Interface
{
    public interface IPessoaRepository
    {
        List<Pessoa> Select(string Nome);
    }
}
