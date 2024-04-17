using System;
using System.Collections.Generic;

namespace ItPlus.Model;

public partial class Request
{
    public int IdRequest { get; set; }

    public DateTime DateAdd { get; set; }

    public int DeviceType { get; set; }

    public string ModelDevice { get; set; } = null!;

    public string? DescriptionProblem { get; set; }

    public int Status { get; set; }

    public int User { get; set; }

    public int? ResponseEemployee { get; set; }

    public DateTime? DateEnd { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual DeviceType DeviceTypeNavigation { get; set; } = null!;

    public virtual User? ResponseEemployeeNavigation { get; set; }

    public virtual RequestStatus StatusNavigation { get; set; } = null!;

    public virtual User UserNavigation { get; set; } = null!;
}
