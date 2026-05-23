using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbMovimiento
{
    public int LngIdMovimiento { get; set; }

    public int? LngIdEmpresaDep { get; set; }

    public int? LngIdEmpresaDes { get; set; }

    public DateOnly? FecDia { get; set; }

    public int? IntIdMovimiento { get; set; }

    public string? TxtCuentaDestino { get; set; }

    public decimal? DblRetiro { get; set; }

    public decimal? DblDeposito { get; set; }

    public decimal? DblSaldo { get; set; }

    public decimal? DblComprobacionSaldo { get; set; }

    public decimal? DblDif { get; set; }

    public int? IntIdUsuario { get; set; }

    public int? IntIdStatusMov { get; set; }

    public DateOnly? FecCierre { get; set; }

    public DateOnly? FecCancelado { get; set; }

    public DateOnly? FecDeposito { get; set; }

    public int? IntIdCuentaDep { get; set; }

    public int? IntIdCuentaDes { get; set; }
}
