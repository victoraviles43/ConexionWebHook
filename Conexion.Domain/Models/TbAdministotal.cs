using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAdministotal
{
    public int LngIdAdministotal { get; set; }

    public int? IntIdCliente { get; set; }

    public DateTime? FecRegistro { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdOperacion { get; set; }

    public int? IntIdSuboperacion { get; set; }

    public string? TxtRegistro { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecFin { get; set; }

    public int? IntIdIngresos { get; set; }

    public decimal? DblValorIngreso { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public decimal? DblValorRetorno { get; set; }

    public decimal? PorComision { get; set; }

    public decimal? DblValComision { get; set; }

    public decimal? DblCusto { get; set; }

    public decimal? DblCostoOperacional { get; set; }

    public decimal? DblRetorno { get; set; }

    public decimal? DblPorCliente { get; set; }

    public decimal? DblSaldoPorCobrar { get; set; }

    public int? IntIdCostOper { get; set; }

    public int? IntIdStatusAdmin { get; set; }

    public int? IntIdusuario { get; set; }

    public string? TxtFlujo { get; set; }
}
