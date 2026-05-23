using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbHistorico
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Hora { get; set; }

    public string? Banco { get; set; }

    public bool? Registrado { get; set; }

    public string? Cuenta { get; set; }
}
