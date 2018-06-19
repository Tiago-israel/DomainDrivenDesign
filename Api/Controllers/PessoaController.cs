using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Interfaces;
using Aplication.Services;
using Aplication.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Pessoa")]
    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var pessoas = _pessoaService.BuscarTodos();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            var pessoa = _pessoaService.BuscarPorId(id);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Salvar([FromBody]PessoaViewModel pessoaViewModel)
        {
            var pessoa = _pessoaService.Salvar(pessoaViewModel);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody]PessoaViewModel pessoaViewModel)
        {
            var pessoa = _pessoaService.Atualizar(id, pessoaViewModel);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(Guid id)
        {
            try
            {
                _pessoaService.Excluir(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
