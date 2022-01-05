using StudentLance.Enumerations;
using StudentLance.Models.Base;
using StudentLance.Models.DbModels.CurriculumVitae;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLance.Models.DbModels.Education
{
    public class EducationModel : BaseModel
    {
        public CurriculumVitaeModel CurriculumVitae { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public GraduationDegreeType GraduationDegreeType { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal GraduationDegree { get; set; }
        public string University { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string EducationLanguage { get; set; }
        public string DescriptionText { get; set; }
    }
}
