using Domain.Models;
using Infra.DataContext;
using Infra.Interfaces.Base;
using Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositories
{
    public class PessoaRepository :BaseRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(Context dataContext):base(dataContext)
        {
            
        }
    }
}
