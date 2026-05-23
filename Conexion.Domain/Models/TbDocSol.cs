using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocSol
{
    public int LngIdDocSol { get; set; }

    public int? LngIdSolicitudrecurso { get; set; }

    public byte[]? ImgDoc { get; set; }

    public string? TxtExtension { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdmoneda { get; set; }

    public decimal? DblTc { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdPago { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtClabe { get; set; }

    public string? TxtUrlImg { get; set; }

    public string? TxtObservaciones { get; set; }

    public string? TxtConcepto { get; set; }

    public DateOnly? FecPago { get; set; }
}
