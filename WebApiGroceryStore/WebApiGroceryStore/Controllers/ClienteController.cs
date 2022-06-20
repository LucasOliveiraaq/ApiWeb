using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiGroceryStore.Model;
using WebApiGroceryStore.Repositorio;

namespace WebApiGroceryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepositorio clienteRepositorio;

        public ClienteController()
        {
            clienteRepositorio = new ClienteRepositorio();
        }

        //Get
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return clienteRepositorio.GetCliente;
        }

        //Post
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            clienteRepositorio.InserirCliente(cliente);
        }

        //Put
        [HttpPut]
        public void put([FromBody] Cliente cliente)
        {
            clienteRepositorio.UpdateCliente(cliente);
        }

        //Delete
        [HttpDelete]
        public void delete([FromBody] Cliente cliente)
        {
            clienteRepositorio.DeleteCliente(cliente);
        }
    }
}
