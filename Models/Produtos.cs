using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmniMarket.Models
{
    public class Produtos
    {
        public int idProduto {get; set;}
        public int idUsuarioVendedor {get; set;}
        public string txtNome {get; set;}
        public int idCategoria { get; set; }
        public decimal vlProduto { get; set; }
        public int qtdEstoque { get; set; }
        public string txtDescricao { get; set; } = string.Empty;
        public DateTime dtRegistro { get; set; } = DateTime.Now;
        public bool stAtivo { get; set; }

    }
}