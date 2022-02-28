using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationTokenExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        List<string> days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [HttpGet("GetDays")]
        public async Task<IActionResult> GetDays()
        {
            try
            {
                await Task.Delay(5000);
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine($"No CancellationToken: {ex.Message}");
            }
            return Ok(days);
        }

        [HttpGet("GetDaysWithCancellationToken")]
        public async Task<IActionResult> GetDaysWithCancellationToken(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Delay(5000, cancellationToken);
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine($"CancellationToken: {ex.Message}");
            }
            return Ok(days);
        }
    }
}
