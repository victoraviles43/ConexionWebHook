using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbControlActivo
{
    public int LngIdActivo { get; set; }

    public string? TxtUsuario { get; set; }

    public string? TxtNombreActivo { get; set; }

    public string? TxtMarcaModeloActivo { get; set; }

    public string? TxtDescripcionActivo { get; set; }

    public int? IntIdCondicionActivo { get; set; }

    public string? TxtObservacionesCondicionActivo { get; set; }

    public int? IntIdEstadoActivo { get; set; }

    public int? IntIdCiudad { get; set; }

    public int? IntIdOficinaActivo { get; set; }

    public int? IntIdUbicacionActivo { get; set; }

    public string? TxtEtiquetado { get; set; }

    public string? TxtLugarEtiquetado { get; set; }

    public int? IntIdEstatusActivo { get; set; }

    public decimal? DblPrecio { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public string? TxtUsuarioUltimaModificacion { get; set; }

    public DateTime? FecUltimaModificacion { get; set; }
}
