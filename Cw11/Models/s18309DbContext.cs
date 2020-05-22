using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Cw11.Models
{
    public class s18309DbContext : DbContext
    {
        public s18309DbContext() { }
        public s18309DbContext(DbContextOptions<s18309DbContext> options) : base(options) { }


        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            //Doktorzy

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Mateusz", LastName = "Rudy", Email = "1@as.d" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Adam", LastName = "Blady", Email = "2@as.d" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Slawek", LastName = "Niebieski", Email = "3@as.d" });
            doctors.Add(new Doctor { IdDoctor = 4, FirstName = "Krzys", LastName = "Pomaranczowy", Email = "4@as.d" });
            doctors.Add(new Doctor { IdDoctor = 5, FirstName = "Wojtek", LastName = "Rozowy", Email = "5@as.d" });

            modelBuilder.Entity<Doctor>(entity =>
            {

                entity.HasKey(e => e.IdDoctor).HasName("DoctorPrimaryKey");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(100).IsRequired();
                entity.HasData(doctors);

            });

            //leki
            List<Medicament> medicaments = new List<Medicament>();

            medicaments.Add(new Medicament { IdMedicament = 1, Name = "jeden", Description = "qqqqqqqqqqq", Type = "a" });
            medicaments.Add(new Medicament { IdMedicament = 2, Name = "dwa", Description = "wwwwwwwwwwww", Type = "b" });
            medicaments.Add(new Medicament { IdMedicament = 3, Name = "trzy", Description = "eeeeeeeeeee", Type = "a" });
            medicaments.Add(new Medicament { IdMedicament = 4, Name = "cztery", Description = "rrrrrrrrr", Type = "b" });
            medicaments.Add(new Medicament { IdMedicament = 5, Name = "piec", Description = "tttttttttt", Type = "a" });

            modelBuilder.Entity<Medicament>(entity =>
            {

                entity.HasKey(e => e.IdMedicament).HasName("MedicamentPrimaryKey");
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Type).HasMaxLength(100).IsRequired();
                entity.HasData(medicaments);

            });

            //Pacjenci

            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient { FirstName = "Anna", LastName = "Kowalska", IdPatient = 1, BirthDate = DateTime.Now });
            patients.Add(new Patient { FirstName = "Angelika", LastName = "Red", IdPatient = 2, BirthDate = DateTime.Now });
            patients.Add(new Patient { FirstName = "Sylwia", LastName = "Amasde", IdPatient = 3, BirthDate = DateTime.Now });
            patients.Add(new Patient { FirstName = "Sasha", LastName = "Jakubiak", IdPatient = 4, BirthDate = DateTime.Now });
            patients.Add(new Patient { FirstName = "Renata", LastName = "Smark", IdPatient = 5, BirthDate = DateTime.Now });

            modelBuilder.Entity<Patient>(entity =>
            {

                entity.HasKey(e => e.IdPatient).HasName("PatientPrimaryKey");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();
                entity.HasData(patients);

            });

            //presc

            List<Prescription> prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddHours(1), IdPatient = 1, IdDoctor = 1 });
            prescriptions.Add(new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddHours(1), IdPatient = 2, IdDoctor = 2 });
            prescriptions.Add(new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddHours(1), IdPatient = 3, IdDoctor = 3 });
            prescriptions.Add(new Prescription { IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Now.AddHours(1), IdPatient = 4, IdDoctor = 4 });
            prescriptions.Add(new Prescription { IdPrescription = 5, Date = DateTime.Now, DueDate = DateTime.Now.AddHours(1), IdPatient = 5, IdDoctor = 5 });

            modelBuilder.Entity<Prescription>(entity =>
            {

                entity.HasKey(e => e.IdPrescription).HasName("PrescriptionPrimaryKey");
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.DueDate).IsRequired();

                entity.HasOne(e => e.Patient)
                    .WithMany(e => e.Prescriptions)
                    .HasForeignKey(e => e.IdPatient)
                    .HasConstraintName("PatientPrescription")
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Doctor)
                    .WithMany(e => e.Prescriptions)
                    .HasForeignKey(e => e.IdDoctor)
                    .HasConstraintName("DoctorPrescription")
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasData(prescriptions);

            });

            List<Prescription_Medicament> pre_medList = new List<Prescription_Medicament>();

            pre_medList.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Details = "aaaaaa" });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Details = "sssssssssss" });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 3, Details = "dddddddd" });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 4, IdPrescription = 4, Details = "ffffffffffffff", Dose = 1 });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 5, IdPrescription = 5, Details = "ggggggggggggggggggg", Dose = 1 });
            

            modelBuilder.Entity<Prescription_Medicament>(entity =>
            {

                entity.HasKey(e => new { e.IdMedicament, e.IdPrescription });
                entity.Property(e => e.Details).HasMaxLength(100).IsRequired();

                entity.HasOne(e => e.Medicament)
                    .WithMany(e => e.PrescriptionMedicaments)
                    .HasForeignKey(e => e.IdMedicament)
                    .HasConstraintName("MedicamentWithPrescriptionMedicament")
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Prescription)
                    .WithMany(e => e.PrescriptionMedicaments)
                    .HasForeignKey(e => e.IdPrescription)
                    .HasConstraintName("PrescriptionWithPrescriptionMedicament")
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasData(pre_medList);

            });



        }
    }
}
