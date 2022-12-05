namespace LaunchpadCodeChallenge.API.Models
{
    public class Departments
    {
        public int DepartmentsId { get; set; }
        public string DepartmentsName { get; set; }=String.Empty;
        public virtual List<Employees> Employees { get; set; }
    }
}
