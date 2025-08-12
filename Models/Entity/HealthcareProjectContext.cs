using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace healthcareProject.Models.Entity;

public partial class HealthcareProjectContext : DbContext
{
    public HealthcareProjectContext()
    {
    }

    public HealthcareProjectContext(DbContextOptions<HealthcareProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<HealthCheckForm> HealthCheckForms { get; set; }

    public virtual DbSet<HealthCheckProgram> HealthCheckPrograms { get; set; }

    public virtual DbSet<HealthCheckResult> HealthCheckResults { get; set; }

    public virtual DbSet<MedicalEvent> MedicalEvents { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<MedicalRequest> MedicalRequests { get; set; }

    public virtual DbSet<MedicalRequestDetail> MedicalRequestDetails { get; set; }

    public virtual DbSet<ParticipateClass> ParticipateClasses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VaccineForm> VaccineForms { get; set; }

    public virtual DbSet<VaccineHistory> VaccineHistories { get; set; }

    public virtual DbSet<VaccineName> VaccineNames { get; set; }

    public virtual DbSet<VaccineProgram> VaccinePrograms { get; set; }

    public virtual DbSet<VaccineResult> VaccineResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=HealthcareProject;User Id=sa;Password=12345;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__7577345E57DF2A09");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("classID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .HasColumnName("className");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TeacherName)
                .HasMaxLength(100)
                .HasColumnName("teacherName");
        });

        modelBuilder.Entity<HealthCheckForm>(entity =>
        {
            entity.HasKey(e => e.HealthCheckFormId).HasName("PK__HealthCh__0AB7A6540C6E47BE");

            entity.ToTable("HealthCheckForm");

            entity.Property(e => e.HealthCheckFormId)
                .ValueGeneratedNever()
                .HasColumnName("healthCheckFormID");
            entity.Property(e => e.ExpDate).HasColumnName("expDate");
            entity.Property(e => e.Form)
                .HasMaxLength(500)
                .HasColumnName("form");
            entity.Property(e => e.HealthCheckProgramId).HasColumnName("healthCheckProgramID");
            entity.Property(e => e.IsCommitted).HasColumnName("isCommitted");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.StudentId).HasColumnName("studentID");

            entity.HasOne(d => d.HealthCheckProgram).WithMany(p => p.HealthCheckForms)
                .HasForeignKey(d => d.HealthCheckProgramId)
                .HasConstraintName("FK__HealthChe__healt__24285DB4");

            entity.HasOne(d => d.Nurse).WithMany(p => p.HealthCheckForms)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__HealthChe__nurse__2610A626");

            entity.HasOne(d => d.Student).WithMany(p => p.HealthCheckForms)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__HealthChe__stude__251C81ED");
        });

        modelBuilder.Entity<HealthCheckProgram>(entity =>
        {
            entity.HasKey(e => e.HealthCheckProgramId).HasName("PK__HealthCh__FBA86D180FB9068B");

            entity.ToTable("HealthCheckProgram");

            entity.Property(e => e.HealthCheckProgramId)
                .ValueGeneratedNever()
                .HasColumnName("healthCheckProgramID");
            entity.Property(e => e.DateSendForm).HasColumnName("dateSendForm");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.HealthCheckName)
                .HasMaxLength(100)
                .HasColumnName("healthCheckName");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("location");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.QtsHoanThanh)
                .HasMaxLength(50)
                .HasColumnName("qts_Hoan_thanh");
            entity.Property(e => e.StartDate).HasColumnName("startDate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.Nurse).WithMany(p => p.HealthCheckPrograms)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__HealthChe__nurse__214BF109");
        });

        modelBuilder.Entity<HealthCheckResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__HealthCh__C6EADC7B9E7A0361");

            entity.ToTable("HealthCheckResult");

            entity.Property(e => e.ResultId)
                .ValueGeneratedNever()
                .HasColumnName("resultID");
            entity.Property(e => e.BloodPressure).HasMaxLength(50);
            entity.Property(e => e.GeneralCondition).HasMaxLength(100);
            entity.Property(e => e.HealthCheckFormId).HasColumnName("healthCheckFormID");
            entity.Property(e => e.Hearing).HasColumnName("hearing");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("height");
            entity.Property(e => e.IsChecked).HasColumnName("isChecked");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.Vision).HasColumnName("vision");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.HealthCheckForm).WithMany(p => p.HealthCheckResults)
                .HasForeignKey(d => d.HealthCheckFormId)
                .HasConstraintName("FK__HealthChe__healt__28ED12D1");

            entity.HasOne(d => d.Nurse).WithMany(p => p.HealthCheckResults)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__HealthChe__nurse__29E1370A");
        });

        modelBuilder.Entity<MedicalEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__MedicalE__2DC7BD6987061B94");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("eventID");
            entity.Property(e => e.ActionsTaken)
                .HasMaxLength(500)
                .HasColumnName("actionsTaken");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.EventDate).HasColumnName("eventDate");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .HasColumnName("level");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.TypeEvent)
                .HasMaxLength(50)
                .HasColumnName("type_event");

            entity.HasOne(d => d.Nurse).WithMany(p => p.MedicalEvents)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__MedicalEv__nurse__477199F1");

            entity.HasOne(d => d.Student).WithMany(p => p.MedicalEvents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__MedicalEv__stude__467D75B8");
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK__MedicalR__D825197EF2AF0B43");

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasColumnName("recordID");
            entity.Property(e => e.Allergies)
                .HasMaxLength(200)
                .HasColumnName("allergies");
            entity.Property(e => e.ChronicDisease)
                .HasMaxLength(200)
                .HasColumnName("chronicDisease");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.Hearing).HasColumnName("hearing");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("height");
            entity.Property(e => e.LastUpdate).HasColumnName("lastUpdate");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.Vision).HasColumnName("vision");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.Student).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__MedicalRe__stude__42ACE4D4");
        });

        modelBuilder.Entity<MedicalRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK__MedicalR__E3C5DE51FC7E3842");

            entity.ToTable("MedicalRequest");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("requestID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Image)
                .HasMaxLength(200)
                .HasColumnName("image");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.ParentId).HasColumnName("parentID");
            entity.Property(e => e.ReasonRejected)
                .HasMaxLength(500)
                .HasColumnName("reason_rejected");
            entity.Property(e => e.RequestName)
                .HasMaxLength(100)
                .HasColumnName("requestName");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("studentID");

            entity.HasOne(d => d.Nurse).WithMany(p => p.MedicalRequestNurses)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__MedicalRe__nurse__4D2A7347");

            entity.HasOne(d => d.Parent).WithMany(p => p.MedicalRequestParents)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__MedicalRe__paren__4C364F0E");

            entity.HasOne(d => d.Student).WithMany(p => p.MedicalRequests)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__MedicalRe__stude__4B422AD5");
        });

        modelBuilder.Entity<MedicalRequestDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK__MedicalR__830778395244AF01");

            entity.ToTable("MedicalRequestDetail");

            entity.Property(e => e.DetailId)
                .ValueGeneratedNever()
                .HasColumnName("detailID");
            entity.Property(e => e.MedicationName)
                .HasMaxLength(100)
                .HasColumnName("medicationName");
            entity.Property(e => e.MienKhac)
                .HasMaxLength(50)
                .HasColumnName("mien_khac");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.RequestId).HasColumnName("requestID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TimeSchedule)
                .HasMaxLength(50)
                .HasColumnName("time_schedule");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.Request).WithMany(p => p.MedicalRequestDetails)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__MedicalRe__reque__5006DFF2");
        });

        modelBuilder.Entity<ParticipateClass>(entity =>
        {
            entity.HasKey(e => e.ParticipateClassId).HasName("PK__Particip__C676A1486E1C5304");

            entity.ToTable("ParticipateClass");

            entity.Property(e => e.ParticipateClassId)
                .ValueGeneratedNever()
                .HasColumnName("participateClassID");
            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.ProgramId).HasColumnName("programID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");

            entity.HasOne(d => d.Class).WithMany(p => p.ParticipateClasses)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Participa__class__2F9A1060");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__4D11D65C73E1DBF6");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("studentID");
            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.ParentId).HasColumnName("parentID");
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .HasColumnName("studentName");

            entity.HasOne(d => d.Class).WithMany(p => p.Students)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK__Student__classID__1D7B6025");

            entity.HasOne(d => d.Parent).WithMany(p => p.Students)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__Student__parentI__1E6F845E");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CDF09333779");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("fullName");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
        });

        modelBuilder.Entity<VaccineForm>(entity =>
        {
            entity.HasKey(e => e.VaccineFormId).HasName("PK__VaccineF__D205F744B4F0C445");

            entity.ToTable("VaccineForm");

            entity.Property(e => e.VaccineFormId)
                .ValueGeneratedNever()
                .HasColumnName("vaccineFormID");
            entity.Property(e => e.ExpDate).HasColumnName("expDate");
            entity.Property(e => e.Form)
                .HasMaxLength(500)
                .HasColumnName("form");
            entity.Property(e => e.IsCommitted).HasColumnName("isCommitted");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.VaccineProgramId).HasColumnName("vaccineProgramID");

            entity.HasOne(d => d.Nurse).WithMany(p => p.VaccineForms)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__VaccineFo__nurse__39237A9A");

            entity.HasOne(d => d.Student).WithMany(p => p.VaccineForms)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__VaccineFo__stude__382F5661");

            entity.HasOne(d => d.VaccineProgram).WithMany(p => p.VaccineForms)
                .HasForeignKey(d => d.VaccineProgramId)
                .HasConstraintName("FK__VaccineFo__vacci__373B3228");
        });

        modelBuilder.Entity<VaccineHistory>(entity =>
        {
            entity.HasKey(e => e.VaccineHistoryId).HasName("PK__VaccineH__50DEF8F11F781F1F");

            entity.ToTable("VaccineHistory");

            entity.Property(e => e.VaccineHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("vaccineHistoryID");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.Unit).HasColumnName("unit");
            entity.Property(e => e.VaccineId).HasColumnName("vaccineID");

            entity.HasOne(d => d.Student).WithMany(p => p.VaccineHistories)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__VaccineHi__stude__3CF40B7E");

            entity.HasOne(d => d.Vaccine).WithMany(p => p.VaccineHistories)
                .HasForeignKey(d => d.VaccineId)
                .HasConstraintName("FK__VaccineHi__vacci__3BFFE745");
        });

        modelBuilder.Entity<VaccineName>(entity =>
        {
            entity.HasKey(e => e.VaccineId).HasName("PK__VaccineN__C1ED3DD5F18C1CFC");

            entity.ToTable("VaccineName");

            entity.Property(e => e.VaccineId)
                .ValueGeneratedNever()
                .HasColumnName("vaccineID");
            entity.Property(e => e.AgeFrom).HasColumnName("ageFrom");
            entity.Property(e => e.AgeTo).HasColumnName("ageTo");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Manufacture)
                .HasMaxLength(100)
                .HasColumnName("manufacture");
            entity.Property(e => e.TotalUnit).HasColumnName("totalUnit");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("url");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.VaccineName1)
                .HasMaxLength(100)
                .HasColumnName("vaccineName");

            entity.HasOne(d => d.User).WithMany(p => p.VaccineNames)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__VaccineNa__userI__336AA144");
        });

        modelBuilder.Entity<VaccineProgram>(entity =>
        {
            entity.HasKey(e => e.VaccineProgramId).HasName("PK__VaccineP__23F06698551386BF");

            entity.ToTable("VaccineProgram");

            entity.Property(e => e.VaccineProgramId)
                .ValueGeneratedNever()
                .HasColumnName("vaccineProgramID");
            entity.Property(e => e.DateSendForm).HasColumnName("dateSendForm");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("location");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.StartDate).HasColumnName("startDate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.VaccineProgramName)
                .HasMaxLength(100)
                .HasColumnName("vaccineProgramName");

            entity.HasOne(d => d.Nurse).WithMany(p => p.VaccinePrograms)
                .HasForeignKey(d => d.NurseId)
                .HasConstraintName("FK__VaccinePr__nurse__2CBDA3B5");
        });

        modelBuilder.Entity<VaccineResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__VaccineR__C6EADC7BDC7EEF17");

            entity.ToTable("VaccineResult");

            entity.Property(e => e.ResultId)
                .ValueGeneratedNever()
                .HasColumnName("resultID");
            entity.Property(e => e.ActionsTaken).HasMaxLength(500);
            entity.Property(e => e.IsInjected).HasColumnName("isInjected");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.NurseId).HasColumnName("nurseID");
            entity.Property(e => e.Reaction)
                .HasMaxLength(500)
                .HasColumnName("reaction");
            entity.Property(e => e.StudentId).HasColumnName("studentID");
            entity.Property(e => e.VaccineFormId).HasColumnName("vaccineFormID");

            entity.HasOne(d => d.VaccineForm).WithMany(p => p.VaccineResults)
                .HasForeignKey(d => d.VaccineFormId)
                .HasConstraintName("FK__VaccineRe__vacci__3FD07829");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
