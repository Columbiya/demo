using System;
using System.Collections.Generic;

namespace ItPlus.Model;

public partial class User
{
    public int IdUsers { get; set; }

    public string Firstname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string Telephone { get; set; } = null!;

    public int Role { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Request> RequestResponseEemployeeNavigations { get; set; } = new List<Request>();

    public virtual ICollection<Request> RequestUserNavigations { get; set; } = new List<Request>();

    public virtual Role RoleNavigation { get; set; } = null!;
    public string Fio { get { return $"{Firstname} {Name} {Patronymic}"; } }
}
