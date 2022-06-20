using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiProject.Model;
using WebApiProject.Repositorio;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly ContaRepositorio contaRepositorio;

        public ContaController()
        {
            contaRepositorio = new ContaRepositorio();
        }

        //Get
        [HttpGet]
        public ActionResult<IEnumerable<Conta>> Get()
        {
            return contaRepositorio.GetConta;
        }

        //Post
        [HttpPost]
        public void Post([FromBody] Conta conta)
        {
            contaRepositorio.inserirConta(conta);
        }

        //Put
        [HttpPut]
        public void Put([FromBody] Conta conta)
        {
            contaRepositorio.updateConta(conta);
        }

        //Delete
        [HttpDelete]
        public void delete([FromBody] Conta conta)
        {
            contaRepositorio.deleteConta(conta);
        }

    }
}
