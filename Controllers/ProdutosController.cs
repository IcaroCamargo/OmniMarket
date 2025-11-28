using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OmniMarket.Models;

namespace OmniMarket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {

        private static List<Produtos>  produtos = new List<Produtos>()
        {
            new Produtos() {idProduto = 1, idUsuarioVendedor = 1, txtNome = "Icaro", idCategoria =1, vlProduto = 200, qtdEstoque = 3, txtDescricao = "Produto n", stAtivo = true}
        };

        [HttpPost]
        public IActionResult AddProdutos(Produtos novoProduto)
        {
            produtos.Add(novoProduto);
            return Ok(produtos);
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(produtos[0]);
        }

        [HttpPut]

        public IActionResult AlterarNome(Produtos p)
        {
            Produtos produtoAlterado = produtos.Find(prod => prod.idProduto == p.idProduto);
            try
            {
                 if(p.txtNome != produtoAlterado.txtNome)
                {
                    produtoAlterado.txtNome = p.txtNome;  
                }
                else if(p.idCategoria != produtoAlterado.idCategoria)
                {
                    produtoAlterado.idCategoria = p.idCategoria;
                }
                else if(p.vlProduto != produtoAlterado.vlProduto)
                {
                    produtoAlterado.vlProduto = p.vlProduto;
                }
                else if(p.qtdEstoque != produtoAlterado.qtdEstoque)
                {
                    produtoAlterado.qtdEstoque = p.qtdEstoque;
                }
                else if(p.txtDescricao != produtoAlterado.txtDescricao)
                {
                    produtoAlterado.txtDescricao = p.txtDescricao;
                }
                else
                {
                    return BadRequest ("Nenhuma alteração encontrada");
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest (ex.Message);
                
            }
            return Ok(produtos);
        }

        [HttpPut("/Excluir")]
        public IActionResult Desativar (Produtos p)
        {
            Produtos status = produtos.Find(prod => prod.idProduto == p.idProduto);
            if(p.stAtivo = true)
            {
                p.stAtivo = false;
            }
            else
            {
                return BadRequest("Item não existente");
            }
            return Ok(produtos);
            
        }

    }
}