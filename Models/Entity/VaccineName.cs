using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class VaccineName
{
    public int VaccineId { get; set; }

    public string? VaccineName1 { get; set; }

    public string? Manufacture { get; set; }

    public int? AgeFrom { get; set; }

    public int? AgeTo { get; set; }

    public int? TotalUnit { get; set; }

    public string? Url { get; set; }

    public string? Description { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<VaccineHistory> VaccineHistories { get; set; } = new List<VaccineHistory>();
}
