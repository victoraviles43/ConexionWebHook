using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbBeneficiario
{
    public int LngIdBeneficiario { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtNomCorto { get; set; }
}
