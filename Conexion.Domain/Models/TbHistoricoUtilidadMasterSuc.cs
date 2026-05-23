using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHistoricoUtilidadMasterSuc
{
    public int? IdRegistro { get; set; }

    public decimal? DblValorMoneda { get; set; }

    public decimal? DblPesos { get; set; }

    public decimal? DblCompra { get; set; }

    public decimal? DblLucro { get; set; }

    public string? TxtSucursal { get; set; }

    public DateTime? FecDia { get; set; }
}
