using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class HealthCheckForm
{
    public int HealthCheckFormId { get; set; }

    public int? HealthCheckProgramId { get; set; }

    public int? StudentId { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? Form { get; set; }

    public string? Note { get; set; }

    public bool? IsCommitted { get; set; }

    public int? NurseId { get; set; }

    public virtual HealthCheckProgram? HealthCheckProgram { get; set; }

    public virtual ICollection<HealthCheckResult> HealthCheckResults { get; set; } = new List<HealthCheckResult>();

    public virtual User? Nurse { get; set; }

    public virtual Student? Student { get; set; }
}
