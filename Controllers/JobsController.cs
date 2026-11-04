namespace JobApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using JobApi.Models;
using System.Runtime.Versioning;
using System.Data.Common;

[ApiController]
[Route("api/[controller]")]

public class JobsController: ControllerBase
{
    [HttpGet]
    public IActionResult GetJobs()
    {
        var jobs = new List<Job>
        {
            new Job{Id=1, Title="Frontend Developer"},
            new Job{Id=2, Title="Backend Developer"},
            new Job{Id=3, Title=".NET Developer"}
        };

        return Ok(jobs);
    }
    

}