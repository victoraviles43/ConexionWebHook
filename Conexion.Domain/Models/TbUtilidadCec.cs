using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbUtilidadCec
{
    public int LngIdUltilidaCec { get; set; }

    public decimal? DblNominaMin { get; set; }

    public decimal? DblNominaMax { get; set; }

    public decimal? DblImpuestoMin { get; set; }

    public decimal? DblImpuestoMax { get; set; }

    public decimal? DblCostoSocialMin { get; set; }

    public decimal? DblCostoSocialMax { get; set; }

    public decimal? DblUtilidadGasMin { get; set; }

    public decimal? DblUtilidadGasMax { get; set; }

    public decimal? DblPasivoMin { get; set; }

    public decimal? DblPasivoMax { get; set; }

    public decimal? DblComsinMin { get; set; }

    public decimal? DblComsinMax { get; set; }

    public decimal? DblEventerMin { get; set; }

    public decimal? DblEventerMax { get; set; }

    public decimal? DblAginalCorMin { get; set; }

    public decimal? DblAginalCorMax { get; set; }

    public decimal? DblCtmmin { get; set; }

    public decimal? DblCtmmax { get; set; }

    public decimal? DblRentas { get; set; }

    public decimal? DblCostosEst { get; set; }

    public decimal? DblComBan { get; set; }

    public decimal? DblOtrosGastos { get; set; }

    public decimal? DblProvCorpo { get; set; }

    public decimal? DblProvUtilidad { get; set; }

    public int? IntIdOperacion { get; set; }
}
