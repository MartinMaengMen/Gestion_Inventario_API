using Entity;
using Gestion_Inventario_Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestion_Inventario_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private IArticuloService ArticuloService;
        public ArticuloController(IArticuloService articuloService)
        {
            ArticuloService = articuloService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(
                ArticuloService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Articulo articulo)
        {
            return Ok(
                ArticuloService.Save(articulo)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Articulo articulo)
        {
            return Ok(
                ArticuloService.Update(articulo)
            );
        }

        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    return Ok(
        //        ArticuloService.Delete(id)
        //    );
        //}
        [HttpDelete("{codigo}")]
        public ActionResult DeleteByCodigo(string codigo)
        {
            return Ok(
                ArticuloService.DeleteByCodigo(codigo)
            );
        }
    }
}
