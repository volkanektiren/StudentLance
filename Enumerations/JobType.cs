using System.ComponentModel;

namespace StudentLance.Enumerations
{
    public enum JobType
    {
        Freelancer = 1,

        [Description("Part Time")]
        PartTime = 2,

        Seasonal = 3,
        Intern = 4,

        [Description("Full Time")]
        FullTime = 5,

        Volunteer = 6
    }
}
