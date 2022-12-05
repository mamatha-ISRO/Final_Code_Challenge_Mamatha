using System.Text.Json.Serialization;

namespace LaunchpadCodeChallenge.API.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmpAddress { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public int DepartmentId { get; set; }


        [JsonIgnore]
        public virtual Departments Departments { get; set; }
    }
}
