using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }

        public bool IsCompleted()
        {
            return completed;
        }

        public string GetName()
        {
            return name;
        }
    }
}