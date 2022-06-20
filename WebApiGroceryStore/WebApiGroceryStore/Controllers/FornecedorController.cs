using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiGroceryStore.Model;
using WebApiGroceryStore.Repositorio;

namespace WebApiGroceryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly FornecedorRepositorio fornecedorRepositorio;

        public FornecedorController()
        {
            fornecedorRepositorio = new FornecedorRepositorio();
        }

        //Get
        [HttpGet]
        public ActionResult<IEnumerable<Fornecedor>> Get()
        {
            return fornecedorRepositorio.GetFornecedor;
        }

        //Post
        [HttpPost]
        public void Post([FromBody] Fornecedor fornecedor)
        {
            fornecedorRepositorio.InserirFornecedor(fornecedor);
        }

        //Put
        [HttpPut]
        public void put([FromBody] Fornecedor fornecedor)
        {
            fornecedorRepositorio.UpdateFornecedor(fornecedor);
        }

        //Delete
        [HttpDelete]
        public void delete([FromBody] Fornecedor fornecedor)
        {
            fornecedorRepositorio.DeleteFornecedor(fornecedor);
        }
    }
}
