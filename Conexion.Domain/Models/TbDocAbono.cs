using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDocAbono
{
    public int LngIdDocAbono { get; set; }

    public int? LngIdAbonorecurso { get; set; }

    public byte[]? ImgDoc { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtUrlImg { get; set; }
}
