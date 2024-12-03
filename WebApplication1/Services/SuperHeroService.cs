using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class SuperHeroService(DataContext context): ISuperHeroService
{
    public async Task<ServiceResponse<List<SuperHero>>> GetAllHeroes()
    {
        var serviceResponse = new ServiceResponse<List<SuperHero>>();
        var heroes = await context.MyProperty.ToListAsync();
        serviceResponse.Data = heroes;
        return serviceResponse;
    }
    
    public async Task<ActionResult<SuperHero>> GetHero(int id)
    {
        var hero = await context.MyProperty.FindAsync(id);
        return hero;
    }

    public async Task<ActionResult<SuperHero>> AddHero(SuperHero hero)
    {
        context.MyProperty.Add(hero);
        await context.SaveChangesAsync();
        return hero;
    }

    public async Task<ActionResult<SuperHero>> UpdateHero(SuperHero hero)
    {
        var dbHero = await context.MyProperty.FindAsync(hero.Id);
        dbHero.Name = hero.Name;
        dbHero.FirstName = hero.FirstName;
        dbHero.LastName = hero.LastName;
        dbHero.Place = hero.Place;
        
        // _context.MyProperty.Update(hero);
        await context.SaveChangesAsync();
        return hero;
    }

    public async Task<ActionResult<SuperHero>> DeleteHero(int id)
    {
        throw new NotImplementedException();
    }
}