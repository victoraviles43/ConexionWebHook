using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbPaqPack
{
    public int LngIdPaqPack { get; set; }

    public int? LngIdPaquete { get; set; }

    public int? LngIdPacks { get; set; }
}
