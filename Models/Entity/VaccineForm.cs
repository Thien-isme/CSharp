using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class VaccineForm
{
    public int VaccineFormId { get; set; }

    public int? VaccineProgramId { get; set; }

    public int? StudentId { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? Form { get; set; }

    public string? Note { get; set; }

    public byte? IsCommitted { get; set; }

    public int? NurseId { get; set; }

    public virtual User? Nurse { get; set; }

    public virtual Student? Student { get; set; }

    public virtual VaccineProgram? VaccineProgram { get; set; }

    public virtual ICollection<VaccineResult> VaccineResults { get; set; } = new List<VaccineResult>();
}
