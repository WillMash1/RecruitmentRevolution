using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entity;
using WebApplication1.Models;

namespace WebApplication1.Services;

public interface ISuperHeroService
{
    Task<ServiceResponse<List<SuperHero>>> GetAllHeroes();
    Task<ActionResult<SuperHero>> GetHero(int id);

    Task<ActionResult<SuperHero>> AddHero(SuperHero hero);

    Task<ActionResult<SuperHero>> UpdateHero(SuperHero hero);

    Task<ActionResult<SuperHero>> DeleteHero(int id);
}