using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSaldosLog
{
    public int LngIdSaldosLog { get; set; }

    public int LngIdSaldos { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? IntIdCliente { get; set; }

    public DateOnly? FecDia { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdMoneda { get; set; }

    public DateOnly? FecBaja { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public int? IntTipoSaldo { get; set; }

    public int? LngIdFlujo { get; set; }

    public int? LngIdDepositos { get; set; }

    public int? IntIdEmpresa { get; set; }
}
