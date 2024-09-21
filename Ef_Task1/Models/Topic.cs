using System;
using System.Collections.Generic;

namespace Ef_Task1.Models;

public partial class Topic
{
    public int TopId { get; set; }

    public string? TopName { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
