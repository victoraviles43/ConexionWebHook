using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbContactos03
{
    public Guid LngIdContacto { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellidoPaterno { get; set; }

    public string? TxtApellidoMaterno { get; set; }

    public Guid? IntIdPuesto { get; set; }

    public Guid? IntIdFacultado { get; set; }

    public string? TxtTelefone { get; set; }

    public string? TxtExtension { get; set; }

    public Guid? LngIdCliente { get; set; }

    public bool? BolCongelar { get; set; }
}
