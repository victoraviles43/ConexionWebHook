using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRetornoLog
{
    public int LngIdRetornoLog { get; set; }

    public int LngIdRetorno { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdflujo { get; set; }

    public int? LngIdEmpresa { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public int? IntIdCuentasPg { get; set; }

    public int? IntIdTipoEstructura { get; set; }

    public int? IntIdTipoDeposito { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdNivel { get; set; }

    public DateTime? FecDia { get; set; }

    public DateOnly? FecDeposito { get; set; }

    public decimal? DblPorCliente { get; set; }

    public int? LngIdPorcliente { get; set; }

    public int? LngIdTipoOper { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public int? LngIdTotalCard { get; set; }

    public decimal? DblIsr { get; set; }

    public decimal? DblIsn { get; set; }

    public decimal? DblImss { get; set; }

    public decimal? DblInfonavit { get; set; }

    public decimal? DblComProveTer { get; set; }

    public decimal? DblComProveTerIva { get; set; }

    public decimal? DblValorDolar { get; set; }

    public bool? BolAplicaSaldo { get; set; }

    public DateOnly? FecDepositoTeso { get; set; }

    public string? TxtReferencia { get; set; }

    public DateTime? FecDepositoTes { get; set; }

    public int? IntIdEmpresa { get; set; }
}
