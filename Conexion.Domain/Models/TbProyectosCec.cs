using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProyectosCec
{
    public int LngIdProyecto { get; set; }

    public int? IntIdNegocio { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdStatusPro { get; set; }

    public string? TxtFolioProyecto { get; set; }

    public DateOnly? FecProyecto { get; set; }

    public int? IntIdProyecto { get; set; }

    public string? TxtReferencia { get; set; }

    public string? TxtNumFactura { get; set; }

    public int? IntIdEjecutivo { get; set; }

    public int? LngIdCliente { get; set; }

    public int? IntIdTipoMov { get; set; }

    public int? IntIdFacturadora { get; set; }

    public decimal? DblDeposito { get; set; }

    public decimal? DblImporteSaldoAnt { get; set; }

    public int? IntIdBaseHono { get; set; }

    public decimal? DblBaseHono { get; set; }

    public decimal? DblPorHonoAct { get; set; }

    public decimal? DblPorHonoDes { get; set; }

    public bool? BolDevolucionIva { get; set; }

    public int? IntIdCortoOper { get; set; }

    public decimal? DblOtroIngr { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? DblSubTotal { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblHonoracio { get; set; }

    public decimal? DblOtrosIng { get; set; }

    public decimal? DblRetorno { get; set; }

    public decimal? DblDispNom { get; set; }

    public decimal? DblDispAsim { get; set; }

    public decimal? DblDispSim { get; set; }

    public decimal? DblFondeo { get; set; }

    public decimal? DblEfectivo { get; set; }

    public decimal? DblSindicato { get; set; }

    public decimal? DblRetFon { get; set; }

    public decimal? DblVales { get; set; }

    public decimal? DblPorVales { get; set; }

    public decimal? DblSaldoPendRet { get; set; }

    public decimal? DblSaldoPendCc { get; set; }

    public decimal? DblCostoSocial { get; set; }

    public decimal? DblReteInf { get; set; }

    public decimal? DblIsrRete { get; set; }

    public decimal? DblOtrosDesc { get; set; }

    public decimal? DblProvisionIva { get; set; }

    public decimal? DblPorHonoSin { get; set; }

    public decimal? DblHonoSin { get; set; }

    public decimal? DblPorCostoOpe { get; set; }

    public decimal? DblComisionBase { get; set; }

    public decimal? DblDescProm { get; set; }

    public int? IntIdPromotor1 { get; set; }

    public decimal? DblPorPromo1 { get; set; }

    public decimal? DblComisionPromo1 { get; set; }

    public DateOnly? FecPagoPromo1 { get; set; }

    public decimal? DblImportePagPromo1 { get; set; }

    public int? IntIdPromotor2 { get; set; }

    public decimal? DblPorPromo2 { get; set; }

    public decimal? DblComisionPromo2 { get; set; }

    public DateOnly? FecPagoPromo2 { get; set; }

    public decimal? DblImportePagPromo2 { get; set; }

    public int? IntIdPromotor3 { get; set; }

    public decimal? DblPorPromo3 { get; set; }

    public decimal? DblComisionPromo3 { get; set; }

    public DateOnly? FecPagoPromo3 { get; set; }

    public decimal? DblImportePagPromo3 { get; set; }

    public int? IntIdPromotor4 { get; set; }

    public decimal? DblPorPromo4 { get; set; }

    public decimal? DblComisionPromo4 { get; set; }

    public DateOnly? FecPagoPromo4 { get; set; }

    public decimal? DblImportePagPromo4 { get; set; }

    public decimal? DblUtilCec { get; set; }

    public decimal? DblCorporativo { get; set; }

    public decimal? DblGastoCec { get; set; }

    public decimal? DblDepositoTipo { get; set; }

    public decimal? DblUtilidaCam { get; set; }

    public string? TxtObservaciones { get; set; }
}
