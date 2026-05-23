using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbInventarioHistorico
{
    public int LngIdInventarioHistorico { get; set; }

    public string? TxtUsuarioModificacion { get; set; }

    public DateTime? FecModificacion { get; set; }

    public int? LngIdInventario { get; set; }

    public int? IntIdEstatusInventario { get; set; }

    public string? TxtNombreUsuario { get; set; }

    public string? TxtApellidoUsuario { get; set; }

    public string? TxtEmail { get; set; }

    public DateTime? FecInicioAsignacion { get; set; }

    public DateTime? FecFinAsignacion { get; set; }

    public int? IntIdNegocio { get; set; }

    public int? IntIdPlazaOficina { get; set; }

    public int? IntIdArea { get; set; }

    public int? IntIdDepartamentos { get; set; }

    public int? IntIdPuesto { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? LngIdEquipoComputo { get; set; }

    public int? LngIdEquipoMovil { get; set; }

    public int? LngIdLineaTelefonica { get; set; }

    public int? LngIdEquipoMonitor { get; set; }

    public decimal? DblCostoEmail { get; set; }

    public decimal? DblTotalColaborador { get; set; }

    public string? TxtLinkResponsivaEquipoComputo { get; set; }

    public string? TxtLinkResponsivaEquipoMovil { get; set; }

    public string? TxtLinkResponsivaEquipoMonitor { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateTime? FecInicio { get; set; }
}
