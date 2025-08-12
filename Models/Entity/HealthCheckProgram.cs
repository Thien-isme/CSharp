using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class HealthCheckProgram
{
    public int HealthCheckProgramId { get; set; }

    public string? HealthCheckName { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? DateSendForm { get; set; }

    public string? Status { get; set; }

    public string? QtsHoanThanh { get; set; }

    public string? Location { get; set; }

    public int? NurseId { get; set; }

    public virtual ICollection<HealthCheckForm> HealthCheckForms { get; set; } = new List<HealthCheckForm>();

    public virtual User? Nurse { get; set; }
}
