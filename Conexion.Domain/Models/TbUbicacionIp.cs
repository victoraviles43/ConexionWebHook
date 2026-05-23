using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbUbicacionIp
{
    public int IdUbicacionIp { get; set; }

    public string? Ip { get; set; }

    public string? Pais { get; set; }

    public string? Region { get; set; }

    public string? Ciudad { get; set; }

    public string? CodigoPostal { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }
}
