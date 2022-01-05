using Microsoft.EntityFrameworkCore;
using StudentLance.Models.DbModels.User;
using StudentLance.Models.DbModels.Student;
using StudentLance.Models.DbModels.Employer;
using StudentLance.Models.DbModels.JobOffer;
using StudentLance.Models.DbModels.CurriculumVitae;
using StudentLance.Models.DbModels.Education;
using StudentLance.Models.DbModels.Experience;

namespace StudentLance.Data
{
    public class StudentLanceDataContext : DbContext
    {
        public StudentLanceDataContext(DbContextOptions<StudentLanceDataContext> options) : base(options)
        {
        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<StudentModel> Student { get; set; }
        public DbSet<EmployerModel> Employer { get; set; }
        public DbSet<JobOfferModel> JobOffer { get; set; }
        public DbSet<CurriculumVitaeModel> CurriculumVitae { get; set; }
        public DbSet<EducationModel> Education { get; set; }
        public DbSet<ExperienceModel> Experience { get; set; }
    }
}
