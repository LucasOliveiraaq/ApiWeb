using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiGroceryStore.Model;
using WebApiGroceryStore.Repositorio;

namespace WebApiGroceryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Compra_e_vendaController : ControllerBase
    {
        private readonly Compra_e_vendaRepositorio compra_E_VendaRepositorio;

        public Compra_e_vendaController()
        {
            compra_E_VendaRepositorio = new Compra_e_vendaRepositorio();
        }

        //Get
        [HttpGet]
        public ActionResult<IEnumerable<Compra_e_Venda>> Get()
        {
            return compra_E_VendaRepositorio.GetCompra_e_venda;
        }

        //Post
        [HttpPost]
        public void Post([FromBody] Compra_e_Venda compra_E_Venda)
        {
            compra_E_VendaRepositorio.InserirCompra_e_Venda(compra_E_Venda);
        }

        //Put
        [HttpPut]
        public void put([FromBody] Compra_e_Venda compra_E_Venda)
        {
            compra_E_VendaRepositorio.UpdateCompra_e_venda(compra_E_Venda);
        }

        //Delete
        [HttpDelete]
        public void delete([FromBody] Compra_e_Venda compra_E_Venda)
        {
            compra_E_VendaRepositorio.DeleteCompra_e_venda(compra_E_Venda);
        }
    }
}
