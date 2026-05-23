using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class AuditLogChange
{
    public long ChangeId { get; set; }

    public long AuditId { get; set; }

    public string Field { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? DataType { get; set; }

    public virtual AuditLog Audit { get; set; } = null!;
}
