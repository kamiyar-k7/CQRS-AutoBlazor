using Application.Dtos;
using Application.Services.CategoryType.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        #region ctor
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        #endregion


        [HttpGet("ListOfProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListOfProduct()
        {
          
            var productList = await _mediator.Send( new GetAllCategoryRequest());

         
            return Ok(productList);
        }

    }
}
