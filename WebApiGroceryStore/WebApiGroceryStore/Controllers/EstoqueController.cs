using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiGroceryStore.Model;
using WebApiGroceryStore.Repositorio;

namespace WebApiGroceryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly EstoqueRepositorio estoqueRepositorio;

        public EstoqueController()
        {
            estoqueRepositorio = new EstoqueRepositorio();
        }

        //Get
        [HttpGet]
        public ActionResult<IEnumerable<Estoque>> Get()
        {
            return estoqueRepositorio.GetEstoque;
        }

        //Post
        [HttpPost]
        public void Post([FromBody] Estoque estoque)
        {
            estoqueRepositorio.InserirEstoque(estoque);
        }

        //Put
        [HttpPut]
        public void put([FromBody] Estoque estoque)
        {
            estoqueRepositorio.UpdateEstoque(estoque);
        }

        //Delete
        [HttpDelete]
        public void delete([FromBody] Estoque estoque)
        {
            estoqueRepositorio.DeleteEstoque(estoque);
        }
    }
}
