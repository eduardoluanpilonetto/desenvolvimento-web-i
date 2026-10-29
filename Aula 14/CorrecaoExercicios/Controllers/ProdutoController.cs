using CorrecaoExercicios.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorrecaoExercicios.Controllers
{
    public class ProdutoController : Controller
    {
        private static readonly IReadOnlyList<Produto> Produtos = new List<Produto>
        {
            new() { Id = 10, Nome = "Caderno", Preco = 24.90m },
            new() { Id = 11, Nome = "Caneta", Preco = 6.50m },
            new() { Id = 12, Nome = "Mochila", Preco = 129.90m }
        };

        public IActionResult Listar()
        {
            return View(Produtos);
        }

        public IActionResult Detalhes(int id)
        {
            var produto = Produtos.FirstOrDefault(item => item.Id == id);
            return produto is null ? NotFound() : View(produto);
        }
    }
}