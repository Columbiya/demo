using System;
using System.Collections.Generic;

namespace ItPlus.Model;

public partial class RequestStatus
{
    public int IdrequestStatus { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
