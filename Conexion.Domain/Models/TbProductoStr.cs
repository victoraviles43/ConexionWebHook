using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoStr
{
    public int LngIdProductoStr { get; set; }

    public int? LngIdProductoGral { get; set; }

    public decimal? DblFhonorario { get; set; }

    public decimal? DblFcostoOperativo { get; set; }

    public bool? BolFbaseTotal { get; set; }

    public bool? BolFbaseSubTotal { get; set; }

    public bool? BolFbaseRetorno { get; set; }

    public bool? BolFdevIva { get; set; }

    public bool? BolFprovision { get; set; }

    public bool? BolFretornoEfe { get; set; }

    public bool? BolFbancarizacion { get; set; }

    public bool? BolFconsg { get; set; }

    public bool? BolFretornoDispNomina { get; set; }

    public bool? BolFretornoMonederos { get; set; }

    public bool? BolFretornoAsimilados { get; set; }

    public bool? BolFretornoSindicato { get; set; }

    public bool? BolFretornoTransferSimples { get; set; }

    public bool? BolFtransaccionesCripto { get; set; }

    public bool? BolFsofom { get; set; }

    public bool? BolFsapi { get; set; }

    public bool? BolFactivo { get; set; }

    public DateOnly? FecFinicioOper { get; set; }

    public decimal? DblImporteIniFactura { get; set; }

    public string? TxtPeriodicidad { get; set; }

    public int? IntIdEmpresaFac { get; set; }

    public string? TxtClaveSat { get; set; }

    public string? TxtDescripcion { get; set; }

    public decimal? DblMhonorario { get; set; }

    public decimal? DblMcostoOperativo { get; set; }

    public bool? BolMbaseTotal { get; set; }

    public bool? BolMbaseSubtotal { get; set; }

    public bool? BolMbaseRetorno { get; set; }

    public bool? BolMprovision { get; set; }

    public bool? BolMdevIva { get; set; }

    public bool? BolMretornoDispNomina { get; set; }

    public bool? BolMtransaccionesCripto { get; set; }

    public bool? BolMretornoMonederos { get; set; }

    public bool? BolMretornoAsimilados { get; set; }

    public bool? BolMretornoSindicato { get; set; }

    public bool? BolMretornoEfectivo { get; set; }

    public bool? BolMactivo { get; set; }

    public DateOnly? FecMinicioOper { get; set; }

    public decimal? DblBhonorario { get; set; }

    public decimal? DblBcostoOperativo { get; set; }

    public bool? BolBbaseTotal { get; set; }

    public bool? BolBbaseSubtotal { get; set; }

    public bool? BolBbaseRetonro { get; set; }

    public bool? BolBprovision { get; set; }

    public bool? BolBretornoEfe { get; set; }

    public bool? BolBretornoDispNomina { get; set; }

    public bool? BolBretornoMonederos { get; set; }

    public bool? BolBretornoAsimilados { get; set; }

    public bool? BolBretornoSindicato { get; set; }

    public bool? BolBretornoTransferSimples { get; set; }

    public bool? BolBtransaccionesCripto { get; set; }

    public bool? BolBactivo { get; set; }

    public DateOnly? FecBinicioOper { get; set; }

    public decimal? DblChonorario { get; set; }

    public decimal? DblCcostoOperativo { get; set; }

    public bool? BolCbaseTotal { get; set; }

    public bool? BolCbaseSubtotal { get; set; }

    public bool? BolCbaseRetorno { get; set; }

    public bool? BolCprovision { get; set; }

    public bool? BolCretornoEfe { get; set; }

    public bool? BolCretornoMonederos { get; set; }

    public bool? BolCretornoAsimilados { get; set; }

    public bool? BolCretornoSindicato { get; set; }

    public bool? BolCretornoTransferSimples { get; set; }

    public bool? BolCtransaccionesCripto { get; set; }

    public bool? BolCactivo { get; set; }

    public DateOnly? FecCinicioOper { get; set; }

    public decimal? DblNhonorario { get; set; }

    public decimal? DblNcostoOperativo { get; set; }

    public bool? BolNbaseTotal { get; set; }

    public bool? BolNbaseSubtotal { get; set; }

    public bool? BolNbaseRetorno { get; set; }

    public bool? BolNretornoEfe { get; set; }

    public bool? BolNbanca { get; set; }

    public bool? BolNconsig { get; set; }

    public bool? BolNretornoMonederos { get; set; }

    public bool? BolNretornoAsimilados { get; set; }

    public bool? BolNretornoSindicato { get; set; }

    public bool? BolNretornoTrasferSimples { get; set; }

    public bool? BolNtransaccionesCripto { get; set; }

    public bool? BolNactivo { get; set; }

    public DateOnly? FecNinicioOper { get; set; }

    public decimal? DblAhonorario { get; set; }

    public decimal? DblAcostoOperativo { get; set; }

    public bool? BolAbaseTotal { get; set; }

    public bool? BolAbaseSubtotal { get; set; }

    public bool? BolAbaseRetorno { get; set; }

    public bool? BolAprovision { get; set; }

    public bool? BolAretornoEfe { get; set; }

    public bool? BolAbanca { get; set; }

    public bool? BolAconsig { get; set; }

    public bool? BolAretornoDispNomina { get; set; }

    public bool? BolAretornoSindicato { get; set; }

    public bool? BolAretornoTransfer { get; set; }

    public bool? BolAtransaccionesCripto { get; set; }

    public bool? BolAactivo { get; set; }

    public DateOnly? FecAinicioOper { get; set; }

    public decimal? DblShonorario { get; set; }

    public decimal? DblScostoOperativo { get; set; }

    public bool? BolSbaseTotal { get; set; }

    public bool? BolSbaseSubtotal { get; set; }

    public bool? BolSbaseRetorno { get; set; }

    public bool? BolSprovision { get; set; }

    public bool? BolRetornoEfe { get; set; }

    public bool? BolSbanca { get; set; }

    public bool? BolSconsig { get; set; }

    public bool? BolSretronoDispNomina { get; set; }

    public bool? BolSretornoAsimilados { get; set; }

    public bool? BolSretornoTransfer { get; set; }

    public bool? BolStransaccionesCripto { get; set; }

    public bool? BolSactivo { get; set; }

    public DateOnly? FecSinicioOper { get; set; }

    public decimal? DblThonorario { get; set; }

    public decimal? DblTcostoOperatorio { get; set; }

    public bool? BolTbaseTotal { get; set; }

    public bool? BolTbaseSubtotal { get; set; }

    public bool? BolTbaseRetorno { get; set; }

    public bool? BolTprovision { get; set; }

    public bool? BolTretornoEfe { get; set; }

    public bool? BolTbanca { get; set; }

    public bool? BolTconsig { get; set; }

    public bool? BolTretornoMonederos { get; set; }

    public bool? BolTretornoDispNomina { get; set; }

    public bool? BolTretornoAsimilados { get; set; }

    public bool? BolTretornoSindicato { get; set; }

    public bool? BolTtransaccionesCripto { get; set; }

    public bool? BolTtactivo { get; set; }

    public DateOnly? FecTinicioOper { get; set; }

    public bool? BolNprovision { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? TxtBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtMarca { get; set; }

    public string? TxtDomicilio { get; set; }

    public decimal? DblInHon { get; set; }
}
