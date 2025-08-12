using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class MedicalRecord
{
    public int RecordId { get; set; }

    public int? StudentId { get; set; }

    public string? Allergies { get; set; }

    public string? ChronicDisease { get; set; }

    public bool? Vision { get; set; }

    public bool? Hearing { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Height { get; set; }

    public DateOnly? LastUpdate { get; set; }

    public int? CreateBy { get; set; }

    public string? Note { get; set; }

    public virtual Student? Student { get; set; }
}
