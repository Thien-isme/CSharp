using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Role { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<HealthCheckForm> HealthCheckForms { get; set; } = new List<HealthCheckForm>();

    public virtual ICollection<HealthCheckProgram> HealthCheckPrograms { get; set; } = new List<HealthCheckProgram>();

    public virtual ICollection<HealthCheckResult> HealthCheckResults { get; set; } = new List<HealthCheckResult>();

    public virtual ICollection<MedicalEvent> MedicalEvents { get; set; } = new List<MedicalEvent>();

    public virtual ICollection<MedicalRequest> MedicalRequestNurses { get; set; } = new List<MedicalRequest>();

    public virtual ICollection<MedicalRequest> MedicalRequestParents { get; set; } = new List<MedicalRequest>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<VaccineForm> VaccineForms { get; set; } = new List<VaccineForm>();

    public virtual ICollection<VaccineName> VaccineNames { get; set; } = new List<VaccineName>();

    public virtual ICollection<VaccineProgram> VaccinePrograms { get; set; } = new List<VaccineProgram>();
}
