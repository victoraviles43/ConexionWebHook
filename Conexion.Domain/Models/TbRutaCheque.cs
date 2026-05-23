using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaCheque
{
    public int IntIdRutaCheque { get; set; }

    public int? LngIdCheques { get; set; }

    public string? TxtRutaCheque { get; set; }

    public string? TxtNombre { get; set; }

    public DateTime? FecRutaCheque { get; set; }

    public string? TxtTipoArchivo { get; set; }
}
