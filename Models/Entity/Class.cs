using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class Class
{
    public int ClassId { get; set; }

    public string? TeacherName { get; set; }

    public string? ClassName { get; set; }

    public int? Quantity { get; set; }

    public virtual ICollection<ParticipateClass> ParticipateClasses { get; set; } = new List<ParticipateClass>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
