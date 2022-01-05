using StudentLance.Models.Base;
using StudentLance.Models.DbModels.Education;
using StudentLance.Models.DbModels.Experience;

namespace StudentLance.Models.DbModels.CurriculumVitae
{
    public class CurriculumVitaeModel : BaseModel
    {
        public string SummaryText { get; set; }
        public string HobbiesAndInterestsText { get; set; }
        public List<ExperienceModel> Experiences { get; set; }
        public List<EducationModel> Educations { get; set; }
    }
}
