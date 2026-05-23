using Conexion.Domain.Dto;
using Conexion.Domain.Models;
using Conexion.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Services.IServices
{
    public  interface IWeebhook
    {


		Task GuardarEventosAsync(List<WebhookDto> eventos);

	}
}
