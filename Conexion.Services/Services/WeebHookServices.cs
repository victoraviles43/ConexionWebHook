using Conexion.Domain.DbContexto;
using Conexion.Domain.Dto;
using Conexion.Domain.Models;
using Conexion.Domain.Util;
using Conexion.Repository;
using Conexion.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conexion.Services.Services
{
	public class WeebHookServices : IWeebhook
	{
		private readonly WebhookRepository _repository;

		public WeebHookServices(WebhookRepository repository)
		{
			_repository = repository;
		}

		public async Task GuardarEventosAsync(List<WebhookDto> eventos)
		{
			var lista = eventos.Select(x => new WebhookEven
			{
				Vin = x.Vin,
				Placa = x.Placa,
				Dispositivo = x.Dispositivo,
				FechaEnvio = x.FechaEnvio,
				FechaInicio = x.FechaInicio,
				FechaFinal = x.FechaFinal,
				EventoId = x.EventoId,
				Evento = x.Evento,
				Orden = x.Orden,
				Nombre = x.Nombre,
				Apellidos = x.Apellidos,
				Correo = x.Correo,
				Estado = "Pendiente",
				Intentos = 0,
				FechaCreacion = DateTime.Now
			}).ToList();

			await _repository.CrearMasivo(lista);
		}



		
	}
}