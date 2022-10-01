using System;
using System.Collections.Generic;
using Desafio.Model;
using MongoDB.Driver;
using Desafio.Data.Config;

namespace Desafio.Data.Repository
{

    public class TaskRepository: ITaskRepository 
    {

        private readonly IMongoCollection<Task> _tasks;

        public TaskRepository(IDatabaseConfig DataBaseConfig)
        {
                var client = new MongoClient(DataBaseConfig.ConnectionString);
                var database = client.GetDatabase(DataBaseConfig.DatabaseName);

                _tasks = database.GetCollection<Task>("Task");

        }


        public void Add(Task aTask)
        {
            _tasks.InsertOne(aTask);
        }

        public void Update(string id, Task aUpdatedTask)
        {
            _tasks.ReplaceOne(aTask => aTask.Id == id, aUpdatedTask);
        }

        public IEnumerable<Task> Get()
        {
            return _tasks.Find(aTask => true).ToList();
        }

        public Task Get(string id)
        {
            return _tasks.Find(aTask => aTask.Id == id).FirstOrDefault();
        }

        public void Delete(string id)
        {
            _tasks.DeleteOne(aTask => aTask.Id == id);
        }
    }
}