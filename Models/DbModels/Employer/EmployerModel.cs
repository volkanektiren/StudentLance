using StudentLance.Models.Base;
using StudentLance.Models.DbModels.JobOffer;
using StudentLance.Models.DbModels.User;

namespace StudentLance.Models.DbModels.Employer
{
    public class EmployerModel : BaseModel
    {
        public UserModel User { get; set; }
        public string WorkingArea { get; set; }
        public string WorkingCompany { get; set; }
        public List<JobOfferModel> JobOffers { get; set; }
    }
}
