using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEquiposComputo
{
    public int LngIdEquipoComputo { get; set; }

    public int? IntIdEstatusAsignacion { get; set; }

    public int? IntIdOficina { get; set; }

    public string? TxtMarcaComputo { get; set; }

    public string? TxtModeloComputo { get; set; }

    public int? IntIdGamaHardware { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdNegocio { get; set; }

    public string? TxtSerieComputo { get; set; }

    public string? TxtContrato { get; set; }

    public DateTime? FecInicioContrato { get; set; }

    public DateTime? FecFinContrato { get; set; }

    public decimal? DblPlazo { get; set; }

    public decimal? DblRenta { get; set; }

    public decimal? DblSeguro { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? DblTotalDiasContrato { get; set; }

    public decimal? DblTotalDiasRestantes { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateTime? FecInicio { get; set; }
}
