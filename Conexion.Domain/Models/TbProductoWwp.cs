using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoWwp
{
    public int LngIdProductoWwp { get; set; }

    public int? LngIdProductoGral { get; set; }

    public decimal? DblChonorario { get; set; }

    public decimal? DblCcostoOperativo { get; set; }

    public bool? BolCtotal { get; set; }

    public bool? BolCsubtotal { get; set; }

    public bool? BolCretorno { get; set; }

    public bool? BolCprovision { get; set; }

    public bool? BolCretornoEfe { get; set; }

    public bool? BolCfacturacion { get; set; }

    public bool? BolCconsig { get; set; }

    public bool? BolCdn { get; set; }

    public bool? BolCasim { get; set; }

    public bool? BolCsindicato { get; set; }

    public bool? BolCtsimples { get; set; }

    public bool? BolCtcripto { get; set; }

    public bool? BolCactivo { get; set; }

    public DateOnly? FecCinicioOper { get; set; }

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

    public bool? BolAeasim { get; set; }

    public bool? BolAesindicato { get; set; }

    public bool? BolAetsimples { get; set; }

    public bool? BolAetcripto { get; set; }

    public bool? BolAeactivo { get; set; }

    public DateOnly? FecAeinicioOper { get; set; }

    public decimal? DblInHon { get; set; }
}
