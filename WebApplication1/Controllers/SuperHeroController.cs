using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entity;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroController : Controller
{
    private readonly DataContext _context;
    private readonly ISuperHeroService _superHeroService;
    public SuperHeroController(ISuperHeroService superHeroService)
    {
        _superHeroService = superHeroService;
    }
    
    // GET
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<SuperHero>>>> GetAllHeroes()
    {
        return Ok(await _superHeroService.GetAllHeroes());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SuperHero>> GetHero(int id)
    {
        var hero = await _context.MyProperty.FindAsync(id);
        if(hero == null) 
            return BadRequest("Hero not found");
        
        return Ok(hero);
    }

    [HttpPost]
    public async Task<ActionResult<SuperHero>> AddHero(SuperHero hero)
    {
        _context.MyProperty.Add(hero);
        await _context.SaveChangesAsync();
        return Ok(hero);
    }
    
    [HttpPut]
    public async Task<ActionResult<SuperHero>> UpdateHero(SuperHero hero)
    {
        var dbHero = await _context.MyProperty.FindAsync(hero.Id);
        if(dbHero is null) 
            return NotFound("Hero not found");
        
        dbHero.Name = hero.Name;
        dbHero.FirstName = hero.FirstName;
        dbHero.LastName = hero.LastName;
        dbHero.Place = hero.Place;
        
        // _context.MyProperty.Update(hero);
        await _context.SaveChangesAsync();
        return Ok(hero);
    }
    
    [HttpDelete]
    public async Task<ActionResult<SuperHero>> DeleteHero(int id)
    {
        var dbHero = await _context.MyProperty.FindAsync(id);
        if(dbHero is null) 
            return NotFound("Hero not found");
        _context.MyProperty.Remove(dbHero);
        await _context.SaveChangesAsync();
        return Ok();
    }
}