using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpenPayCustomer
{
    public int LngIdCustomer { get; set; }

    public int LngIdCharge { get; set; }

    public string? TxtCustomerName { get; set; }

    public string? TxtCustomerLastName { get; set; }

    public string? TxtCustomerEmail { get; set; }

    public string? TxtCustomerPhoneNumber { get; set; }

    public string? TxtCustomerAddress { get; set; }

    public DateTime? FecCustomerCreationDate { get; set; }

    public string? TxtCustomerExternalId { get; set; }

    public string? TxtCustomerClabe { get; set; }

    public virtual TbOpenPayCharge LngIdChargeNavigation { get; set; } = null!;
}
