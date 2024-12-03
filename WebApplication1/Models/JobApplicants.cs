namespace WebApplication1.Models;

public class JobApplicants
{
    enum Status
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    
    int applicant_id { get; set; }
    
    int job_id { get; set; }
    
    Status status { get; set; }
}