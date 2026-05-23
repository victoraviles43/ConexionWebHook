using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocCheckList
{
    public int IntIdDocChecklist { get; set; }

    public int? IntIdChecklist { get; set; }

    public string? TxtRutaCheck { get; set; }

    public DateOnly? FecRutaCheck { get; set; }

    public int? IntIdStatusCheck { get; set; }

    public string? TxtNombre { get; set; }
}
