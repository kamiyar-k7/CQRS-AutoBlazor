using Application.Dtos;
using Application.Services.CategoryType.Request.Command;
using Application.Services.CategoryType.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }





    [HttpGet("[Action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<CategoryDto>> GetCategoryById(int Id)
    {
        var category = await _mediator.Send(new GetCategoryRequest());

        return Ok(category);


    }

    [HttpGet("[Action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<CategoryDto>>> GetAllCategories()
    {

        var categories = await _mediator.Send(new GetAllCategoryRequest());


        return Ok(categories);

    }

    [HttpPost("[Action]")]
    [ProducesResponseType(StatusCodes.Status201Created)]

    public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
    {
        await _mediator.Send(new CreateCategoryRequest(categoryDto));

        return CreatedAtAction(nameof(CreateCategory), new { Id = categoryDto.Id });
    }



}
