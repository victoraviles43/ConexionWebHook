using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbModificacione
{
    public int IntIdModifica { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtTabla { get; set; }

    public string? TxtModificaciones { get; set; }

    public int? IntIdUsuario { get; set; }
}
