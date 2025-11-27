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
            if(p.txtNome != produtoAlterado.txtNome)
                {
                    if(p.vlProduto != produtoAlterado.vlProduto)
                    {

                        produtoAlterado.vlProduto = p.vlProduto;
                    }
                    produtoAlterado.txtNome = p.txtNome;
                    
                }
                else
                {
                    return BadRequest ("Nome e igual");
                }


            return Ok(produtos);
        }
    }
}