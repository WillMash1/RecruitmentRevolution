using NuGet.Packaging.Signing;

namespace WebApplication1.Models;

public class Jobs
{
  public int Id { get; set; }
  
  public string role { get; set; }
  
  public string required_experience { get; set; }
  
  public string required_skills { get; set; }
  
  public string job_description { get; set; }
  
  public Timestamp created_at { get; set; }
  
  public int created_by { get; set; }
  
  
  
}