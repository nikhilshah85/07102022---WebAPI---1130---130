using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsWebAPI.Model;
namespace productsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Model Obj
        //We should use Dependency injection instead of creating the new object 
        //this is a crime
        Products pObj = new Products();


        [HttpGet]
        [Route("plist")]
        public IActionResult GetallProducts()
        {
            return Ok(pObj.GetALlProducts());
        }

        [HttpGet]
        [Route("plist/{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                return Ok(pObj.GetProductById(id));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }

        [HttpPost]
        [Route("plist/add")]
        public IActionResult AddNewProduct(Products newProduct)
        {
            return Created("",pObj.AddProduct(newProduct));
        }

        [HttpDelete]
        [Route("plist/{id}")]
         public IActionResult DeleteProduct(int id)
        {
            try
            {
                return Accepted(pObj.DeleteProduct(id));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);

            }
        }

        [HttpPut]
        [Route("plist/update")]
        public IActionResult UpdateProduct(Products updates)
        {
            try
            {
                return  Ok(pObj.UpdateProduct(updates));
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }





    }
}
