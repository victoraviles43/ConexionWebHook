using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoFp
{
    public int LngIdProductoFp { get; set; }

    public int LngIdProductoGral { get; set; }

    public decimal? DblChonorario { get; set; }

    public decimal? DblChonorarioTe { get; set; }

    public decimal? DblChonorarioTpv { get; set; }

    public decimal? DblCcostoOperativo { get; set; }

    public bool? BolCtotal { get; set; }

    public bool? BolCsubtotal { get; set; }

    public bool? BolCretorno { get; set; }

    public bool? BolCprovision { get; set; }

    public bool? BolCretornoEfe { get; set; }

    public bool? BolCfacturacion { get; set; }

    public bool? BolCconsig { get; set; }

    public bool? BolCdn { get; set; }

    public bool? BolCmon { get; set; }

    public bool? BolCasim { get; set; }

    public bool? BolCsindicato { get; set; }

    public bool? BolCtsimples { get; set; }

    public bool? BolCtcripto { get; set; }

    public bool? BolCactivo { get; set; }

    public DateOnly? FecCinicioOper { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? TxtBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? NumTerminales { get; set; }

    public string? TxtMarca { get; set; }

    public string? NumTerminalR { get; set; }

    public string? TxtMarcaR { get; set; }

    public decimal? DblImporteOperar { get; set; }

    public bool? BolServicio { get; set; }

    public bool? BolSuministro { get; set; }

    public bool? BolRenta { get; set; }

    public bool? BolImpresion { get; set; }

    public decimal? DblLphonorario { get; set; }

    public decimal? DblLpcostoOperativo { get; set; }

    public bool? BolLptotal { get; set; }

    public bool? BolLpsubtotal { get; set; }

    public bool? BolLpretorno { get; set; }

    public bool? BolLpprovision { get; set; }

    public bool? BolLpretornoEfe { get; set; }

    public bool? BolLpfacturacion { get; set; }

    public bool? BolLpconsig { get; set; }

    public bool? BolLpdn { get; set; }

    public bool? BolLpmon { get; set; }

    public bool? BolLpasim { get; set; }

    public bool? BolLpsindicato { get; set; }

    public bool? BolLptsimples { get; set; }

    public bool? BolLptcripto { get; set; }

    public bool? BolLpactivo { get; set; }

    public DateOnly? FecLpinicioOper { get; set; }

    public decimal? DblAehonorario { get; set; }

    public decimal? DblAecostoOperativo { get; set; }

    public bool? BolAetotal { get; set; }

    public bool? BolAesubtotal { get; set; }

    public bool? BolAeretorno { get; set; }

    public bool? BolAeprovision { get; set; }

    public bool? BolAeretornoEfe { get; set; }

    public bool? BolAebanca { get; set; }

    public bool? BolAeconsig { get; set; }

    public bool? BolAedn { get; set; }

    public bool? BolAemon { get; set; }

    public bool? BolAeasim { get; set; }

    public bool? BolAesindicato { get; set; }

    public bool? BolAetsimples { get; set; }

    public bool? BolAetcripto { get; set; }

    public bool? BolAeactivo { get; set; }

    public DateOnly? FecAeinicioOper { get; set; }

    public decimal? DblCconHonorario { get; set; }

    public decimal? DblCconCostoOperativo { get; set; }

    public bool? BolCconTotal { get; set; }

    public bool? BolCconSubtotal { get; set; }

    public bool? BolCconRetorno { get; set; }

    public bool? BolCconProvision { get; set; }

    public bool? BolCconRetornoEfe { get; set; }

    public bool? BolCconFacturacion { get; set; }

    public bool? BolCconConsig { get; set; }

    public bool? BolCconDn { get; set; }

    public bool? BolCconMon { get; set; }

    public bool? BolCconAsim { get; set; }

    public bool? BolCconSindicato { get; set; }

    public bool? BolCconTsimples { get; set; }

    public bool? BolCconTcripto { get; set; }

    public bool? BolCconActivo { get; set; }

    public DateOnly? FecCconInicioOper { get; set; }

    public decimal? DblInHon { get; set; }
}
