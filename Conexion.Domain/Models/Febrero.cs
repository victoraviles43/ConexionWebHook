using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class Febrero
{
    public double? F1 { get; set; }

    public string? ClabeEmpresaBancoMoneda { get; set; }

    public decimal? SaldoInicial { get; set; }

    public decimal? SumaRetiros { get; set; }

    public decimal? SumaDepositos { get; set; }

    public decimal? Saldos { get; set; }

    public string? Ejecutivo { get; set; }

    public string? Columna1 { get; set; }
}
