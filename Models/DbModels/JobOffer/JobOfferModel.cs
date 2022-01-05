using StudentLance.Models.Base;
using StudentLance.Models.DbModels.Employer;
using StudentLance.Models.DbModels.Student;

namespace StudentLance.Models.DbModels.JobOffer
{
    public class JobOfferModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsApplicable { get; set; }
        public EmployerModel Employer { get; set; }
        public List<StudentModel> Students { get; set; }
    }
}