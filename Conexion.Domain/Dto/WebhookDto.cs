using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Domain.Dto
{
	public class WebhookDto
	{
		  
        public string Vin { get; set; }

		public string Placa { get; set; }

		public string Dispositivo { get; set; }

		public DateTime FechaEnvio { get; set; }

		public DateTime FechaInicio { get; set; }

		public DateTime FechaFinal { get; set; }

		public int EventoId { get; set; }

		public string Evento { get; set; }

		public string Orden { get; set; }

		public string Nombre { get; set; }

		public string Apellidos { get; set; }

		public string Correo { get; set; }
	}
}
