using NuGet.Packaging.Signing;

namespace WebApplication1.Models;

public class Professional
{
    public int id { get; set; }
    
    public string name { get; set; }
    
    public string role { get; set; }
    
    public string experience { get; set; }
    
    public Timestamp createdAt { get; set; }
}