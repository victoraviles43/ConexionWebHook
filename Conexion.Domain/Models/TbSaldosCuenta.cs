using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSaldosCuenta
{
    public int LngIdSaldo { get; set; }

    public string? TxtCuentaOrdenante { get; set; }

    public decimal? DblSaldo { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtBaco { get; set; }
}
