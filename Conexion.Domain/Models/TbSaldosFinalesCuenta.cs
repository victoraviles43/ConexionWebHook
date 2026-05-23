using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSaldosFinalesCuenta
{
    public int LngIdSaldosFinales { get; set; }

    public string? TxtCuentaOrdenante { get; set; }

    public decimal? DblSaldoInicial { get; set; }

    public decimal? DblDeposito { get; set; }

    public decimal? DblRetiro { get; set; }

    public decimal? DblSaldo { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtBanco { get; set; }
}
