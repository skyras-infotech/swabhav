using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Task
    {
        private int _id;
        private string _task;
        private DateTime _creationDate;
        private string _complete;

        public Task(int id, string task, DateTime creationDate, string complete)
        {
            _id = id;
            _task = task;
            _creationDate = creationDate;
            _complete = complete;
        }

        public string Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }


        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }


        public string Tasks
        {
            get { return _task; }
            set { _task = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
