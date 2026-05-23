using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPack
{
    public int LngIdPacks { get; set; }

    public decimal? NumCantidad { get; set; }

    public int? IntIdSabores { get; set; }
}
