using System;
using System.Collections.Generic;

namespace ItPlus.Model;

public partial class DeviceType
{
    public int IdType { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
