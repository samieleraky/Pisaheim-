using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pisaheim;

namespace Pisaheim
{
    public class Course
    {
        public string _Name;
        public int _DurationInMinutes; 

        //Constructors
        public Course(string name)
        {
            _Name = name;
        }

        public Course (string name, int durationInMinutes)
        {
            _Name = name;
            _DurationInMinutes = durationInMinutes;
        }

        //Override methode 
        public override string ToString()
        {
            return $"Name: {_Name}, Duration in Minutes: {_DurationInMinutes}";
        }
    }
}
