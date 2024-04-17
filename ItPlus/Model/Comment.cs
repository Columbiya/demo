using System;
using System.Collections.Generic;

namespace ItPlus.Model;

public partial class Comment
{
    public int Idcomments { get; set; }

    public string Text { get; set; } = null!;

    public int Request { get; set; }

    public int Author { get; set; }

    public virtual User AuthorNavigation { get; set; } = null!;

    public virtual Request RequestNavigation { get; set; } = null!;
}
