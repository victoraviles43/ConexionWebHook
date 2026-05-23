using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewFlujoOperacionesToda
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

    public string? Deposito { get; set; }

    public string? Saldo { get; set; }

    public string? PendiRetorno { get; set; }

    public decimal? BaseHonorarios { get; set; }

    public string? BaseHonorariosxRetorno { get; set; }

    public string? Honorario { get; set; }

    public string? Retorno { get; set; }

    public int? CantidadRet { get; set; }

    public string? RetornoEmp { get; set; }

    public int Sindicato { get; set; }

    public string? ImporteServicioRet { get; set; }

    public string? ServicioRet { get; set; }

    public string? ImporteServicioRetGlobal { get; set; }

    public string? ServicioRetGlobal { get; set; }

    public string? ImporteServicioRetSindicato { get; set; }

    public string? ServicioRetSindicato { get; set; }

    public decimal? ImporteServicioDep { get; set; }

    public string? ServicioDep { get; set; }

    public string? Imss { get; set; }

    public string? Infonavit { get; set; }

    public string? Isn { get; set; }

    public string? Isr { get; set; }

    public decimal? CostoOperativo { get; set; }

    public string? CostoOperativo1 { get; set; }

    public string? ComisionBase { get; set; }

    public string? Promotor1 { get; set; }

    public decimal? Promotor11 { get; set; }

    public string? ComPromotor1 { get; set; }

    public string? Promotor2 { get; set; }

    public decimal? Promotor21 { get; set; }

    public string? ComPromotor2 { get; set; }

    public string? Promotor3 { get; set; }

    public decimal? Promotor31 { get; set; }

    public string? ComPromotor3 { get; set; }

    public string? Promotor4 { get; set; }

    public decimal? Promotor41 { get; set; }

    public string? ComPromotor4 { get; set; }

    public string? Promotor5 { get; set; }

    public decimal? Promotor51 { get; set; }

    public string? ComPromotor5 { get; set; }

    public string? Promotor6 { get; set; }

    public decimal? Promotor61 { get; set; }

    public string? ComPromotor6 { get; set; }

    public string? Promotores { get; set; }

    public string? UtilidCec { get; set; }

    public string? Moneda { get; set; }

    public string? Comeracial30 { get; set; }

    public string? StatusTeso { get; set; }

    public string? Operacion { get; set; }

    public string? CostosEst { get; set; }

    public string? ComBan { get; set; }

    public string? OtrosGastos { get; set; }

    public string? ProvCorpo { get; set; }

    public string? ImpProv { get; set; }

    public string? SocProv { get; set; }

    public string? Observaciones { get; set; }

    public string? Estructura { get; set; }

    public string? Holdings { get; set; }
}
