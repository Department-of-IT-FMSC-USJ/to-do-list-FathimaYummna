using System;

namespace To_Do_List
{
    public class Task
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime Date;
        public string Status;

        public Task(int id, string name, string description, DateTime date)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Status = "To Do";
        }

        public override string ToString()
        {
            return $"[{Status}] ID: {Id}, Name: {Name}, Date: {Date.ToShortDateString()}";
        }
    }
}
