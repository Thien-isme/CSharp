using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class VaccineProgram
{
    public int VaccineProgramId { get; set; }

    public string? VaccineProgramName { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? DateSendForm { get; set; }

    public string? Status { get; set; }

    public string? Location { get; set; }

    public int? NurseId { get; set; }

    public virtual User? Nurse { get; set; }

    public virtual ICollection<VaccineForm> VaccineForms { get; set; } = new List<VaccineForm>();
}
