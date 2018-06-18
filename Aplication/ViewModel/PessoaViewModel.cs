using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.ViewModel
{
    public class PessoaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
