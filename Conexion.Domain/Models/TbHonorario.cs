using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHonorario
{
    public int LngIdHonorarios { get; set; }

    public int? LngIdflujo { get; set; }

    public int? IntIdTipoRetorno { get; set; }

    public decimal? DblPorHonorarios { get; set; }

    public decimal? DblHonorarios { get; set; }

    public decimal? DblHonorariosSind { get; set; }

    public decimal? DblSindicato { get; set; }

    public decimal? DblIngresoOtros { get; set; }

    public decimal? DblValorSerT { get; set; }

    public decimal? DblIvaFac { get; set; }

    public int? IntIdEmpresa { get; set; }
}
