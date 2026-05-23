using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCheckListJuriLog
{
    public int IntIdCheckListLog { get; set; }

    public int IntIdCheckList { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime? FecMovimiento { get; set; }

    public string? TxtNumContrato { get; set; }

    public DateOnly? FecCheckList { get; set; }

    public int? IntIdCliente { get; set; }

    public int? IntIdPlaza { get; set; }

    public string? TxtConcepto { get; set; }

    public decimal? DblValorContrato { get; set; }

    public decimal? DblIva { get; set; }

    public bool? ChkPm1 { get; set; }

    public bool? ChkPm2 { get; set; }

    public bool? ChkPm3 { get; set; }

    public bool? ChkPm4 { get; set; }

    public bool? ChkPm5 { get; set; }

    public bool? ChkPm6 { get; set; }

    public bool? ChkPm7 { get; set; }

    public bool? ChkPf1 { get; set; }

    public bool? ChkPf2 { get; set; }

    public bool? ChkPf3 { get; set; }

    public bool? ChkPf4 { get; set; }

    public bool? ChkPf5 { get; set; }

    public bool? ChkPf6 { get; set; }

    public bool? ChkEn1 { get; set; }

    public bool? ChkEn2 { get; set; }

    public bool? ChkEn3 { get; set; }

    public int? IntIdGiro { get; set; }

    public string TxtComision { get; set; } = null!;

    public DateOnly? FecInicioOp { get; set; }

    public int? IntIdPeriodicidad { get; set; }

    public decimal? DblMontoOp { get; set; }

    public string? TxtTipoRetorno { get; set; }

    public decimal? NumTerminales { get; set; }

    public string? TxtDomicilioEntTpv { get; set; }

    public decimal? DblPagoGarantiaTpv { get; set; }

    public string? TxtTelefonoOfi { get; set; }

    public string? TxtCorreoCli { get; set; }

    public string? TxtContacto { get; set; }

    public string? TxtRegistro { get; set; }

    public string? TxtComentarios { get; set; }

    public string? TxtRepresentante { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdStatusJuri { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdSucursal { get; set; }

    public int? IntIdEvento { get; set; }

    public int? IntIdNegocio { get; set; }

    public string? TxtRfc { get; set; }

    public string? TxtCurp { get; set; }

    public int? IntIdProducto { get; set; }
}
