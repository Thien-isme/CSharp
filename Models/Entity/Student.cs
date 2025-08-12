using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public int? ClassId { get; set; }

    public int? ParentId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<HealthCheckForm> HealthCheckForms { get; set; } = new List<HealthCheckForm>();

    public virtual ICollection<MedicalEvent> MedicalEvents { get; set; } = new List<MedicalEvent>();

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual ICollection<MedicalRequest> MedicalRequests { get; set; } = new List<MedicalRequest>();

    public virtual User? Parent { get; set; }

    public virtual ICollection<VaccineForm> VaccineForms { get; set; } = new List<VaccineForm>();

    public virtual ICollection<VaccineHistory> VaccineHistories { get; set; } = new List<VaccineHistory>();
}
