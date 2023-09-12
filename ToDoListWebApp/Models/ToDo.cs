namespace ToDoListWebApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Task { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public Status Status { get; set; } = Status.Created;

    }
}
