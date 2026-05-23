using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCostoOperacional
{
    public int LngIdCostoOperacional { get; set; }

    public int? LngIdflujo { get; set; }

    public decimal? DblCostoOper { get; set; }

    public decimal? DblComisionBase { get; set; }

    public decimal? DblUnidadCec { get; set; }

    public decimal? DblCorporativo { get; set; }

    public decimal? DblGastoCec { get; set; }

    public decimal? DblPlaza { get; set; }

    public DateTime? FecDia { get; set; }

    public decimal? DblComisionCom { get; set; }

    public int? IntIdEmpresa { get; set; }
}
