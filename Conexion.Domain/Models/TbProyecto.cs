using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProyecto
{
    public int IntIdProyecto { get; set; }

    public string? TxtFolioProyecto { get; set; }

    public decimal? NumFolio { get; set; }

    public DateTime? FecProyecto { get; set; }

    public string? TxtNumFactura { get; set; }

    public int? IntIdCliente { get; set; }

    public int? IntIdTipoMovimiento { get; set; }

    public int? IntIdFacturadora { get; set; }

    public decimal? DblImporteDeposito { get; set; }

    public decimal? DblImporteSaldoAnterior { get; set; }

    public int? IntIdBaseHonorarios { get; set; }

    public decimal? DblBaseHonorarios { get; set; }

    public decimal? DblProHonorarioActual { get; set; }

    public decimal? DblPorHonorarioIncre { get; set; }

    public bool? BolDevolucionIva { get; set; }

    public bool? BolCostoOperacional { get; set; }

    public decimal? DblOtrosIngresos { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? DblSubTotal { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblHonorario { get; set; }

    public decimal? DblOtrosIngresos2 { get; set; }

    public decimal? DblRetorno { get; set; }

    public decimal? DblDispercionNominal { get; set; }

    public decimal? DblDispercionAsimilado { get; set; }

    public decimal? DblDispercionSimple { get; set; }

    public decimal? DblFondeo { get; set; }

    public decimal? DblEfectivo { get; set; }

    public decimal? DblSindicato { get; set; }

    public decimal? DblRetencionFon { get; set; }

    public decimal? DblValeDespensa { get; set; }

    public decimal? DblValeDesCom { get; set; }

    public decimal? DblSaldoPendienteRet { get; set; }

    public decimal? DblSaldoPendienteCob { get; set; }

    public decimal? DblCostoSocial { get; set; }

    public decimal? DblRetencionInfo { get; set; }

    public decimal? DblIsrRetenido { get; set; }

    public decimal? DblOtrosDescuentos { get; set; }

    public decimal? DblProvicionIva { get; set; }

    public decimal? DblPorHonSin { get; set; }

    public decimal? DblValorHonSin { get; set; }

    public decimal? DblCostoOperacional { get; set; }

    public decimal? DblComisionBase { get; set; }

    public decimal? DblDescPromotor { get; set; }

    public int? IntIdPromotor1 { get; set; }

    public decimal? DblPorProPrin { get; set; }

    public decimal? DblValProPrin { get; set; }

    public DateTime? FecPago1 { get; set; }

    public decimal? DbImportePago1 { get; set; }

    public int? IntIdPromotor2 { get; set; }

    public decimal? DblPorProAdic2 { get; set; }

    public decimal? DblValProAdic2 { get; set; }

    public DateTime? FecPago2 { get; set; }

    public decimal? DbImportePago2 { get; set; }

    public int? IntIdPromotor3 { get; set; }

    public decimal? DblPorProAdic3 { get; set; }

    public decimal? DblValProAdic3 { get; set; }

    public decimal? FecPago3 { get; set; }

    public decimal? DbImportePago3 { get; set; }

    public int? IntIdPromotor4 { get; set; }

    public decimal? DblPorProAdic4 { get; set; }

    public decimal? DblValProAdic4 { get; set; }

    public decimal? FecPago4 { get; set; }

    public decimal? DbImportePago4 { get; set; }

    public decimal? DblUtilidadCec { get; set; }

    public decimal? DblConcentradora { get; set; }

    public decimal? DblAdfinza { get; set; }

    public decimal? DblPlaza { get; set; }

    public decimal? DblFacturadora { get; set; }

    public decimal? DblAdfinza2 { get; set; }

    public decimal? DblConstruConsul { get; set; }

    public decimal? DblTipoCambioRet { get; set; }

    public decimal? DblUnidadCambiaria { get; set; }

    public string? TxtObservaciones { get; set; }

    public decimal? DblDiferencias { get; set; }
}
