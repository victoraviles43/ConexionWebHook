using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoTpv
{
    public int LngIdProductoTpv { get; set; }

    public int LngIdProductoGral { get; set; }

    public decimal? DblShonorario { get; set; }

    public decimal? DblScostoOperativo { get; set; }

    public bool? BolSbaseTotal { get; set; }

    public bool? BolSbaseSubTotal { get; set; }

    public bool? BolSbaseRetorno { get; set; }

    public bool? BolSprovision { get; set; }

    public bool? BolSfacturacion { get; set; }

    public bool? BolSconsig { get; set; }

    public bool? BolSretornoTcripto { get; set; }

    public bool? BolSretornoMon { get; set; }

    public bool? BolSretornoAsim { get; set; }

    public bool? BolSretornoSindicato { get; set; }

    public bool? BolSactivo { get; set; }

    public DateOnly? FecSinicioOper { get; set; }

    public bool? BolSretornoTransferSimple { get; set; }

    public bool? BolSretornoEfe { get; set; }

    public bool? BolSretornoDn { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? TxtSbanco { get; set; }

    public string? TxtScuenta { get; set; }

    public int? NumTerminales { get; set; }

    public string? TxtMarca { get; set; }

    public string? TxtDomicilio { get; set; }

    public decimal? DblSimporteAoperar { get; set; }

    public string? TxtSperiodicidad { get; set; }

    public bool? BolConsigna { get; set; }

    public bool? BolParcialidades { get; set; }

    public bool? BolPagoUnico { get; set; }

    public bool? BolPagoDirecto { get; set; }

    public decimal? DblPhonorario { get; set; }

    public decimal? DblPcostoOperativo { get; set; }

    public bool? BolPbaseTotal { get; set; }

    public bool? BolPbaseSubTotal { get; set; }

    public bool? BolPbaseRetorno { get; set; }

    public bool? BolPprovision { get; set; }

    public bool? BolPfacturacion { get; set; }

    public bool? BolPretornoEfe { get; set; }

    public bool? BolPconsg { get; set; }

    public bool? BolPretornoDn { get; set; }

    public bool? BolPretornoMonederos { get; set; }

    public bool? BolPretornoAsim { get; set; }

    public bool? BolPretornoSindicato { get; set; }

    public bool? BolPretornoTsimple { get; set; }

    public bool? BolPtcripto { get; set; }

    public DateOnly? FecPinicioOper { get; set; }

    public bool? BolPactivo { get; set; }

    public string? TxtPempresaAsig { get; set; }

    public string? TxtPbanco { get; set; }

    public string? TxtPcuenta { get; set; }

    public decimal? DblPimporteAoperar { get; set; }

    public string? TxtPperiodicidad { get; set; }

    public string? TxtPproveedor { get; set; }

    public decimal? DblChonorario { get; set; }

    public decimal? DblCcostoOperativo { get; set; }

    public bool? BolCbaseTotal { get; set; }

    public bool? BolCbaseSubtotal { get; set; }

    public bool? BolCbaseRetorno { get; set; }

    public bool? BolCprovision { get; set; }

    public bool? BolCfacturacion { get; set; }

    public bool? BolCretornoEfe { get; set; }

    public bool? BolCconsig { get; set; }

    public bool? BolCretornoDn { get; set; }

    public bool? BolCmonederos { get; set; }

    public bool? BolCasimilados { get; set; }

    public bool? BolCsindicato { get; set; }

    public bool? BolCtsimples { get; set; }

    public bool? BolCtcripto { get; set; }

    public DateOnly? FecCinicioOper { get; set; }

    public bool? BolCactivo { get; set; }

    public bool? BolSrequiereCap { get; set; }

    public int? IntIdCapacitador { get; set; }

    public DateOnly? FecRecibe { get; set; }

    public string? TxtRecibe { get; set; }

    public decimal? DblInHon { get; set; }
}
