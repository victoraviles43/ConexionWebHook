using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbContacto
{
    public int IntIdContacto { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellido { get; set; }

    public string? TxtTelefono { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtComplemento { get; set; }

    public string? TxtCodigoPostal { get; set; }

    public string? TxtEmail { get; set; }
}
