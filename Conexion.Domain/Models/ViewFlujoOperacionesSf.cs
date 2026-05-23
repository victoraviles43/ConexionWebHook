using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewFlujoOperacionesSf
{
    public int IdFlujo { get; set; }

    public string? Status { get; set; }

    public string? Registro { get; set; }

    public string? Fecha { get; set; }

    public string? Plaza { get; set; }

    public string? Region { get; set; }

    public string? TipoDeRetorno { get; set; }

    public string? Estrategia { get; set; }

    public string? Referencia { get; set; }

    public string? EjecutivoOp { get; set; }

    public string? Cliente { get; set; }

    public int? CantidadFac { get; set; }

    public string? Facturadora { get; set; }

    public decimal? Deposito { get; set; }

    public decimal Saldo { get; set; }

    public decimal PendiRetorno { get; set; }

    public decimal? BaseHonorarios { get; set; }

    public decimal BaseHonorariosxRetorno { get; set; }

    public decimal Honorario { get; set; }

    public decimal? Retorno { get; set; }

    public int? CantidadRet { get; set; }

    public string? RetornoEmp { get; set; }

    public int Sindicato { get; set; }

    public decimal ImporteServicioRet { get; set; }

    public string? ServicioRet { get; set; }

    public decimal ImporteServicioRetGlobal { get; set; }

    public string? ServicioRetGlobal { get; set; }

    public decimal ImporteServicioRetSindicato { get; set; }

    public string? ServicioRetSindicato { get; set; }

    public decimal? ImporteServicioDep { get; set; }

    public string? ServicioDep { get; set; }

    public decimal? Imss { get; set; }

    public decimal? Infonavit { get; set; }

    public decimal? Isn { get; set; }

    public decimal? Isr { get; set; }

    public decimal? CostoOperativo { get; set; }

    public decimal? CostoOperativo1 { get; set; }

    public decimal? ComisionBase { get; set; }

    public string? Promotor1 { get; set; }

    public decimal? Promotor11 { get; set; }

    public decimal ComPromotor1 { get; set; }

    public string? Promotor2 { get; set; }

    public decimal? Promotor21 { get; set; }

    public decimal ComPromotor2 { get; set; }

    public string? Promotor3 { get; set; }

    public decimal? Promotor31 { get; set; }

    public decimal ComPromotor3 { get; set; }

    public string? Promotor4 { get; set; }

    public decimal? Promotor41 { get; set; }

    public decimal ComPromotor4 { get; set; }

    public string? Promotor5 { get; set; }

    public decimal? Promotor51 { get; set; }

    public decimal ComPromotor5 { get; set; }

    public string? Promotor6 { get; set; }

    public decimal? Promotor61 { get; set; }

    public decimal ComPromotor6 { get; set; }

    public decimal? Promotores { get; set; }

    public decimal? UtilidCec { get; set; }

    public string? Moneda { get; set; }

    public decimal Comeracial30 { get; set; }

    public string? StatusTeso { get; set; }

    public string? Operacion { get; set; }

    public decimal CostosEst { get; set; }

    public decimal ComBan { get; set; }

    public decimal OtrosGastos { get; set; }

    public decimal ProvCorpo { get; set; }

    public decimal ImpProv { get; set; }

    public decimal SocProv { get; set; }

    public string? Observaciones { get; set; }

    public string? Estructura { get; set; }

    public string? Holdings { get; set; }
}
