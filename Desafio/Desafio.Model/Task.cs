using System;

namespace Desafio.Model
{
    public class Task
    {

        public Task(string name, string description, string status)
        {

            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Status = status;
            CreateDate = DateTime.Now;


        }

        public string Id {get; private set;}

        public string Name {get; private set;}

        public string Description {get; private set;}

        public string Status {get; private set;}

        public float Percentage {get; private set;}

        public DateTime CreateDate {get; private set;}

        public DateTime DoneDate {get; private set;}

        public void UpdateTask(string name, string description, string status)
        {
            Name = name;
            Description = description;
            Status = status;
            DoneDate = DateTime.Now;
        }



    }
}
