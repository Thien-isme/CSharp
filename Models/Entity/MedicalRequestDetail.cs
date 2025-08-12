using System;
using System.Collections.Generic;

namespace healthcareProject.Models.Entity;

public partial class MedicalRequestDetail
{
    public int DetailId { get; set; }

    public string? MedicationName { get; set; }

    public int? Quantity { get; set; }

    public string? Type { get; set; }

    public string? MienKhac { get; set; }

    public string? TimeSchedule { get; set; }

    public string? Status { get; set; }

    public int? RequestId { get; set; }

    public string? Note { get; set; }

    public virtual MedicalRequest? Request { get; set; }
}
