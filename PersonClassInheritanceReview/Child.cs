using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClassInheritanceReview
{
    class Child : Person
    {
        public string Toy { get; set; }


        public Child()
        {

        }

        public Child(string name, int age, string toy) : base( name,  age)
        {
            this.Toy = toy;
        }



        public void Cry()
        {
            Console.WriteLine("{0} is crying. He wants his {1}", Name, Toy);
        }

        public override void DisplayAge()
        {
            // this will just display the same message from the virtual method
           // base.DisplayAge();
            // or
            Console.WriteLine("CHILD");
        }

    }
}
