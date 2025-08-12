using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class ParticipateClass
{
    public int ParticipateClassId { get; set; }

    public int? ClassId { get; set; }

    public int? ProgramId { get; set; }

    public string? Type { get; set; }

    public virtual Class? Class { get; set; }
}
