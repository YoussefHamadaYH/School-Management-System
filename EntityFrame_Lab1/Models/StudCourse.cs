using System;
using System.Collections.Generic;

namespace EntityFrame_Lab1.Models;

public partial class StudCourse
{
    public int CrsId { get; set; }

    public int StId { get; set; }

    public int? Grade { get; set; }

    public virtual Course Crs { get; set; } = null!;

    public virtual Student St { get; set; } = null!;
}
