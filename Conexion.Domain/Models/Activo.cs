using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class Activo
{
    public string? TxtUsuario { get; set; }

    public string? TxtNombreActivo { get; set; }

    public string? TxtMarcaModeloActivo { get; set; }

    public string? TxtDescripcionActivo { get; set; }

    public double? IntIdCondicionActivo { get; set; }

    public string? XtObservacionesCondicionActivo { get; set; }

    public double? IntIdEstadoActivo { get; set; }

    public double? IntIdCiudad { get; set; }

    public double? IntIdOficinaActivo { get; set; }

    public double? IntIdUbicacionActivo { get; set; }

    public string? TxtEtiquetado { get; set; }

    public string? TxtLugarEtiquetado { get; set; }

    public double? IntIdEstatusActivo { get; set; }

    public double? FecInicio { get; set; }

    public string? FecFin { get; set; }

    public string? TxtUsuarioUltimaModificacion { get; set; }

    public string? FecUltimaModificacion { get; set; }
}
