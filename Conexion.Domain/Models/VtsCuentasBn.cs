using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class VtsCuentasBn
{
    public int Movimiento { get; set; }

    public string? FechaCorta { get; set; }

    public string? Hora { get; set; }

    public string Banco { get; set; } = null!;

    public string? CuentaOrdenante { get; set; }

    public string? Concepto { get; set; }

    public decimal? Depositos { get; set; }

    public decimal? Retiros { get; set; }

    public decimal? Saldo { get; set; }

    public string? Referencia { get; set; }

    public string? Beneficiario { get; set; }

    public string? BancoBen { get; set; }

    public string? ClabeTdd { get; set; }

    public string? Status { get; set; }

    public DateOnly? Fechabaja { get; set; }
}
