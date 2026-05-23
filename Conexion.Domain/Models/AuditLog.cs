using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class AuditLog
{
    public long AuditId { get; set; }

    public DateTime OccurredAtUtc { get; set; }

    public string Action { get; set; } = null!;

    public string Entity { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public int ActorUserId { get; set; }

    public string? RequestId { get; set; }

    public string? Ip { get; set; }

    public string? UserAgent { get; set; }

    public string? Reason { get; set; }

    public string? Extra { get; set; }

    public virtual ICollection<AuditLogChange> AuditLogChanges { get; set; } = new List<AuditLogChange>();
}
