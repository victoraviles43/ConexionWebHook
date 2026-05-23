using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDatosFac
{
    public int IntIdDatosFac { get; set; }

    public int LngIdProductoStr { get; set; }

    public decimal? DblImporteIniFactura { get; set; }

    public string? TxtPeriodicidad { get; set; }

    public int? IntIdEmpresaFac { get; set; }

    public string? TxtClaveSat { get; set; }

    public string? TxtConcepto { get; set; }

    public DateOnly? FecRegistro { get; set; }

    public bool? BolActivo { get; set; }
}
