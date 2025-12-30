using Microsoft.AspNetCore.Mvc;
using GitHubIntegration.Service;
using GitHubIntegration.Service.Models;

namespace WebApiSite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly GitHubService _githubService;

        public PortfolioController(GitHubService githubService)
        {
            _githubService = githubService;
        }

        // GET: api/Portfolio
        [HttpGet]
        public async Task<ActionResult<List<RepositoryDetails>>> Get()
        {
            var portfolio = await _githubService.GetPortfolioAsync();
            return Ok(portfolio);
        }

        // GET: api/Portfolio/search
        [HttpGet("search")]
        public async Task<ActionResult<List<RepositoryDetails>>> Search([FromQuery] string? name, [FromQuery] string? language, [FromQuery] string? user)
        {
            var results = await _githubService.SearchRepositoriesAsync(name, language, user);
            return Ok(results);
        }
    }
}