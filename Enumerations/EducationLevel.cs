using System.ComponentModel;

namespace StudentLance.Enumerations
{
    public enum EducationLevel
    {
        [Description("High School")]
        HighSchool = 1,
        [Description("Associate Degree")]
        AssociateDegree = 2,
        Bachelor = 3,
        Master = 4,
        Postgraduate = 5
    }
}
