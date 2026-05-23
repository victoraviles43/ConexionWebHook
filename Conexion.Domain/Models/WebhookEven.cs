using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class WebhookEven
{
    public int LngId { get; set; }

    public string? Vin { get; set; }

    public string? Placa { get; set; }

    public string? Dispositivo { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public int? EventoId { get; set; }

    public string? Evento { get; set; }

    public string? Orden { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Estado { get; set; }

    public int? Intentos { get; set; }

    public string? ErrorMensaje { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaProcesado { get; set; }
}
