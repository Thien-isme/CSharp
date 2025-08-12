using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class MedicalRequest
{
    public int RequestId { get; set; }

    public string? RequestName { get; set; }

    public DateOnly? Date { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? ReasonRejected { get; set; }

    public int? StudentId { get; set; }

    public int? ParentId { get; set; }

    public int? NurseId { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<MedicalRequestDetail> MedicalRequestDetails { get; set; } = new List<MedicalRequestDetail>();

    public virtual User? Nurse { get; set; }

    public virtual User? Parent { get; set; }

    public virtual Student? Student { get; set; }
}
