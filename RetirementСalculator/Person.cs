using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementСalculator
{
    internal class Person
    {
        public string Name { get; }
        public int Age { get; }
        public int YearsOfExperince { get; }
        
        public Person(string name, int age, int experiance)
        {
            Name = name;
            Age = age;
            YearsOfExperince = experiance;
        }
        public double GetRetiremetnValue(Func<int,int,double> values)
        {
            return values(Age, YearsOfExperince);
        }
    }
}
