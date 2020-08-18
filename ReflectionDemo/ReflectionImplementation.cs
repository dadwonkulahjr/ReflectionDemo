using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    public class ReflectionImplementation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ReflectionImplementation(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public ReflectionImplementation()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public string DisplayDetails()
        {
            return string.Format($"Fullname = {FirstName + " " + LastName}");
        }
    }
}
