using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class MedicalEvent
{
    public int EventId { get; set; }

    public string? TypeEvent { get; set; }

    public DateOnly? EventDate { get; set; }

    public string? Description { get; set; }

    public string? ActionsTaken { get; set; }

    public string? Level { get; set; }

    public string? Location { get; set; }

    public int? StudentId { get; set; }

    public int? NurseId { get; set; }

    public virtual User? Nurse { get; set; }

    public virtual Student? Student { get; set; }
}
