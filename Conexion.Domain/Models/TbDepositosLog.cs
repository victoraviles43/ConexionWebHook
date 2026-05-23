using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDepositosLog
{
    public int LngIdDepositosLog { get; set; }

    public int LngIdDepositos { get; set; }

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

    public bool? BolFactura { get; set; }

    public decimal? DblPorCliente { get; set; }

    public int? LngIdPorcliente { get; set; }

    public decimal? DblHonorarios { get; set; }

    public int? LngIdTipoOper { get; set; }

    public bool? BolDevolucionIva { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public decimal? DblComisionBancaria { get; set; }

    public decimal? DblIvaBancario { get; set; }

    public string? NumRecibo { get; set; }

    public int? LngIdTerminal { get; set; }

    public decimal? DblComProveTer { get; set; }

    public decimal? DblComProveTerIva { get; set; }

    public decimal? DblValorDolar { get; set; }

    public bool? BolSaldo { get; set; }

    public DateOnly? FecDepositoTeso { get; set; }

    public decimal? DblValorTeso { get; set; }

    public DateOnly? FecFactura { get; set; }

    public string? NumFactura { get; set; }

    public int? IntIdStatusFac { get; set; }

    public string? TxtReferencia { get; set; }

    public DateTime? FecDepositoTes { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdProcesador { get; set; }

    public decimal? DblPorProcesador { get; set; }

    public decimal? DblIvaProcesador { get; set; }
}
