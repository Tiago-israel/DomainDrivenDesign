using Aplication.Interfaces;
using Aplication.Interfaces.Base;
using Aplication.ViewModel;
using AutoMapper;
using Domain.Models;
using Infra.Interfaces.Base;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository) {
            _pessoaRepository = pessoaRepository;
        }

        public PessoaViewModel Salvar(PessoaViewModel viewModel)
        {
            var pessoa = Mapper.Map<Pessoa>(viewModel);
            if(pessoa != null)
            {
                var pessoaDb =  _pessoaRepository.Salvar(pessoa);
                return Mapper.Map<PessoaViewModel>(pessoaDb);
            }
            return null;
        }

        public PessoaViewModel Atualizar(Guid id, PessoaViewModel viewModel)
        {
            var pessoa = Mapper.Map<Pessoa>(viewModel);
            if (pessoa != null)
            {
                var pessoaDb = _pessoaRepository.Atualizar(pessoa);
                return Mapper.Map<PessoaViewModel>(pessoaDb);
            }
            return null;
        }

        public PessoaViewModel BuscarPorId(Guid id)
        {
            var pessoaDb = _pessoaRepository.BuscarPorId(id);
            return Mapper.Map<PessoaViewModel>(pessoaDb);
        }

        public IEnumerable<PessoaViewModel> BuscarTodos()
        {
            var pessoasDb = _pessoaRepository.BucarTodos();
            return Mapper.Map<IEnumerable<PessoaViewModel>>(pessoasDb);
        }

        public void Excluir(Guid id)
        {
            _pessoaRepository.Delete(id);
        }

    }
}
