using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class HealthCheckResult
{
    public int ResultId { get; set; }

    public int? HealthCheckFormId { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public bool? Hearing { get; set; }

    public bool? Vision { get; set; }

    public bool? DentStatus { get; set; }

    public string? BloodPressure { get; set; }

    public int? HeartRate { get; set; }

    public string? GeneralCondition { get; set; }

    public bool? IsChecked { get; set; }

    public int? NurseId { get; set; }

    public virtual HealthCheckForm? HealthCheckForm { get; set; }

    public virtual User? Nurse { get; set; }
}
