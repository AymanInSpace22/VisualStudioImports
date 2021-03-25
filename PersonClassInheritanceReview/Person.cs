using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClassInheritanceReview
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        // you can set your values through the properties or through the constructor
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }


        public abstract void DisplayAge();
        /*{
            Console.WriteLine("{0} is {1} years old", Name, Age);
        }*/

    }
}
