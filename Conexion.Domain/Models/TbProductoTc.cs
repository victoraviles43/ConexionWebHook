using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbProductoTc
{
    public int LngIdProductoTc { get; set; }

    public int LngIdProductoGral { get; set; }

    public decimal? DblMhonorarios { get; set; }

    public decimal? DblMcostoOperativo { get; set; }

    public bool? BolMtotal { get; set; }

    public bool? BolMsubtotal { get; set; }

    public bool? BolMretorno { get; set; }

    public bool? BolMprovision { get; set; }

    public bool? BolMbanca { get; set; }

    public bool? BolMconsg { get; set; }

    public bool? BolMdn { get; set; }

    public bool? BolMtcripto { get; set; }

    public bool? BolMactivo { get; set; }

    public DateOnly? FecMinicioOper { get; set; }

    public bool? BolReqCapa { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public string? TxtBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? NumTarjetas { get; set; }

    public string? TxtMarca { get; set; }

    public string? TxtDomicilio { get; set; }

    public decimal? DblImporteOperar { get; set; }

    public string? TxtPeriodicidad { get; set; }

    public bool? BolNoAplica { get; set; }

    public bool? BolParcialidad { get; set; }

    public bool? BolPagoUnico { get; set; }

    public bool? BolPagadas { get; set; }

    public int? IntIdCapacitador { get; set; }

    public DateOnly? FecRecibe { get; set; }

    public string? TxtRecibe { get; set; }

    public string? TxtObservaciones { get; set; }

    public decimal? DblInHon { get; set; }
}
