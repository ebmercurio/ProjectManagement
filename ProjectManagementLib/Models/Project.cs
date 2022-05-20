namespace ProjectManagementLib {
    public class Project {
        public int Id { get; set; }
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        public string Status { get; set; } = "New";

    }
}