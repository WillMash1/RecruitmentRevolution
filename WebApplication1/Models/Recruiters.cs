using NuGet.Packaging.Signing;

namespace WebApplication1.Models;

public class Recruiters
{
    int id { get; set; }
    
    string role { get; set; }

    Timestamp created_at { get; set; }
}