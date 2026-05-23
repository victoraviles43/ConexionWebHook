using Conexion.Domain.Dto;
using Conexion.Domain.Models;
using Conexion.Services.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeebhookController : ControllerBase
    {
        private readonly IWeebhook _weebhookServices;
        public WeebhookController(IWeebhook billServices)
        {
			_weebhookServices = billServices;
        }


		[HttpPost]
		public async Task<IActionResult> RecibirWebhook([FromBody] List<WebhookDto> eventos)
		{
			if (eventos == null || !eventos.Any())
			{
				return BadRequest("No se recibieron");
			}

			await _weebhookServices.GuardarEventosAsync(eventos);

			return Ok(new
			{
				mensaje = "Webhook recibido correctamente",
				total = eventos.Count
			});
		}
	}
}
