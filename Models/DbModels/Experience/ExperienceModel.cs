using StudentLance.Enumerations;
using StudentLance.Models.Base;

namespace StudentLance.Models.DbModels.Experience
{
    public class ExperienceModel : BaseModel
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string CompanySector { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public JobType JobType { get; set; }
        public string JobDefinitionText { get; set; }
    }
}
