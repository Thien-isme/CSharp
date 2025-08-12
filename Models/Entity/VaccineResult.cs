using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class VaccineResult
{
    public int ResultId { get; set; }

    public int? VaccineFormId { get; set; }

    public string? Reaction { get; set; }

    public string? ActionsTaken { get; set; }

    public string? Note { get; set; }

    public int? StudentId { get; set; }

    public int? NurseId { get; set; }

    public bool? IsInjected { get; set; }

    public virtual VaccineForm? VaccineForm { get; set; }
}
