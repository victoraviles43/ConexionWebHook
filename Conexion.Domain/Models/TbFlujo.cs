using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbFlujo
{
    public int LngIdflujo { get; set; }

    public string? TxtRegistro { get; set; }

    public int? IntIdUsuario { get; set; }

    public string? TxtSolicitado { get; set; }

    public DateTime? FecDia { get; set; }

    public int? IntIdcliente { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdPlazaEquipo { get; set; }

    public int? IntIdIngresos { get; set; }

    public int? IntIdComprobacion { get; set; }

    public int? IntIdRetorno { get; set; }

    public int? IntIdEstrategia { get; set; }

    public string? TxtProyecto { get; set; }

    public bool? BolPrioridad { get; set; }

    public decimal? DblDeposito { get; set; }

    public decimal? DblBaseHonorarios { get; set; }

    public decimal? DblSubTotal { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblTotal { get; set; }

    public int? IntIdEjecutvoOp { get; set; }

    public int? IntIdPromotor1 { get; set; }

    public int? IntIdPromotor2 { get; set; }

    public int? IntIdPromotor3 { get; set; }

    public int? IntIdPromotor4 { get; set; }

    public decimal? DblPorcPro1 { get; set; }

    public decimal? DblPorcPro2 { get; set; }

    public decimal? DblPorcPro3 { get; set; }

    public decimal? DblPorcPro4 { get; set; }

    public decimal? DblValPro1 { get; set; }

    public decimal? DblValPro2 { get; set; }

    public decimal? DblValPro3 { get; set; }

    public decimal? DblValPro4 { get; set; }

    public DateOnly? FecPro1 { get; set; }

    public DateOnly? FecPro2 { get; set; }

    public DateOnly? FecPro3 { get; set; }

    public DateOnly? FecPro4 { get; set; }

    public decimal? DblSaldoAnterior { get; set; }

    public int? IntIdCostOper { get; set; }

    public decimal? DblRetorno { get; set; }

    public decimal? DblFondeo { get; set; }

    public decimal? DblEfectivo { get; set; }

    public decimal? DblGastoCec { get; set; }

    public decimal? DblUtilidCm { get; set; }

    public int? IntIdStatusFlujo { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateOnly? FecProyecto { get; set; }

    public decimal? DblDispersion { get; set; }

    public decimal? DblPorCliente { get; set; }

    public decimal? DblPendiRetorno { get; set; }

    public decimal? DblSaldoPorCobrar { get; set; }

    public decimal? DblSaldoAnteriorDolares { get; set; }

    public int? IntIdStatusTeso { get; set; }

    public string? TxtRutaComprobante { get; set; }

    public string? TxtMotivo { get; set; }

    public int? IntIdOperacion { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdPromotor5 { get; set; }

    public int? IntIdPromotor6 { get; set; }

    public decimal? DblPorcPro5 { get; set; }

    public decimal? DblPorcPro6 { get; set; }

    public decimal? DblValPro5 { get; set; }

    public decimal? DblValPro6 { get; set; }

    public DateOnly? FecPro5 { get; set; }

    public DateOnly? FecPro6 { get; set; }

    public DateTime? FecAprobado { get; set; }

    public string? TxtRelacion { get; set; }
}
