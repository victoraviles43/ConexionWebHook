using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbContactoPlaza
{
    public int IntIdContactoPlaza { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApellido { get; set; }

    public string? TxtTelefono { get; set; }

    public int? IntIdPlaza { get; set; }
}
