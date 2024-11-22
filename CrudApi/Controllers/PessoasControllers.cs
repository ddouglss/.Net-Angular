using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Controllers
{
    // Define esta classe como um controlador de API
    [ApiController]
    // Define a rota base para o controlador, usando o nome do controlador na rota ("api/[controller]")
    [Route("api/pessoas")]
    public class PessoasControllers : ControllerBase
    {
        // Dependência do contexto do banco de dados injetado via construtor
        private readonly Contexto _contexto;

        // Construtor que recebe o contexto e o atribui ao campo _contexto
        public PessoasControllers(Contexto contexto)
        {
            _contexto = contexto;
        }

        // Define uma rota GET para pegar todos os registros de pessoas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> PegarTodosAsync()
        {
            // Retorna a lista de todas as pessoas do banco de dados
            return await _contexto.Pessoas.ToListAsync();
        }

        // Define uma rota GET para pegar uma pessoa específica pelo ID
        [HttpGet("{pessoaId}")]
        public async Task<ActionResult<Pessoa>> PegarPessoaPeloIdAsync(int pessoaId)
        {
            // Busca uma pessoa pelo ID
            Pessoa pessoa = await _contexto.Pessoas.FindAsync(pessoaId);

            // Retorna NotFound caso a pessoa não seja encontrada
            if (pessoa == null)
                return NotFound();

            // Retorna a pessoa encontrada
            return pessoa;
        }

        // Define uma rota POST para inserir um novo registro de pessoa
        [HttpPost]
        public async Task<ActionResult<Pessoa>> SalvarPessoaAsync(Pessoa pessoa)
        {
            // Adiciona a nova pessoa ao contexto
            await _contexto.Pessoas.AddAsync(pessoa);
            // Salva as mudanças no banco de dados
            await _contexto.SaveChangesAsync();

            // Retorna um Ok indicando sucesso
            return Ok();
        }

        // Define uma rota PUT para atualizar os dados de uma pessoa
        [HttpPut]
        public async Task<ActionResult> AtualizarPessoaAsync(Pessoa pessoa)
        {
            // Atualiza a pessoa no contexto
            _contexto.Pessoas.Update(pessoa);
            // Salva as mudanças no banco de dados
            await _contexto.SaveChangesAsync();

            // Retorna um Ok indicando sucesso
            return Ok();
        }

        // Define uma rota DELETE para excluir uma pessoa pelo ID
        [HttpDelete("{pessoaId}")]
        public async Task<ActionResult<Pessoa>> ExcluirPessoaAsync(int pessoaId)
        {
            // Busca a pessoa pelo ID
            Pessoa? pessoa = await _contexto.Pessoas.FindAsync(pessoaId);

            // Verifica se a pessoa foi encontrada
            if (pessoa == null)
            {
                return NotFound(); // Retorna 404 se a pessoa não for encontrada
            }

            // Remove a pessoa do contexto
            _contexto.Pessoas.Remove(pessoa);

            // Salva as mudanças no banco de dados
            await _contexto.SaveChangesAsync();

            // Retorna NoContent (204) indicando sucesso
            return NoContent();
        }

    }
}
