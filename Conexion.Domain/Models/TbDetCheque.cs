using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDetCheque
{
    public int IntIdCheque { get; set; }

    public string? TxtFolio { get; set; }

    public DateOnly? FecDia { get; set; }

    public DateOnly? FecCheque { get; set; }

    public string? TxtConcepto { get; set; }

    public byte[]? ArImagen { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public decimal? DblImporte { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtNumFactura { get; set; }
}
