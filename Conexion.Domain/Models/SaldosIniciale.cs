using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class SaldosIniciale
{
    public double? _ { get; set; }

    public string? Estatus { get; set; }

    public string? Empresa { get; set; }

    public string? Banco { get; set; }

    public string? Moneda { get; set; }

    public string? Clabe { get; set; }

    public string? Responsable { get; set; }

    public string? UnidadDeNegocio { get; set; }

    public string? NombreDelArchivoDeMovimientos { get; set; }

    public decimal? SaldoIncialFebrero { get; set; }

    public DateTime? FechaSaldo { get; set; }
}
