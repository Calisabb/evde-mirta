using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_practice.models
{
    internal class Task
    {
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            Id = ++_id;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        static int _id;
        public int Id { get;  }

        public override string ToString()
        {
            return $"{Name} ({Description})";
        }




    }
}
