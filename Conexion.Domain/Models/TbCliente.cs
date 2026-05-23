using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCliente
{
    public Guid LngIdCliente { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellidos { get; set; }

    public string? TxtCelular { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtRfc { get; set; }

    public string? TxtEmail { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateOnly? FecAlta { get; set; }

    public DateOnly? FecBaja { get; set; }

    public int? IntIdStatusCli { get; set; }

    public string? TxtNombreEmpresa { get; set; }

    public Guid? IntIdTipoCliente { get; set; }

    public string? TxtRegistro { get; set; }

    public int? IntIdCliente { get; set; }

    public bool? BolCongelar { get; set; }
}
