using CadastrosAPI.Entities;
using CadastrosAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        public ProdutosController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            if (!ModelState.IsValid) return BadRequest("Dados Inválidos!");

            _repository.Add(produto);

            return Ok("Produto Cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _repository.GetAllProdutos();

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _repository.GetProdutoById(id);

            if (produto == null) return NotFound("Produto Não Encontrado!");

            return Ok(produto);
        }

        [HttpPut]
        public IActionResult Put(Produto produto)
        {
            if (!ModelState.IsValid) return BadRequest("Dados inválidos!");

            var prod = _repository.GetProdutoById(produto.IdProduto);

            if (prod == null) return NotFound("Produto não encontrado!");

            _repository.Update(produto);

            return Ok("Produto atualizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _repository.GetProdutoById(id);

            if (produto == null) return NotFound("Produto não encontrado!");

            _repository.Delete(produto);

            return Ok("Produto deletado com sucesso!");
        }
    }
}
