using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool ValidarMaioridade()
        {
            if (DateTime.Now.Year - this.DataNascimento.GetValueOrDefault().Year < 18)
            {
                return false;
            }
            return true;
        }
    }
}
