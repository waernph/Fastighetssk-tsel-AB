using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fastighetsskötsel_AB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetReports()
        {
            // Implementation for fetching reports
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetReportById(int id)
        {
            // Implementation for fetching a specific report by ID
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateReport([FromBody] Report report)
        {
            // Implementation for creating a new report
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateReport(int id, [FromBody] Report report)
        {
            // Implementation for updating an existing report
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteReport(int id)
        {
            // Implementation for deleting a report
            return NoContent();
        }
    }
}
