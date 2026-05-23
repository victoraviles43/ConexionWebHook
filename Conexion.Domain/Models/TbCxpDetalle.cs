using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCxpDetalle
{
    public int IntIdCxpDetalle { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public string? TxtConcepto { get; set; }

    public string? TxtNombre { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblSubTotal { get; set; }

    public DateOnly? FecRegistro { get; set; }

    public string? TxtNumFactura { get; set; }
}
