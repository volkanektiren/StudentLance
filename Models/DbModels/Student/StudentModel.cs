using StudentLance.Enumerations;
using StudentLance.Models.Base;
using StudentLance.Models.DbModels.CurriculumVitae;
using StudentLance.Models.DbModels.JobOffer;
using StudentLance.Models.DbModels.User;

namespace StudentLance.Models.DbModels.Student
{
    public class StudentModel : BaseModel
    {
        public UserModel User { get; set; }
        public EducationLevel EducationStatus { get; set; }
        public string SchoolName { get; set; }
        public List<JobOfferModel> JobOffers { get; set; }
        public CurriculumVitaeModel CurriculumVitae { get; set; }
    }
}
