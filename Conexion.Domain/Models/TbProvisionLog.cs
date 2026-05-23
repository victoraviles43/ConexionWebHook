using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProvisionLog
{
    public int LngIdProvisionLog { get; set; }

    public int LngIdProvision { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdflujo { get; set; }

    public decimal? DblComisionCom { get; set; }

    public decimal? DblUtilidadcec { get; set; }

    public decimal? DblNomina { get; set; }

    public decimal? DblImpuesto { get; set; }

    public decimal? DblCostoSocial { get; set; }

    public decimal? DblUtilidadGas { get; set; }

    public decimal? DblPasivo { get; set; }

    public bool? BolAplica { get; set; }

    public decimal? DblComsin { get; set; }

    public decimal? DblEventer { get; set; }

    public decimal? DblAginalCor { get; set; }

    public decimal? DblCtm { get; set; }

    public int? IntIdEmpresa { get; set; }

    public decimal? DblRentas { get; set; }

    public decimal? DblCostosEst { get; set; }

    public decimal? DblComBan { get; set; }

    public decimal? DblOtrosGastos { get; set; }

    public decimal? DblProvCorpo { get; set; }

    public decimal? DblProvUtilidad { get; set; }

    public decimal? DblNomProv { get; set; }

    public decimal? DblImpProv { get; set; }

    public decimal? DblSocProv { get; set; }

    public decimal? DblSinProv { get; set; }
}
