using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSaldosBanco
{
    public int LngIdSaldo { get; set; }

    public string? TxtCuentaOrdenante { get; set; }

    public int? IntMovimiento { get; set; }

    public decimal? DblSaldo { get; set; }

    public DateOnly? FecBaja { get; set; }

    public DateOnly? FecOper { get; set; }

    public string? TxtBanco { get; set; }
}
