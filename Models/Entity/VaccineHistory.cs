using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class VaccineHistory
{
    public int VaccineHistoryId { get; set; }

    public int? VaccineId { get; set; }

    public string? Note { get; set; }

    public int? Unit { get; set; }

    public int? CreateBy { get; set; }

    public int? StudentId { get; set; }

    public virtual Student? Student { get; set; }

    public virtual VaccineName? Vaccine { get; set; }
}
